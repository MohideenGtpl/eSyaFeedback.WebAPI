using eSyaFeedback.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSyaFeedback.IF
{
    public interface IFeedbackQuestionnaireRepository
    {
        #region Questionaire Group
        Task<List<DO_QuestionnaireGroup>> GetQuestionnaireGroup(string feedBackType, string langauge);

        Task<List<DO_QuestionnaireGroup>> GetAllQuestionnaireGroupbyFeedbackType(string feedBackType, string langauge);

        Task<DO_ReturnParameter> InsertIntoQuestionnaireGroup(DO_QuestionnaireGroup obj);

        Task<DO_ReturnParameter> UpdateQuestionnaireGroup(DO_QuestionnaireGroup obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveQuestionnaireGroup(bool status, int qgroupId, string language, string feedbacktype);
        #endregion Questionaire Group

        #region Questionaire Master
        Task<List<DO_QuestionnaireMaster>> GetQuestionnaireMaster(string feedBackType, string langauge);

        Task<List<DO_QuestionnaireMaster>> GetAllQuestionnairesbyFeedbackType(string feedBackType, string langauge);

        Task<DO_ReturnParameter> InsertIntoQuestionnaireMaster(DO_QuestionnaireMaster obj);

        Task<DO_ReturnParameter> UpdateQuestionnaireMaster(DO_QuestionnaireMaster obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveQuestionnaireMaster(bool status, int questionId, int groupId, string language, string feedbacktype);
        #endregion Questionaire Master
    }
}
