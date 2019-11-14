// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserNotesRepository.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryLayer.Services
{
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using CommanLayer.Enum;
    using CommanLayer.Model;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Internal;
    using Microsoft.AspNetCore.Mvc;
    using RepositoryLayer.Context;
    using RepositoryLayer.Interface;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class UserNotesRepository : INotesRepository
    {
        /// <summary>
        /// Create the Instance variable of AuthenticationContext
        /// </summary>
        private readonly AuthenticationContext _authenticationContext;

        /// <summary>
        /// UserNotesRepository
        /// </summary>
        /// <param name="authenticationContext"></param>
        public UserNotesRepository(AuthenticationContext authenticationContext)
        {
            _authenticationContext = authenticationContext;
        }

        /// <summary>
        /// Add Notes
        /// </summary>
        /// <param name="notesModel"></param>
        /// <returns></returns>
        public async Task<bool> AddNotes(NotesModel notesModel)
        {
            //// addNotes stores the below data
            var addNotes = new NotesModel()
            {
                Id = notesModel.Id,
                UserId = notesModel.UserId,
                NotesTitle = notesModel.NotesTitle,
                NotesDescription = notesModel.NotesDescription,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                color = notesModel.color,
                NotesType = notesModel.NotesType,
                Reminder = notesModel.Reminder,
                Image = notesModel.Image,
                Archive = notesModel.Archive,
                Trash = notesModel.Trash,
                Pin = notesModel.Pin

            };

            //// Add the details of user in db
            this._authenticationContext.Add(addNotes);

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
        /// Get Notes
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IList<NotesModel> GetNotes(string UserId)
        {
            //// Here the Linq querey return the Record match in Database
            var list = from notes in _authenticationContext.notesModels.Where(g => g.UserId == UserId && g.Trash == false && g.Archive == false) select notes;
            return list.ToList();
        }

        /// <summary>
        /// Update Notes
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> UpdateNotes(NotesModel model, int id)
        {
            //// Here we retrive the id of user from db
            var query = from notes in _authenticationContext.notesModels
                        where notes.Id == id
                        select notes;

            ////if notes data have records then it will update the records
            foreach (var updateNote in query)
            {

                updateNote.NotesTitle = model.NotesTitle;
                updateNote.NotesDescription = model.NotesDescription;
                updateNote.color = model.color;
            }
            ////save changes to the database
            var result = await this._authenticationContext.SaveChangesAsync();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Delete Notes
        /// </summary>
        /// <param name="notesModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteNotes(NotesModel notesModel, int id)
        {
            var deleteOrderDetails =
                from details in _authenticationContext.notesModels
                where details.Id == id && details.UserId == notesModel.UserId
                select details;
            foreach (var deleteNote in deleteOrderDetails)
            {
                //// remove the record from database
                _authenticationContext.Remove(deleteNote);
            }

            ////save changes to the database
            var result = await this._authenticationContext.SaveChangesAsync();
            return true;

        }

        public string AddImage(string url, string userid, int id, IFormFile file)
        {
            //// Linq Query to select note id to set the image to notes
            var image = (from notes in _authenticationContext.notesModels
                         where notes.Id == id
                         select notes).FirstOrDefault();

            //// Here the image column store the url of image
            image.Image = url;

            //// save the changes in Database
            var result = _authenticationContext.SaveChanges();

            if (result > 0)
            {
                return url;
            }
            else
            {
                return "Image not uploaded";
            }
        }

        public async Task<bool> Archive(int id)
        {
            //// Linq Query to select note id to Archive the note
            var ArchiveNote = (from note in _authenticationContext.notesModels
                               where note.Id == id
                               select note).FirstOrDefault();


            if (ArchiveNote != null)
            {
                //// Here we check the status of Archive i.e true or false if false then change the status to Archive note
                if (ArchiveNote.Archive == false)
                {
                    ArchiveNote.Archive = true;
                }

                await _authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UnArchive(int id)
        {
            //// Linq Query to select note id to UnArchive the note
            var UnarchiveNote = (from note in _authenticationContext.notesModels
                                 where note.Id == id
                                 select note).FirstOrDefault();

            if (UnarchiveNote != null)
            {
                if (UnarchiveNote.Archive == true)
                {
                    UnarchiveNote.Archive = false;
                }
                await _authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Trash(int id)
        {
            var TrashNotes = (from note in _authenticationContext.notesModels
                              where note.Id == id
                              select note).FirstOrDefault();

            if(TrashNotes != null)
            {
                if(TrashNotes.Trash == false)
                {
                    TrashNotes.Trash = true;
                }

                await _authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UnTrash(int id)
        {
            var TrashNotes = (from note in _authenticationContext.notesModels
                              where note.Id == id
                              select note).FirstOrDefault();

            if (TrashNotes != null)
            {
                if (TrashNotes.Trash == true)
                {
                    TrashNotes.Trash = false;
                }

                await _authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Pin(int id)
        {
            var PinNotes = (from note in _authenticationContext.notesModels
                              where note.Id == id
                              select note).FirstOrDefault();

            if (PinNotes != null)
            {
                if (PinNotes.Pin == false)
                {
                    PinNotes.Pin = true;
                }

                await _authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UnPin(int id)
        {
            var UnPinNotes = (from note in _authenticationContext.notesModels
                              where note.Id == id
                              select note).FirstOrDefault();

            if (UnPinNotes != null)
            {
                if (UnPinNotes.Pin == true)
                {
                    UnPinNotes.Pin = false;
                }

                await _authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
