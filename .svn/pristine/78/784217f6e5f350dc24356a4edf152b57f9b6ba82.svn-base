using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaFeedback.DO;
using eSyaFeedback.IF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSyaFeedback.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientFeedbackTransactionController : ControllerBase
    {
        private readonly IPatientFeedbackTransactionRepository _PatientFeedbackTransactionRepository;

        public PatientFeedbackTransactionController(IPatientFeedbackTransactionRepository PatientFeedbackTransactionRepository)
        {
            _PatientFeedbackTransactionRepository = PatientFeedbackTransactionRepository;

        }
        /// <summary>
        /// Insert QuestionnaireMaster.
        /// UI Reffered -Patient Feedback
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoPatientFeedbackQuestionnaire(DO_PatientFeedback obj)
        {
            var msg = await _PatientFeedbackTransactionRepository.InsertIntoPatientFeedbackQuestionnaire(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Getting  Floor for dropdown.
        /// UI Reffered - Patient Feedback
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetFloorsbyCodeType(int codetype)
        {
            var floors =await _PatientFeedbackTransactionRepository.GetFloorsbyCodeType(codetype);
            return Ok(floors);
        }

        /// <summary>
        /// Getting  Specialities for dropdown.
        /// UI Reffered - Patient Feedback
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetSpecialtiesByBusinessKey(int businesskey)
        {
            var specialities =await _PatientFeedbackTransactionRepository.GetSpecialtiesByBusinessKey(businesskey);
            return Ok(specialities);
        }

        /// <summary>
        /// Getting  Doctors for dropdown.
        /// UI Reffered - Patient Feedback
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetDoctorsByBusinessKey(int businesskey)
        {
            var doctors = await _PatientFeedbackTransactionRepository.GetDoctorsByBusinessKey(businesskey);
            return Ok(doctors);
        }

        /// <summary>
        /// Getting  Patient Feed back header.
        /// UI Reffered - Patient Feedback
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetPatientFeedbackHeader(string feedbacktype, DateTime fromdate, DateTime todate)
        {
            var f_header = await _PatientFeedbackTransactionRepository.GetPatientFeedbackHeader(feedbacktype,fromdate,todate);
            return Ok(f_header);
        }

        /// <summary>
        /// Getting Patient Feed back details.
        /// UI Reffered - Patient Feedback
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetPatientFeedbackDetails(int businesskey, long fbdocumentkey, string feedbacktype)
        {
            var f_details = await _PatientFeedbackTransactionRepository.GetPatientFeedbackDetails(businesskey,fbdocumentkey,feedbacktype);
            return Ok(f_details);
        }
    }
}