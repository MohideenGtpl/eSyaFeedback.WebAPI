using System;
using System.Collections.Generic;

namespace eSyaFeedback.DL.Entities
{
    public partial class GtFbptcm
    {
        public int BusinessKey { get; set; }
        public long FbdocumentKey { get; set; }
        public int CommentCode { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
