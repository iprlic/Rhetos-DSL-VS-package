using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using Microsoft.VisualStudio.Language.Intellisense;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;


namespace Omega.RhetosDsl
{
    
    [Export(typeof(IQuickInfoSourceProvider))]
    [ContentType("RhetosDsl")]
    [Name("RhetosQuickInfo")]
    class RhetosQuickInfoSourceProvider : IQuickInfoSourceProvider
    {

        [Import]
        IBufferTagAggregatorFactoryService aggService = null;

        public IQuickInfoSource TryCreateQuickInfoSource(ITextBuffer textBuffer)
        {
            return new RhetosQuickInfoSource(textBuffer, aggService.CreateTagAggregator<RhetosTokenTag>(textBuffer));
        }
    }

    class RhetosQuickInfoSource : IQuickInfoSource
    {
        private ITagAggregator<RhetosTokenTag> _aggregator;
        private ITextBuffer _buffer;
        private bool _disposed = false;


        public RhetosQuickInfoSource(ITextBuffer buffer, ITagAggregator<RhetosTokenTag> aggregator)
        {
            _aggregator = aggregator;
            _buffer = buffer;
        }

        public void AugmentQuickInfoSession(IQuickInfoSession session, IList<object> quickInfoContent, out ITrackingSpan applicableToSpan)
        {
            applicableToSpan = null;

            if (_disposed)
                throw new ObjectDisposedException("TestQuickInfoSource");

            var triggerPoint = (SnapshotPoint) session.GetTriggerPoint(_buffer.CurrentSnapshot);


            foreach (IMappingTagSpan<RhetosTokenTag> curTag in _aggregator.GetTags(new SnapshotSpan(triggerPoint, triggerPoint)))
            {
                //TODO: ostali keywordi
                if (curTag.Tag.type == RhetosTokenTypes.Module)
                {
                    var tagSpan = curTag.Span.GetSpans(_buffer).First();
                    applicableToSpan = _buffer.CurrentSnapshot.CreateTrackingSpan(tagSpan, SpanTrackingMode.EdgeExclusive);
                    quickInfoContent.Add("Rhetos module");
                }
            }
        }



        public void Dispose()
        {
            _disposed = true;
        }
    }
}

