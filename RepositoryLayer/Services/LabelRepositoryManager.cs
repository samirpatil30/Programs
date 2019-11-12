// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelRepositoryManager.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace RepositoryLayer.Services
{
    using CommanLayer.Model;
    using RepositoryLayer.Context;
    using RepositoryLayer.Interface;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.Linq;
    public class LabelRepositoryManager  : ILabelRepositoryManager
    {
        /// <summary>
        /// Create the Reference Variable of AuthenticationContext  
        /// </summary>
        private readonly AuthenticationContext _authenticationContext;

        /// <summary>
        /// LabelRepositoryManager
        /// </summary>
        /// <param name="authenticationContext"></param>
        public LabelRepositoryManager(AuthenticationContext authenticationContext)
        {
            _authenticationContext = authenticationContext;
        }

        /// <summary>
        /// Add Label
        /// </summary>
        /// <param name="labelModel"></param>
        /// <returns></returns>
        public async Task<bool> AddLabel(LabelModel labelModel)
        {
            //// variable addLabel stores the below data
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

        /// <summary>
        /// Update Label
        /// </summary>
        /// <param name="labelModelDetails"></param>
        /// <param name="labelName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get Label
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<LabelModel> GetLabel(string userId)
        {
            //// Here the Linq querey return the Record match in Database
            var list = from label in _authenticationContext.labelModels.Where(g => g.UserId == userId) select label;
            return list.ToList();
        }

        /// <summary>
        /// Delete Label
        /// </summary>
        /// <param name="labelModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteLabel(LabelModel labelModel, int id)
        {
            //// deleteLabelDetails stores the result of below Linq query
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
