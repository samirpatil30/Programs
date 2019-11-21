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
    using System.Collections;
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
        /// <param name="notesModel">notesModel</param>
        /// <returns>result</returns>
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
            var result = await this._authenticationContext.SaveChangesAsync();
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
        public IList<NotesModel> GetNotes(string UserId,int pageNumber, int NotePerPage)
        {
            //// Here the Linq querey return the Record match in Database
            var list = from notes in this._authenticationContext.notesModels.Where(g => g.UserId == UserId && g.Trash == false && g.Archive == false) select notes;
            
            int count = list.Count();
            int CurrentPage = pageNumber;
            int PageSize = NotePerPage;
            int TotalCount = count;

            // Calculating Totalpage by Dividing (No of Records / Pagesize)  
            int TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
            var items = list.Skip((CurrentPage - 1) * PageSize).Take(PageSize);
   
          //  return sourece1.ToList();
            return items.ToList();
        }

        /// <summary>
        /// Update Notes
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <returns>result</returns>
        public async Task<bool> UpdateNotes(NotesModel model, int id)
        {
            //// Here we retrive the id of user from db
            var query = from notes in this._authenticationContext.notesModels
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
                from details in this._authenticationContext.notesModels
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

        /// <summary>
        /// Adds the image.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="userid">The userid.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        public string AddImage(string url, string userid, int id, IFormFile file)
        {
            //// Linq Query to select note id to set the image to notes
            var image = (from notes in this._authenticationContext.notesModels
                         where notes.Id == id
                         select notes).FirstOrDefault();

            //// Here the image column store the url of image
            image.Image = url;
            //// save the changes in Database
            var result = this._authenticationContext.SaveChanges();

            if (result > 0)
            {
                return url;
            }
            else
            {
                return "Image not uploaded";
            }
        }

        /// <summary>
        /// Archives the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> Archive(int id)
        {
            //// Linq Query to select note id to Archive the note
            var ArchiveNote = (from note in this._authenticationContext.notesModels
                               where note.Id == id
                               select note).FirstOrDefault();

            if (ArchiveNote != null)
            {
                //// Here we check the status of Archive i.e true or false if false then change the status to Archive note
                if (ArchiveNote.Archive == false)
                {
                    ArchiveNote.Archive = true;
                }

                await this._authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Un archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> UnArchive(int id)
        {
            //// Linq Query to select note id to UnArchive the note
            var UnarchiveNote = (from note in this._authenticationContext.notesModels
                                 where note.Id == id
                                 select note).FirstOrDefault();

            if (UnarchiveNote != null)
            {
                if (UnarchiveNote.Archive == true)
                {
                    UnarchiveNote.Archive = false;
                }

                await this._authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Trashes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> Trash(int id)
        {
            //// Linq Query to select note id to Trash the note
            var TrashNotes = (from note in this._authenticationContext.notesModels
                              where note.Id == id
                              select note).FirstOrDefault();

            if (TrashNotes != null)
            {
                if (TrashNotes.Trash == false)
                {
                    TrashNotes.Trash = true;
                }

                await this._authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Un trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> UnTrash(int id)
        {
            //// Linq Query to select note id to Untrash the note
            var TrashNotes = (from note in this._authenticationContext.notesModels
                              where note.Id == id
                              select note).FirstOrDefault();

            if (TrashNotes != null)
            {
                if (TrashNotes.Trash == true)
                {
                    TrashNotes.Trash = false;
                }

                await this._authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> Pin(int id)
        {
            //// Linq Query to select note id to Pin the note
            var PinNotes = (from note in this._authenticationContext.notesModels
                            where note.Id == id
                            select note).FirstOrDefault();

            if (PinNotes != null)
            {
                if (PinNotes.Pin == false)
                {
                    PinNotes.Pin = true;
                }

                await this._authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> UnPin(int id)
        {
            //// Linq Query to select note id to Unpin the note
            var UnPinNotes = (from note in this._authenticationContext.notesModels
                              where note.Id == id
                              select note).FirstOrDefault();

            if (UnPinNotes != null)
            {
                if (UnPinNotes.Pin == true)
                {
                    UnPinNotes.Pin = false;
                }

                await this._authenticationContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds the reminder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="time">The time.</param>
        /// <returns></returns>
        public async Task<bool> AddReminder(int id, DateTime time)
        {
            FireBaseNotification fireBaseNotification = new FireBaseNotification();
            //// Linq Query to select note id and time to Add reminder for note
            var Reminder = (from note in this._authenticationContext.notesModels
                            where note.Id == id
                            select note).FirstOrDefault();
            
            Reminder.Reminder = time; 
            var result = await this._authenticationContext.SaveChangesAsync();
                     
              fireBaseNotification.Notification(Reminder);
            
            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the reminder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> DeleteReminder(int id)
        {
            //// Linq Query to select note id and time to Delete reminder for note
            var DeleteReminder = (from note in this._authenticationContext.notesModels
                                  where note.Id == id
                                  select note).FirstOrDefault();

            DeleteReminder.Reminder = DateTime.MinValue;
            var result = await this._authenticationContext.SaveChangesAsync();

            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public async Task<bool> Collabrate(int Noteid, IList<string> UserId)
        {
            try
            {
                var ListOFSenders = (from notes in _authenticationContext.notesModels
                                     where notes.Id == Noteid
                                     select notes).FirstOrDefault();

                foreach (var User in UserId)
                {
                    var list = new CollabrationModel();
                    list.UserId = User;
                    list.NoteId = Noteid;
                    list.CurrentUserId = ListOFSenders.UserId;
                    _authenticationContext.Add(list);
                    var result = await this._authenticationContext.SaveChangesAsync();
                }

                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public async Task<bool> BulkTrash(IList<int> id)
        {
            foreach (var deleteId in id)
            {
                var Deletenote = (from note in _authenticationContext.notesModels
                                  where note.Id == deleteId
                                  select note).FirstOrDefault();
                _authenticationContext.Remove(Deletenote);

            }
            var result = await this._authenticationContext.SaveChangesAsync();
            return true;
        }

        public IList<NotesModel> Search(string anything)
        {
            IList<NotesModel> listResults = new List<NotesModel>();

            try
            {
                var resultsFromLabel = (from lable in _authenticationContext.labelModels
                                        where lable.Label == anything
                                        select lable);
                
                if (resultsFromLabel != null)
                {
                    foreach (LabelModel model in resultsFromLabel)
                    {
                        var result = (from note in _authenticationContext.notesModels
                                      where note.UserId == model.UserId 
                                      select note);

                        ///  NotesModel notesModel =(NotesModel) res;

                        foreach (NotesModel modelNote in result)
                        {
                            if (listResults.Contains(modelNote))
                            {
                                break;
                            }
                            else
                            {
                               listResults.Add(modelNote);                              
                            }
                        }
                    }
                    return listResults.ToList();
                }
                else
                {
                    throw new Exception("Note not found");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}