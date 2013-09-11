namespace Omega.RhetosDsl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Tagging;
    using Microsoft.VisualStudio.Utilities;
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using Omega.RhetosDsl.Helpers;

    [Export(typeof(ITaggerProvider))]
    [ContentType("RhetosDsl")]
    [TagType(typeof(RhetosTokenTag))]
    internal sealed class RhetosTokenTagProvider : ITaggerProvider
    {

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            return new RhetosTokenTagger(buffer) as ITagger<T>;
        }
    }

    public class RhetosTokenTag : ITag 
    {
        public RhetosTokenTypes type { get; private set; }

        public RhetosTokenTag(RhetosTokenTypes type)
        {
            this.type = type;
        }
    }

    internal sealed class RhetosTokenTagger : ITagger<RhetosTokenTag>
    {

        ITextBuffer _buffer;
        IDictionary<string, RhetosTokenTypes> _rhetosTypes;

        internal RhetosTokenTagger(ITextBuffer buffer)
        {
            _buffer = buffer;
            _rhetosTypes = new Dictionary<string, RhetosTokenTypes>();
            foreach (var rhetosTokenType in EnumUtil.GetValues<RhetosTokenTypes>())
            {
                _rhetosTypes[rhetosTokenType.ToString().ToLower()] = rhetosTokenType;
            }
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        public IEnumerable<ITagSpan<RhetosTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {

            foreach (SnapshotSpan curSpan in spans)
            {
                ITextSnapshotLine containingLine = curSpan.Start.GetContainingLine();

                var regEx = @"(\b[^\s]+\b)";
                int curLoc = containingLine.Start.Position;

                var matchCollection = Regex.Matches(containingLine.GetText(), regEx, RegexOptions.IgnoreCase);


                foreach (Match tokenMatch in matchCollection)
                {
                    var matchLoc = curLoc + tokenMatch.Index;
                    if (_rhetosTypes.ContainsKey(tokenMatch.Value.ToLower()))
                    {
                        var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(matchLoc, tokenMatch.Length));
                        if (tokenSpan.IntersectsWith(curSpan))
                        {
                            Debug.WriteLine(String.Format("Match: {0}, CurLoc: {1}, Match index: {2}, MatchLoc: {3}", tokenMatch.Value, curLoc, tokenMatch.Index, matchLoc));
                            yield return new TagSpan<RhetosTokenTag>(tokenSpan, new RhetosTokenTag(_rhetosTypes[tokenMatch.Value.ToLower()]));
                        }
                    }
                }
            }
            
        }
    }
}
