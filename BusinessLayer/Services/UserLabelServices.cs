// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserLabelServices.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------

namespace BusinessLayer.Services
{
    using BusinessLayer.Interface;
    using CommanLayer.Model;
    using RepositoryLayer.Interface;
    using ServiceStack.Redis;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// UserLabelServices
    /// </summary>
    public class UserLabelServices : IUserLabelBussiness
    {
        /// <summary>
        /// Create the instance variable of ILabelRepositoryManager
        /// </summary>
        private readonly ILabelRepositoryManager _repositoryManager;

        /// <summary>
        /// Create the constructor of class with parameter 
        /// </summary>
        /// <param name="repositoryManager"></param>
        public UserLabelServices(ILabelRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        /// <summary>
        /// AddLabel() method is used to add the label to our notes 
        /// </summary>
        /// <param name="labelModel"></param>
        /// <returns></returns>
        public async Task<bool> AddLabel(LabelModel labelModel)
        {
            try
            {
                //// Here checked labelModel contains information or not 
                if (labelModel != null)
                {
                    return await _repositoryManager.AddLabel(labelModel);
                }
                else
                {
                    throw new Exception ("Label not added");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// UpdateLabel() method is to Update the label  
        /// </summary>
        /// <param name="labelModelDetails"></param>
        /// <param name="labelName"></param>
        /// <returns></returns>
        public async Task<bool> UpdateLabel(LabelModel labelModelDetails, int id)
        {
            try
            {
                var result = await this._repositoryManager.UpdateLabel(labelModelDetails,id);

                ////key to store value in redis
                var cacheKey = "data" + labelModelDetails.UserId;
                using (var redis = new RedisClient())
                {

                    ////removing the cache from redis
                    redis.Remove(cacheKey);
                    
                    ////condtion to check if there are record or not in redis
                    if (redis.Get(cacheKey) == null)
                    {
                        if (result == true)
                        {
                            ////sets the data to the redis
                            redis.Set(cacheKey, result);
                            redis.Get(cacheKey);
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //try
            //{
            //    //// Here checked labelModelDetails contains information or not 
            //    if (labelModelDetails != null)
            //    {
            //        return await _repositoryManager.UpdateLabel(labelModelDetails, labelName);
            //    }
            //    else
            //    {
            //        throw new Exception("Label is not updated");
            //    }
            //}
            //catch(Exception exception)
            //{
            //    throw exception;
            //}           
        }

        /// <summary>
        /// GetLabel() is used to get the information about label
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<LabelModel> GetLabel(string userId)
        {
            try
            {
                //// Here checked userId contains information or not 
                if (userId != null)
                {
                   var result = _repositoryManager.GetLabel(userId);
                    return result;
                   
                }
                else
                {
                    throw new Exception("Invalid label");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// DeleteLabel() is used to delete label 
        /// </summary>
        /// <param name="labelModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteLabel(LabelModel labelModel, int id)
        {
            try
            {
                //// Here checked labelModel contains information or not 
                if (labelModel != null)
                {
                    //// variable result store the result of DeleteLabel()  
                    var result = await _repositoryManager.DeleteLabel(labelModel, id);
                    return result;
                }
                else
                {
                    throw new Exception("label are not deleted");
                }

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
