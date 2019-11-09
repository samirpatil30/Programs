﻿using System;
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
    public class LabelController : ControllerBase
    {
        private readonly ILabelBussinessManager _bussinessManager;

        public LabelController(ILabelBussinessManager bussinessManager)
        {
            _bussinessManager = bussinessManager;
        }

        [HttpPost]
        [Route("Addlabel")]

        public async Task<bool> AddLabel(LabelModel labelModel)
        {
            return await _bussinessManager.AddLabel(labelModel);
        }

        [HttpPost]
        [Route("UpdateLabel")]

        public async Task<bool> UpdateLabel(LabelModel labelModel, string labelName)
        {
            return await _bussinessManager.UpdateLabel(labelModel, labelName);
        }

        [HttpGet]
        [Route("getLabel")]

        public IActionResult GetLabel(string userId)
        {
            var result = _bussinessManager.GetLabel(userId);
            return Ok(new { result });
        }

        [HttpDelete]
        [Route("DeleteLabel")]

        public async Task<bool> DeleteLabel(LabelModel labelModel, int id)
        {
            return await _bussinessManager.DeleteLabel(labelModel, id);
        }
    }
}