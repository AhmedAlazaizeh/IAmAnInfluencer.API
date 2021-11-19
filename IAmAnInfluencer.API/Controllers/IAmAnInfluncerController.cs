using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmAnInfluencer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IAmAnInfluncerController : ControllerBase
    {
        private readonly IIAmAnInfluncerService iAmAnInfluncerService;
        public IAmAnInfluncerController(IIAmAnInfluncerService _iAmAnInfluncerService)
        {
            iAmAnInfluncerService = _iAmAnInfluncerService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer)
        {
            return iAmAnInfluncerService.addIAmAnInfluncer(iamAnInfluncer);
        }

        [HttpDelete]
        [Route("Delete/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteIAmAnInfluncer(int ID)
        {
            return iAmAnInfluncerService.deleteIAmAnInfluncer(ID);
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(List<IAmAnInfluncer>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<IAmAnInfluncer> getAllIAmAnInfluncer()
        {
            return iAmAnInfluncerService.getAllIAmAnInfluncer();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer)
        {
            return iAmAnInfluncerService.updateIAmAnInfluncer(iamAnInfluncer);
        }
    }
}
