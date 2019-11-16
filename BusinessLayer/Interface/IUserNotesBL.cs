// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserNotesBL.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BusinessLayer.Interface
{
    using CommanLayer.Model;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// IUserNotesBL
    /// </summary>
    public interface IUserNotesBL
    {
        /// <summary>
        /// Add Notes
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> AddNotes(NotesModel model);

        /// <summary>
        /// Get Notes
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        IList<NotesModel> GetNotes(string UserId);

        /// <summary>
        /// Update Notes
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> UpdateNotes(NotesModel model,int id);

        /// <summary>
        /// Delete Notes
        /// </summary>
        /// <param name="notesModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteNotes(NotesModel notesModel, int id);

        string AddImage( string userid, int id, IFormFile file);

         Task<bool> Archive(int id);
        Task<bool> UnArchive(int id);
        Task<bool> Trash(int id);
        Task<bool> UnTrash(int id);

        Task<bool> Pin(int id);
        Task<bool> UnPin(int id);
        Task<bool> AddReminder(int id, DateTime time);
        Task<bool> DeleteReminder(int id);
    }
}
