using eSyaFeedback.DL.Entities;
using eSyaFeedback.DO;
using eSyaFeedback.IF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSyaFeedback.DL.Repository
{
    public class FeedbackQuestionnaireRepository: IFeedbackQuestionnaireRepository
    {
        private eSyaEnterprise _context { get; set; }
        public FeedbackQuestionnaireRepository(eSyaEnterprise context)
        {
            _context = context;
        }

        #region Questionaire Group

        public async Task<List<DO_QuestionnaireGroup>> GetQuestionnaireGroup(string feedBackType, string langauge)
        {
            try
            {

                var q_grp = await _context.GtFbqegr
                            .Where(x => x.FeedBackType == feedBackType && x.Langauge == langauge
                                                && x.ActiveStatus)
                            .Select(x => new DO_QuestionnaireGroup
                            {
                                QuestionnaireGroupID = x.QuestionnaireGroupId,
                                QuestionnaireGroupDesc = x.QuestionnaireGroupDesc,
                            }).ToListAsync();
                return q_grp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_QuestionnaireGroup>> GetAllQuestionnaireGroupbyFeedbackType(string feedBackType, string langauge)
        {
            try
            {

                var q_grp = await _context.GtFbqegr
                            .Where(x => x.FeedBackType == feedBackType && x.Langauge == langauge)
                            .Select(x => new DO_QuestionnaireGroup
                            {
                                QuestionnaireGroupID = x.QuestionnaireGroupId,
                                QuestionnaireGroupDesc = x.QuestionnaireGroupDesc,
                                DisplayOrder = x.DisplayOrder,
                                FeedBackType = x.FeedBackType,
                                Langauge = x.Langauge,
                                WeightedAverage = x.WeightedAverage,
                                ActiveStatus = x.ActiveStatus
                            }).ToListAsync();
                return q_grp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DO_ReturnParameter> InsertIntoQuestionnaireGroup(DO_QuestionnaireGroup obj)
        {

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    int qgroupId_maxval = _context.GtFbqegr.Select(x => x.QuestionnaireGroupId).DefaultIfEmpty().Max();
                    qgroupId_maxval = qgroupId_maxval + 1;

                    GtFbqegr qp = new GtFbqegr();
                    qp.FeedBackType = obj.FeedBackType;
                    qp.QuestionnaireGroupId = qgroupId_maxval;
                    qp.Langauge = obj.Langauge;
                    qp.QuestionnaireGroupDesc = obj.QuestionnaireGroupDesc;
                    qp.WeightedAverage = obj.WeightedAverage;
                    qp.DisplayOrder = obj.DisplayOrder;
                    qp.ActiveStatus = true;
                    qp.FormId = obj.FormId;
                    qp.CreatedBy = obj.UserID;
                    qp.CreatedOn = System.DateTime.Now;
                    qp.CreatedTerminal = obj.TerminalID;
                    _context.GtFbqegr.Add(qp);
                    await _context.SaveChangesAsync();
                    dbContextTransaction.Commit();
                    return new DO_ReturnParameter() { Status = true, Message = "Saved Successfully." };

                }

                catch (DbUpdateException ex)
                {
                    dbContextTransaction.Rollback();
                    throw new Exception(CommonMethod.GetValidationMessageFromException(ex));
                }
            }
        }

        public async Task<DO_ReturnParameter> UpdateQuestionnaireGroup(DO_QuestionnaireGroup obj)
        {

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    GtFbqegr q_group = await _context.GtFbqegr.Where(x => x.QuestionnaireGroupId == obj.QuestionnaireGroupID && x.FeedBackType.ToUpper().Replace(" ", "") == obj.FeedBackType.ToUpper().Replace(" ", "")
                    && x.Langauge.ToUpper().Replace(" ", "") == obj.Langauge.ToUpper().Replace(" ", "")).FirstOrDefaultAsync();

                    q_group.QuestionnaireGroupDesc = obj.QuestionnaireGroupDesc;
                    q_group.WeightedAverage = obj.WeightedAverage;
                    q_group.DisplayOrder = obj.DisplayOrder;
                    q_group.ActiveStatus = true;
                    q_group.ModifiedBy = obj.UserID;
                    q_group.ModifiedOn = System.DateTime.Now;
                    await _context.SaveChangesAsync();
                    dbContextTransaction.Commit();
                    return new DO_ReturnParameter() { Status = true, Message = "Updated Successfully." };

                }

                catch (DbUpdateException ex)
                {
                    dbContextTransaction.Rollback();
                    throw new Exception(CommonMethod.GetValidationMessageFromException(ex));
                }
            }
        }

        public async Task<DO_ReturnParameter> ActiveOrDeActiveQuestionnaireGroup(bool status, int qgroupId,string language, string feedbacktype)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        GtFbqegr q_group = await _context.GtFbqegr.Where(x => x.QuestionnaireGroupId == qgroupId && x.FeedBackType.ToUpper().Replace(" ", "") == feedbacktype.ToUpper().Replace(" ", "")
                      && x.Langauge.ToUpper().Replace(" ", "") == language.ToUpper().Replace(" ", "")).FirstOrDefaultAsync();

                        if (q_group == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Questionaire Group is not exist" };
                        }

                        q_group.ActiveStatus = status;
                        await db.SaveChangesAsync();
                        dbContextTransaction.Commit();

                        if (status == true)
                            return new DO_ReturnParameter() { Status = true, Message = "Questionaire Group Activated Successfully." };
                        else
                            return new DO_ReturnParameter() { Status = true, Message = "Questionaire Group De Activated Successfully." };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContextTransaction.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));

                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        throw ex;
                    }
                }
            }
        }
        #endregion Questionaire Group

        #region Questionaire Master
        public async Task<List<DO_QuestionnaireMaster>> GetQuestionnaireMaster(string feedBackType, string langauge)
        {
            try
            {
                var q_grp = await _context.GtFbqems
                    .Where(x => x.FeedBackType == feedBackType && x.Langauge == langauge
                                                && x.ActiveStatus)
                    .Select(x => new DO_QuestionnaireMaster
                    {
                        QuestionnaireGroupID = x.QuestionnaireGroupId,
                        QuestionnaireID = x.QuestionnaireId,
                        QuestionnaireDesc = x.QuestionnaireDesc,
                        QType = x.Qtype,
                        DisplayOrder = x.DisplayOrder,
                    }).OrderBy(o => o.DisplayOrder).ToListAsync();
                return q_grp;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_QuestionnaireMaster>> GetAllQuestionnairesbyFeedbackType(string feedBackType, string langauge)
        {
            try
            {
                var q_grp = await _context.GtFbqems
                    .Where(x => x.FeedBackType == feedBackType && x.Langauge == langauge).Join(_context.GtFbqegr,
                          x => x.QuestionnaireGroupId,
                          y => y.QuestionnaireGroupId,
                          (x, y) => new DO_QuestionnaireMaster
                          {
                              FeedBackType=x.FeedBackType,
                              QuestionnaireID=x.QuestionnaireId,
                              Langauge=x.Langauge,
                              QuestionnaireGroupID=x.QuestionnaireGroupId,
                              QuestionnaireDesc=x.QuestionnaireDesc,
                              QType=x.Qtype,
                              DisplayOrder=x.DisplayOrder,
                              QuestionaireGroupName=y.QuestionnaireGroupDesc,
                              ActiveStatus=x.ActiveStatus
                          }).ToListAsync();
                return q_grp;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DO_ReturnParameter> InsertIntoQuestionnaireMaster(DO_QuestionnaireMaster obj)
        {

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    int qId_maxval = _context.GtFbqems.Select(x => x.QuestionnaireId).DefaultIfEmpty().Max();
                    qId_maxval = qId_maxval + 1;

                    GtFbqems fm = new GtFbqems();
                    fm.FeedBackType = obj.FeedBackType;
                    fm.QuestionnaireId = qId_maxval;
                    fm.Langauge = obj.Langauge;
                    fm.QuestionnaireGroupId = 1;
                    fm.QuestionnaireDesc = obj.QuestionnaireDesc;
                    fm.Qtype = obj.QType;
                    fm.DisplayOrder = obj.DisplayOrder;
                    fm.ActiveStatus = true;
                    fm.FormId = obj.FormId;
                    fm.CreatedBy = obj.UserID;
                    fm.CreatedOn = System.DateTime.Now;
                    fm.CreatedTerminal = obj.TerminalID;
                    _context.GtFbqems.Add(fm);
                    await _context.SaveChangesAsync();
                    dbContextTransaction.Commit();
                    return new DO_ReturnParameter() { Status = true, Message = "Saved Successfully." };

                }

                catch (DbUpdateException ex)
                {
                    dbContextTransaction.Rollback();
                    throw new Exception(CommonMethod.GetValidationMessageFromException(ex));
                }
            }
        }

        public async Task<DO_ReturnParameter> UpdateQuestionnaireMaster(DO_QuestionnaireMaster obj)
        {

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    GtFbqems q_master = await _context.GtFbqems.Where(x =>x.QuestionnaireId==obj.QuestionnaireID && x.QuestionnaireGroupId == obj.QuestionnaireGroupID && x.FeedBackType.ToUpper().Replace(" ", "") == obj.FeedBackType.ToUpper().Replace(" ", "")
                    && x.Langauge.ToUpper().Replace(" ", "") == obj.Langauge.ToUpper().Replace(" ", "")).FirstOrDefaultAsync();

                    q_master.QuestionnaireDesc = obj.QuestionnaireDesc;
                    q_master.Qtype = obj.QType;
                    q_master.DisplayOrder = obj.DisplayOrder;
                    q_master.ActiveStatus = true;
                    q_master.ModifiedBy = obj.UserID;
                    q_master.ModifiedOn = System.DateTime.Now;
                    q_master.ModifiedTerminal = obj.TerminalID;
                    await _context.SaveChangesAsync();
                    dbContextTransaction.Commit();
                    return new DO_ReturnParameter() { Status = true, Message = "Updated Successfully." };

                }

                catch (DbUpdateException ex)
                {
                    dbContextTransaction.Rollback();
                    throw new Exception(CommonMethod.GetValidationMessageFromException(ex));
                }
            }
        }

        public async Task<DO_ReturnParameter> ActiveOrDeActiveQuestionnaireMaster(bool status, int questionId, int groupId, string language, string feedbacktype)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        GtFbqems q_master = await _context.GtFbqems.Where(x =>x.QuestionnaireId==questionId && x.QuestionnaireGroupId == groupId && x.FeedBackType.ToUpper().Replace(" ", "") == feedbacktype.ToUpper().Replace(" ", "")
                      && x.Langauge.ToUpper().Replace(" ", "") == language.ToUpper().Replace(" ", "")).FirstOrDefaultAsync();

                        if (q_master == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Questionaire Master is not exist" };
                        }

                        q_master.ActiveStatus = status;
                        await db.SaveChangesAsync();
                        dbContextTransaction.Commit();

                        if (status == true)
                            return new DO_ReturnParameter() { Status = true, Message = "Questionaire Master Activated Successfully." };
                        else
                            return new DO_ReturnParameter() { Status = true, Message = "Questionaire Group De Activated Successfully." };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContextTransaction.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));

                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        throw ex;
                    }
                }
            }
        }
        #endregion Questionaire Master
    }
}

