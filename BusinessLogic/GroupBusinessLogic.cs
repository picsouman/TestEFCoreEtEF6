using Entities;
using InterfaceRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class GroupBusinessLogic
    {
        private readonly IGroupRepository groupRepository;
        private readonly IUserRepository userRepository;

        public GroupBusinessLogic(IGroupRepository groupRepository, IUserRepository userRepository)
        {
            this.groupRepository = groupRepository;
            this.userRepository = userRepository;
        }

        public string[] GetAllGroupName()
        {
            return groupRepository.GetAll()
                .Select(group => group.Name)
                .ToArray();
        }

        public List<Group> GetAll()
        {
            return groupRepository
                .GetAll()
                .ToList();
        }

        public int GetNumberOfUsersInGroup(int groupId)
        {
            return userRepository.GetAll()
                .Count(user => user.IdGroup == groupId);
        }
    }
}
