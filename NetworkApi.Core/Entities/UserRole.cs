using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetworkApi.Core.Entities.Common;

namespace NetworkApi.Core.Entities
{
    public class UserRole : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}