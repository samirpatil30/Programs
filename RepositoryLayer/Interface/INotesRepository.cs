using CommanLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface INotesRepository
    {
        Task<bool> AddNotes(NotesModel notesModel);
        IList<NotesModel> GetNotes(string UserId);

        Task<bool> UpdateNotes(NotesModel model, int id);

        Task<bool> DeleteNotes(NotesModel notesModel, int id);
        string AddImage(string url, string userid, int id, IFormFile file);

        Task<bool> Archive(int id);

        Task<bool> UnArchive(int id);
    }
}
