// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesController.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooProject.Controllers
{
    using System.Threading.Tasks;
    using BusinessLayer.Interface;
    using CommanLayer.Model;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;


    [Route("api/[controller]")]
    [ApiController]
    // Authorize attribute to the controller class, then any action methods on the controller will be only available to authenticated users. 
    [Authorize]
    public class NotesController : ControllerBase
    {
        private readonly IUserNotesBL _userNotes;

        public NotesController(IUserNotesBL userNotes)
        {
            _userNotes = userNotes;
        }

     
        [HttpPost]
        [Route("AddNotes")]

        public async Task<IActionResult> AddNotes(NotesModel notesModel)
        {
            var result = await _userNotes.AddNotes(notesModel);
            return Ok(new { result });
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
        public async Task<IActionResult> UpdateNotes(NotesModel notesModel,int id)
        {
            var result = await _userNotes.UpdateNotes(notesModel, id);
            return Ok(new { result });
        }

        [HttpDelete]
        [Route("DeleteNotes")]
        public async Task<IActionResult> DeleteNotes(NotesModel notesModel,int id)
        {
            var result = await _userNotes.DeleteNotes(notesModel, id);
            var noteResult = "Note is Deleted";
            return Ok(new { result, noteResult });
        }
    }
}