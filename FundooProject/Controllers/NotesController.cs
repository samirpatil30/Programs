using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommanLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly IUserNotesBL _userNotes;

        public NotesController(IUserNotesBL userNotes)
        {
            _userNotes = userNotes;
        }

        [HttpPost]
        [Route("AddNotes")]

        public async Task<bool> AddNotes(NotesModel notesModel)
        {
            return await _userNotes.AddNotes(notesModel);
        }

        [HttpPost]
        [Route("getNotes")]
        public IActionResult getNotes(NotesModel model)
        {

            var result =  _userNotes.GetNotes(model);
            return Ok(new { result });
        }

        [HttpPost]
        [Route("updateNotes")]
        public async Task<bool> UpdateNotes(NotesModel notesModel,int id)
        {
            var result = await _userNotes.UpdateNotes(notesModel, id);
            return result;
        }

        [HttpDelete]
        [Route("DeleteNotes")]
        public async Task<bool> DeleteNotes(NotesModel notesModel,int id)
        {
            return await _userNotes.DeleteNotes(notesModel, id);
        }
    }
}