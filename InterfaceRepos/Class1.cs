using Entities;
using System;
using System.Collections.Generic;

namespace InterfaceRepos
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }

    public interface  IGroupRepository
    {
        List<Group> GetAll();
    }
}
