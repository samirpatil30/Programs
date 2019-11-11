// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserNotesServices.cs" company="Bridgelabz">
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
    /// UserNotesServices
    /// </summary>
    public class UserNotesServices : IUserNotesBusiness
    {
        private readonly INotesRepository _notesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotesServices"/> class.
        /// </summary>
        /// <param name="notesRepository">The notes repository.</param>
        public UserNotesServices(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        /// <summary>
        /// Adds the notes.
        /// </summary> 
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception">Empty notes</exception>
        public Task<bool> AddNotes(NotesModel model)
        {
            try
            {
                //// if checks the model contains details or not if it is null it throw the exception
                if(model != null)
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
        /// Gets the notes.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception">Invalid User id</exception>
        public IList<NotesModel> GetNotes(NotesModel model)
        {
            try
            {
                //// if checks the model contains details or not if it is null it throw the exception
                if (model != null)
                {
                    var result=  _notesRepository.GetNotes(model);
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
        /// Updates the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> UpdateNotes(NotesModel notesModel, int id)
        {
            //try
            //{
            //    if (notesModel != null)
            //    {
            //        var result = await _notesRepository.UpdateNotes(notesModel,id);
            //        return result;
            //    }
            //    else
            //    {
            //        throw new Exception("notes are not updated");
            //    }
            //}
            //catch (Exception exception)
            //{
            //    throw exception;
            //}

            try
            {
                var result = await this._notesRepository.UpdateNotes(notesModel, id);

                ////key to store value in redis
                var cacheKey = "data" + notesModel.UserId;
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
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Deletes the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception">notes are not deleted</exception>
        public async Task<bool> DeleteNotes(NotesModel notesModel, int id)
        {
            try
            {
                //// if checks the notesModel contains details or not if it is null it throw the exception
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
    }
}
