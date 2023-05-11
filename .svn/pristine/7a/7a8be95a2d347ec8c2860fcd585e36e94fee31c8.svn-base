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
    public class FeedbackQuestionnaireController : ControllerBase
    {
        private readonly IFeedbackQuestionnaireRepository _FeedbackQuestionnaireRepository;
        
        public FeedbackQuestionnaireController(IFeedbackQuestionnaireRepository FeedbackQuestionnaireRepository)
        {
            _FeedbackQuestionnaireRepository = FeedbackQuestionnaireRepository;
           
        }
        #region Questionaire Group
        /// <summary>
        /// Getting  Questionnaire Group.
        /// UI Reffered - Patient Feedback
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetQuestionnaireGroup(string feedBackType, string langauge)
        {
            var q_group = await _FeedbackQuestionnaireRepository.GetQuestionnaireGroup(feedBackType, langauge);
            return Ok(q_group);
        }
        /// <summary>
        /// Getting  Questionnaire Group for Grid.
        /// UI Reffered - Questionaire Group
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllQuestionnaireGroupbyFeedbackType(string feedBackType, string langauge)
        {
            var q_group = await _FeedbackQuestionnaireRepository.GetAllQuestionnaireGroupbyFeedbackType(feedBackType, langauge);
            return Ok(q_group);
        }
        /// <summary>
        /// Insert Questionnaire Group.
        /// UI Reffered -Questionaire Group
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoQuestionnaireGroup(DO_QuestionnaireGroup obj)
        {
            var msg = await _FeedbackQuestionnaireRepository.InsertIntoQuestionnaireGroup(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Update Questionnaire Group.
        /// UI Reffered -Questionaire Group
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> UpdateQuestionnaireGroup(DO_QuestionnaireGroup obj)
        {
            var msg = await _FeedbackQuestionnaireRepository.UpdateQuestionnaireGroup(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Active DeActive Questionnaire Group.
        /// UI Reffered -Questionaire Group
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> ActiveOrDeActiveQuestionnaireGroup(bool status, int qgroupId, string language, string feedbacktype)
        {
            var msg = await _FeedbackQuestionnaireRepository.ActiveOrDeActiveQuestionnaireGroup(status,qgroupId,language,feedbacktype);
            return Ok(msg);

        }
        #endregion Questionaire Group

        #region Questionaire Master

        #endregion Questionaire Master
        /// <summary>
        /// Getting  Questionnaire Master.
        /// UI Reffered - Patient Feedback
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetQuestionnaireMaster(string feedBackType, string langauge)
        {
            var q_master =await _FeedbackQuestionnaireRepository.GetQuestionnaireMaster(feedBackType, langauge);
            return Ok(q_master);
        }

        /// <summary>
        /// Getting  Questionnaire Master for Grid.
        /// UI Reffered - Questionaire Master
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllQuestionnairesbyFeedbackType(string feedBackType, string langauge)
        {
            var q_group = await _FeedbackQuestionnaireRepository.GetAllQuestionnairesbyFeedbackType(feedBackType, langauge);
            return Ok(q_group);
        }
        /// <summary>
        /// Insert Questionnaire Master.
        /// UI Reffered -Questionaire Master
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoQuestionnaireMaster(DO_QuestionnaireMaster obj)
        {
            var msg = await _FeedbackQuestionnaireRepository.InsertIntoQuestionnaireMaster(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Update Questionnaire Master.
        /// UI Reffered -Questionaire Master
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> UpdateQuestionnaireMaster(DO_QuestionnaireMaster obj)
        {
            var msg = await _FeedbackQuestionnaireRepository.UpdateQuestionnaireMaster(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Active DeActive Questionnaire Master.
        /// UI Reffered -Questionaire Master
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> ActiveOrDeActiveQuestionnaireMaster(bool status, int questionId, int groupId, string language, string feedbacktype)
        {
            var msg = await _FeedbackQuestionnaireRepository.ActiveOrDeActiveQuestionnaireMaster(status, questionId, groupId, language, feedbacktype);
            return Ok(msg);

        }
    }
}