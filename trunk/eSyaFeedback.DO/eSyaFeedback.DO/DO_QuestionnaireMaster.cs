﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eSyaFeedback.DO
{
    public class DO_QuestionnaireGroup
    {
        public int QuestionnaireGroupID { get; set; }
        public string QuestionnaireGroupDesc { get; set; }
        public int DisplayOrder { get; set; }

        public string FeedBackType { get; set; }
        public string Langauge { get; set; }
        public decimal WeightedAverage { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_QuestionnaireMaster
    {
        public int QuestionnaireGroupID { get; set; }
        public int QuestionnaireID { get; set; }
        public string QuestionnaireDesc { get; set; }
        public string QType { get; set; }
        public int DisplayOrder { get; set; }
        public int? QuestionnaireValue { get; set; }
        public string Comments { get; set; }
        public long FbdocumentKey { get; set; }

        public string FeedBackType { get; set; }
        public string Langauge { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string QuestionaireGroupName { get; set; }
    }

    public class DO_ReturnParameter
    {
        public bool Status { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public decimal ID { get; set; }
        public string Key { get; set; }
    }
    
}
