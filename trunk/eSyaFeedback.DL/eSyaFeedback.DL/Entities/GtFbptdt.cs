﻿using System;
using System.Collections.Generic;

namespace eSyaFeedback.DL.Entities
{
    public partial class GtFbptdt
    {
        public int BusinessKey { get; set; }
        public int FinancialYear { get; set; }
        public int DocumentId { get; set; }
        public int DocumentNumber { get; set; }
        public long FbdocumentKey { get; set; }
        public DateTime DocumentDate { get; set; }
        public string FeedBackType { get; set; }
        public int FloorId { get; set; }
        public long RUhid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Isdcode { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public int? DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int? SpecialtyId { get; set; }
        public string PatientType { get; set; }
        public DateTime ReportedDate { get; set; }
        public int? OverAllRating { get; set; }
        public string CommentOnServices { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
