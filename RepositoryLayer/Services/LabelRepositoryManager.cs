using CommanLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace RepositoryLayer.Services
{
    public class LabelRepositoryManager  : ILabelRepositoryManager
    {
        private readonly AuthenticationContext _authenticationContext;
        public LabelRepositoryManager(AuthenticationContext authenticationContext)
        {
            _authenticationContext = authenticationContext;
        }
        public async Task<bool> AddLabel(LabelModel labelModel)
        {
            var addLabel = new LabelModel()
            {
                Id = labelModel.Id,
                UserId = labelModel.UserId,
                Label = labelModel.Label,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            };
           
            //// Add the details of user in db
            this._authenticationContext.Add(addLabel);

            //// save the the details in db and return a result
            var result = await _authenticationContext.SaveChangesAsync();

            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateLabel(LabelModel labelModelDetails, string labelName)
        {
            //// variable updateLabel store the Information of user like labelName
            var Updatelabel = from label in _authenticationContext.labelModels
                             where label.Label == labelName
                              select label;

            ////if notes data have records then it will update the records
            foreach (var label in Updatelabel)
            {
                label.Label = labelModelDetails.Label;
            }
            ////save changes to the database
            var result = await this._authenticationContext.SaveChangesAsync();

            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IList<LabelModel> GetLabel(string userId)
        {
            //// Here the Linq querey return the Record match in Database
            var list = from label in _authenticationContext.labelModels.Where(g => g.UserId == userId) select label;
            return list.ToList();
        }

        public async Task<bool> DeleteLabel(LabelModel labelModel, int id)
        {
            var deleteLabelDetails =
                from details in _authenticationContext.labelModels
                where details.Id == id && details.UserId == labelModel.UserId
                select details;
            foreach (var deleteLabel in deleteLabelDetails)
            {
                //// remove the record from database
                _authenticationContext.Remove(deleteLabel);
            }

            ////save changes to the database
            var result = await this._authenticationContext.SaveChangesAsync();
            return true;

        }
    }
}
