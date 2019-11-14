// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserNotesBL.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BusinessLayer.Services
{
    using BusinessLayer.Interface;
    using CommanLayer.Model;
    using Microsoft.AspNetCore.Http;
    using RepositoryLayer.Interface;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// UserNotesBL
    /// </summary>
    public class UserNotesBL : IUserNotesBL
    {
        /// <summary>
        /// Create the instance variable of interface INotesRepository
        /// </summary>
        private readonly INotesRepository _notesRepository;

        /// <summary>
        /// User NotesBL
        /// </summary>
        /// <param name="notesRepository"></param>
        public UserNotesBL(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        /// <summary>
        /// Add Notes
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<bool> AddNotes(NotesModel model)
        {
            try
            {
                //// if checks the model is Null or not
                if (model != null)
                {
                  return  _notesRepository.AddNotes(model);
                }
                else
                {
                    throw new Exception("Empty notes");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Get Notes
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IList<NotesModel> GetNotes(string UserId)
        {
            try
            {
                //// if checks the model is Null or not
                if (UserId != null)
                {
                    var result=  _notesRepository.GetNotes(UserId);
                    return result;
                }
                else
                {
                    throw new Exception("Invalid User id");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Update Notes
        /// </summary>
        /// <param name="notesModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> UpdateNotes(NotesModel notesModel, int id)
        {
            try
            {
                //// if checks the notesModel is Null or not
                if (notesModel != null)
                {
                    var result = await _notesRepository.UpdateNotes(notesModel,id);
                    return result;
                }
                else
                {
                    throw new Exception("notes are not updated");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Delete Notes the notes from Database
        /// </summary>
        /// <param name="notesModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteNotes(NotesModel notesModel, int id)
        {
            try
            {
                //// if checks the notesModel is Null or not
                if (notesModel != null)
                {
                    var result = await _notesRepository.DeleteNotes(notesModel, id);
                    return result;
                }
                else
                {
                    throw new Exception("notes are not deleted");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public string AddImage( string userid, int id, IFormFile file)
        {
            try
            {
                CloudinaryImageUpload cloudinary = new CloudinaryImageUpload();
                var url = cloudinary.UploadImageOnCloud(file);
                if(userid != null)
                {
                    return _notesRepository.AddImage(url, userid, id, file); ;
                }
                else
                {
                    throw new Exception("Image is not uploaded");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

       public async Task<bool> Archive(int id)
        {
            var result = await _notesRepository.Archive(id);
            try
            {
                if(id != 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Note is not found select the correct note");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public async Task<bool> UnArchive(int id)
        {
            try
            {
                var result = await _notesRepository.UnArchive(id);
               
                if(id != 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Unable to Urachive note");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }

        }
    }
}
