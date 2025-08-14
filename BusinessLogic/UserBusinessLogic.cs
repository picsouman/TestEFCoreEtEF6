using InterfaceRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class UserBusinessLogic
    {
        private readonly IUserRepository userRepository;

        public UserBusinessLogic(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public string[] GetAllUserName()
        {
            return userRepository.GetAll()
                .Select(user => user.Name)
                .ToArray();
        }
    }
}
