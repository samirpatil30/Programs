using BusinessLayer.Interface;
using CommanLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserNotesBL : IUserNotesBL
    {
        private readonly INotesRepository _notesRepository;
        public UserNotesBL(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }
        public Task<bool> AddNotes(NotesModel model)
        {
            try
            {
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

   
        public  IList<NotesModel> GetNotes(NotesModel model)
        {
            try
            {
                if(model != null)
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

        public async Task<bool> UpdateNotes(NotesModel notesModel, int id)
        {
            try
            {
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

        public async Task<bool> DeleteNotes(NotesModel notesModel, int id)
        {
            try
            {
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
