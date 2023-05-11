using System;
using System.Collections.Generic;

namespace eSyaFeedback.DL.Entities
{
    public partial class GtFbqegr
    {
        public string FeedBackType { get; set; }
        public int QuestionnaireGroupId { get; set; }
        public string Langauge { get; set; }
        public string QuestionnaireGroupDesc { get; set; }
        public decimal WeightedAverage { get; set; }
        public int DisplayOrder { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
