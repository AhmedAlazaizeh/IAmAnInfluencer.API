using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addUser(User user)
        {
            return userService.addUser(user);
        }

        [HttpDelete]
        [Route("Delete/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteUser(int ID)
        {
            return userService.deleteUser(ID);
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<User> getAllUser()
        {
            return userService.getAllUser();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateUser(User user)
        {
            return userService.updateUser(user);
        }

        [HttpGet]
        [Route("countOfCustomers")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfCustomers()
        {
            return userService.countOfCustomers();
        }

        [HttpGet]
        [Route("countOfEmployees")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfEmployees()
        {
            return userService.countOfEmployees();
        }

        [HttpGet]
        [Route("countOfInfluncers")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfInfluncers()
        {
            return userService.countOfInfluncers();
        }

        [HttpGet]
        [Route("customersList")]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<User> customersList()
        {
            return userService.customersList();
        }

        [HttpGet]
        [Route("employeeList")]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<User> employeeList()
        {
            return userService.employeeList();
        }

        [HttpGet]
        [Route("influncersList")]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<User> influncersList()
        {
            return userService.influncersList();
        }

        [HttpGet]
        [Route("getUser/{ID}")]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<User> getUser(int ID)
        {
            return userService.getUser(ID);
        }

        [HttpPost]
        [Route("getUserByUsername")]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<User> getUserByUsername(usernameDTO usernameDTO)
        {
            return userService.getUserByUsername(usernameDTO);
        }
    }
}
