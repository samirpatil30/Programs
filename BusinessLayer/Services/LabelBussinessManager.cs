﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelBussinessManager.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BusinessLayer.Services
{
    using BusinessLayer.Interface;
    using CommanLayer.Model;
    using RepositoryLayer.Interface;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// LabelBussinessManager
    /// </summary>
    public class LabelBussinessManager : ILabelBussinessManager
    {
        /// <summary>
        /// create the instance variable of ILabelRepositoryManager 
        /// </summary>
        private readonly ILabelRepositoryManager _repositoryManager;

        /// <summary>
        /// Create the constructor of class with parameter 
        /// </summary>
        /// <param name="repositoryManager"></param>
        public LabelBussinessManager(ILabelRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        /// <summary>
        /// Add Label
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
        /// Update Label 
        /// </summary>
        /// <param name="labelModelDetails"></param>
        /// <param name="labelName"></param>
        /// <returns></returns>
        public async Task<bool> UpdateLabel(LabelModel labelModelDetails, string labelName)
        {
            try
            {
                //// Here checked labelModelDetails contains information or not 
                if (labelModelDetails != null)
                {
                    return await _repositoryManager.UpdateLabel(labelModelDetails, labelName);
                }
                else
                {
                    throw new Exception("Label is not updated");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }           
        }

        /// <summary>
        /// Get Label
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
        /// Delete Label
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