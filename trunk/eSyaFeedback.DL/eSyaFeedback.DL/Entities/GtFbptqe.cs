﻿using System;
using System.Collections.Generic;

namespace eSyaFeedback.DL.Entities
{
    public partial class GtFbptqe
    {
        public int BusinessKey { get; set; }
        public long FbdocumentKey { get; set; }
        public int QuestionnaireId { get; set; }
        public int? QuestionnaireValue { get; set; }
        public string Comments { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
    }
}
