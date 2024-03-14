using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogbackend.Models;
using blogbackend.Models.DTO;
using blogbackend.Services.Context;

namespace blogbackend.Services
{
    public class UserService 
    {
        private readonly DataContext _context;

        public UserService(DataContext context){
            _context = context;
        }

        public bool DoesUserExist(string Username){
            // check if username exist
            // if 1 item matches then return the item
            // if no item matches, then return null

            return _context.UserInfo.SingleOrDefault(user => user.Username == Username) != null;
        }

        public bool AddUser(CreateAccountDTO UserToAdd){
            bool result = false;

            // if user doesnt exist, add user 
            if(!DoesUserExist(UserToAdd.Username)){
                UserModel newUser = new UserModel();
                result = true;
            }

            return result;
        }
    }
}