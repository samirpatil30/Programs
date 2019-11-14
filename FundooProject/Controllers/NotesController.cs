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
    using Microsoft.AspNetCore.Http;
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
        // [//Route("AddNotes")]

        public async Task<IActionResult> AddNotes(NotesModel notesModel)
        {
            var result = await _userNotes.AddNotes(notesModel);
            return Ok(new { result });
        }

        [HttpGet]
        [Route("Get/{userId}")]
        public IActionResult getNotes(string userId)
        {

            var result = _userNotes.GetNotes(userId);
            return Ok(new { result });
        }

        [HttpPut]
        // [Route("updateNotes")]
        public async Task<IActionResult> UpdateNotes(NotesModel notesModel, int id)
        {
            var result = await _userNotes.UpdateNotes(notesModel, id);
            return Ok(new { result });
        }

        [HttpDelete]
        //[Route("DeleteNotes")]
        public async Task<IActionResult> DeleteNotes(NotesModel notesModel, int id)
        {
            var result = await _userNotes.DeleteNotes(notesModel, id);
            var noteResult = "Note is Deleted";
            return Ok(new { result, noteResult });
        }

        [HttpPost]
        [Route("Image")]
        public IActionResult AddImage(string userId, int id, IFormFile file)
        {
            var urlOfImage = _userNotes.AddImage(userId, id, file);
            // return urlOfImage;
            return Ok(new { urlOfImage });
        }

        [HttpPost]
        [Route("Archive")]
        public Task<bool> Archive(int id)
        {
            return _userNotes.Archive(id);
        }

        [HttpPost]
        [Route("UnArchive")]

        public async Task<IActionResult> UnArchive(int id)
        {
            var result = await _userNotes.UnArchive(id);
            return Ok(new { result });
        }
    }
}