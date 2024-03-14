using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogbackend.Models.DTO;
using blogbackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace blogbackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _data;

        public UserController(UserService data){
            _data = data;
        }

        // Login Endpoint 

        // AddUser Endpoint
            // if user already exists
            // if user does not exists, create new account
            // else return false

            public bool AddUser(CreateAccountDTO UserToAdd){
                return _data.AddUser(UserToAdd);
            }

        // UpdateUser Endpoint

        // DeleteUser Endpoint
    }
}