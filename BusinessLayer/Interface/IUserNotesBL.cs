using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
   public interface IUserNotesBL
    {
         Task<bool> AddNotes(NotesModel model);

        IList<NotesModel> GetNotes(NotesModel model);
       Task<bool> UpdateNotes(NotesModel model,int id);

        Task<bool> DeleteNotes(NotesModel notesModel, int id);
    }
}
