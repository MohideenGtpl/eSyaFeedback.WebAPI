using eSyaFeedback.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSyaFeedback.IF
{
   public interface IPatientFeedbackTransactionRepository
    {
        Task<DO_ReturnParameter> InsertIntoPatientFeedbackQuestionnaire(DO_PatientFeedback obj);

        Task<List<DO_Floor>> GetFloorsbyCodeType(int codetype);

         Task<List<DO_Specialty>> GetSpecialtiesByBusinessKey(int businesskey);

        Task<List<DO_Doctor>> GetDoctorsByBusinessKey(int businesskey);

        Task<List<DO_PatientFeedback>> GetPatientFeedbackHeader(string feedbacktype, DateTime fromdate, DateTime todate);

        Task<DO_PatientFeedback> GetPatientFeedbackDetails(int businesskey, long fbdocumentkey, string feedbacktype);
    }
}
