using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace RhetosDsl.Outlining
{

    [Export(typeof(ITaggerProvider))]
    [ContentType("RhetosDsl")]
    [TagType(typeof(TodoTag))]
    class TodoTaggerProvider : ITaggerProvider
    {

        [Import]
        internal IClassifierAggregatorService AggregatorService;

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            if (buffer == null)
            {
                throw new ArgumentNullException("buffer");
            }

            return new TodoTagger(AggregatorService.GetClassifier(buffer)) as ITagger<T>;
        }
    }

    internal class TodoTag : IGlyphTag
    {
        
    }

    internal class TodoTagger : ITagger<TodoTag>
    {
        private IClassifier m_classifier;
        private const string m_searchText = "//todo";

        internal TodoTagger(IClassifier classifier)
        {
            m_classifier = classifier;
        }

        IEnumerable<ITagSpan<TodoTag>> ITagger<TodoTag>.GetTags(NormalizedSnapshotSpanCollection spans)
        {
            foreach (SnapshotSpan span in spans)
            {                foreach (ClassificationSpan classification in m_classifier.GetClassificationSpans(span))
                {

                    if (classification.ClassificationType.Classification.Contains("RhetosComment"))
                    {
                        int index = classification.Span.GetText().ToLower().IndexOf(m_searchText);
                        if (index != -1)
                        {
                            yield return new TagSpan<TodoTag>(new SnapshotSpan(classification.Span.Start + index, m_searchText.Length), new TodoTag());
                        }
                    }
                }
            }
        }

        public event EventHandler<Microsoft.VisualStudio.Text.SnapshotSpanEventArgs> TagsChanged;


    }

}
