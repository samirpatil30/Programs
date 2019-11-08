using CommanLayer.Model;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
   public class UserNotesRepository : INotesRepository
    {
        private readonly AuthenticationContext _authenticationContext;
        public UserNotesRepository(AuthenticationContext authenticationContext)
        {
            _authenticationContext = authenticationContext;
        }
        public async Task<bool> AddNotes(NotesModel notesModel)
        {
            var addNotes = new NotesModel()
            { 
                Id = notesModel.Id,
                UserId = notesModel.UserId,
                NotesTitle = notesModel.NotesTitle,
                NotesDescription = notesModel.NotesDescription,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                color = notesModel.color,
                NotesType = notesModel.NotesType
            };

            //// Add the details of user in db
            this._authenticationContext.Add(addNotes);

            //// save the the details in db and return a result
            var result =await _authenticationContext.SaveChangesAsync();
              
            if(result != null)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public IList<NotesModel> GetNotes(NotesModel model)
        {
            //// Here the Linq querey return the Record match in Database
            var list = from notes in _authenticationContext.notesModels.Where(g => g.UserId == model.UserId) select notes;
            return list.ToList();
        }

        public async Task<bool> UpdateNotes(NotesModel model,int id)
        {
            //// Here we retrive the id of user from db
            var query = from notes in _authenticationContext.notesModels
                        where notes.Id == id
                        select notes;

            ////if notes data have records then it will update the records
           foreach(var updateNote in query)
            {

                updateNote.NotesTitle = model.NotesTitle;
                updateNote.NotesDescription = model.NotesDescription;
                updateNote.color = model.color;
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

        public async Task<bool> DeleteNotes(NotesModel notesModel , int id)
        {
            var deleteOrderDetails =
                from details in _authenticationContext.notesModels
                where details.Id == id && details.UserId == notesModel.UserId
                select details;
            foreach(var deleteNote in deleteOrderDetails)
            {
                //// remove the record from database
                _authenticationContext.Remove(deleteNote);
            }

            ////save changes to the database
            var result = await this._authenticationContext.SaveChangesAsync();
                return true;                
           
        }
    } 
}
