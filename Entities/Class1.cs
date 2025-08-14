using System;

namespace Entities
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int IdGroup { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
