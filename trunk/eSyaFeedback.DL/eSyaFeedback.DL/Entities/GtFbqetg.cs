using System;
using System.Collections.Generic;

namespace eSyaFeedback.DL.Entities
{
    public partial class GtFbqetg
    {
        public int BusinessKey { get; set; }
        public int FinancialYear { get; set; }
        public string FeedBackType { get; set; }
        public int MonthId { get; set; }
        public int TargetForMonth { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
