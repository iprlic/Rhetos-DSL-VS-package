namespace Omega.RhetosDsl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Text.Tagging;
    using Microsoft.VisualStudio.Utilities;
    using Helpers;
    using Microsoft.VisualStudio.Shell;

    [Export(typeof(ITaggerProvider))]
    [ContentType("RhetosDsl")]
    [TagType(typeof(ClassificationTag))]
    internal sealed class RhetosClassifierProvider : ITaggerProvider
    {

        [Export]
        [Name("RhetosDsl")]
        [BaseDefinition("code")]
        internal static ContentTypeDefinition RhetosContentType {get; set;}

        [Export]
        [FileExtension(".rhe")]
        [ContentType("RhetosDsl")]
        internal static FileExtensionToContentTypeDefinition RhetosFileType { get; set; }

        [Export]
        [FileExtension(".alpha")]
        [ContentType("RhetosDsl")]
        internal static FileExtensionToContentTypeDefinition AlphaFileType { get; set; }


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("RhetosDsl")]
        internal static ClassificationTypeDefinition RhetosClassificationType { get; set; }

        [Import]
        internal IClassificationTypeRegistryService ClassificationTypeRegistry = null;

        [Import]
        internal IBufferTagAggregatorFactoryService aggregatorFactory = null;

        [Import]
        internal IFileExtensionRegistryService fileExtensionsService { get; set; }

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
           ITagAggregator<RhetosTokenTag> rhetosTagAggregator = 
                                            aggregatorFactory.CreateTagAggregator<RhetosTokenTag>(buffer);

            return new RhetosClassifier(buffer, rhetosTagAggregator, ClassificationTypeRegistry) as ITagger<T>;
        }
    }

    internal sealed class RhetosClassifier : ITagger<ClassificationTag>
    {
        ITextBuffer _buffer;
        ITagAggregator<RhetosTokenTag> _aggregator;
        IDictionary<RhetosTokenTypes, IClassificationType> _rhetosTypes;

        internal RhetosClassifier(ITextBuffer buffer, 
                               ITagAggregator<RhetosTokenTag> rhetosTagAggregator, 
                               IClassificationTypeRegistryService typeService)
        {
            _buffer = buffer;
            _aggregator = rhetosTagAggregator;
            _rhetosTypes = new Dictionary<RhetosTokenTypes, IClassificationType>();
            foreach (var rhetosTokenType in EnumUtil.GetValues<RhetosTokenTypes>())
            {
                _rhetosTypes[rhetosTokenType] = typeService.GetClassificationType(rhetosTokenType.ToString());
            }
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {

            foreach (var tagSpan in this._aggregator.GetTags(spans))
            {
                var tagSpans = tagSpan.Span.GetSpans(spans[0].Snapshot);
                yield return 
                    new TagSpan<ClassificationTag>(tagSpans[0], 
                                                   new ClassificationTag(_rhetosTypes[tagSpan.Tag.type]));
            }
        }
    }
}
