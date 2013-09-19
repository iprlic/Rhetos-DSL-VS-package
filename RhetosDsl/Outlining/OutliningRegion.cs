using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhetosDsl
{
    public class PartialOutliningRegion
    {
        public int StartLine { get; set; }
        public int StartOffset { get; set; }
        public int Level { get; set; }
        public PartialOutliningRegion PartialParent { get; set; }
    }

    public class OutliningRegion : PartialOutliningRegion
    {
        public int EndLine { get; set; }
    } 
}
