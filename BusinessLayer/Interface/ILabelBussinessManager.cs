// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILabelBussinessManager.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BusinessLayer.Interface
{
    using CommanLayer.Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// ILabelBussinessManager
    /// </summary>
    public interface ILabelBussinessManager
    {
        /// <summary>
        /// Add Label
        /// </summary>
        /// <param name="labelModel"></param>
        /// <returns></returns>
        Task<bool> AddLabel(LabelModel labelModel);

        /// <summary>
        /// Update Label
        /// </summary>
        /// <param name="labelModelDetails"></param>
        /// <param name="labelName"></param>
        /// <returns></returns>
        Task<bool> UpdateLabel(LabelModel labelModelDetails, string labelName);

        /// <summary>
        /// Get Label
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IList<LabelModel> GetLabel(string userId);

        /// <summary>
        /// Delete Label
        /// </summary>
        /// <param name="labelModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteLabel(LabelModel labelModel, int id);
    }
}
