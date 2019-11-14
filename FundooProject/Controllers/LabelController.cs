// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelController.cs" company="Bridgelabz">
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
   // [ApiController]
    [Authorize]
    public class LabelController : ControllerBase
    {
        private readonly ILabelBussinessManager _bussinessManager;

        public LabelController(ILabelBussinessManager bussinessManager)
        {
            _bussinessManager = bussinessManager;
        }

        [HttpPost]
       // [Route("Addlabel")]

        public async Task<IActionResult> AddLabel(LabelModel labelModel)
        {
            var result = await _bussinessManager.AddLabel(labelModel);
            return Ok(new { result });
        }

        [HttpPut]
       // [Route("UpdateLabel")]

        public async Task<IActionResult> UpdateLabel(LabelModel labelModel, string labelName)
        {
            var result = await _bussinessManager.UpdateLabel(labelModel, labelName);
            return Ok(new { result });
            
        }

        [HttpGet]
      //  [Route("getLabel")]

        public IActionResult GetLabel(string userId)
        {
            var result = _bussinessManager.GetLabel(userId);
            return Ok(new { result });
        }

        [HttpDelete]
       // [Route("DeleteLabel")]

        public async Task<IActionResult> DeleteLabel(LabelModel labelModel, int id)
        {
            var result = await _bussinessManager.DeleteLabel(labelModel, id);
            return Ok(new { result });
        }
    }
}