﻿using CommanLayer.Model;
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
        IList<NotesModel> GetNotes(NotesModel model);

        Task<bool> UpdateNotes(NotesModel model, int id);

        Task<bool> DeleteNotes(NotesModel notesModel, int id);
    }
}