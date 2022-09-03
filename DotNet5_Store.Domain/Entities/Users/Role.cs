using System.Collections.Generic;

namespace DotNet5_Store.Domain.Entities.Users
{
    public class Role
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserInRoll> UserInRoll { get; set; }
    }
}