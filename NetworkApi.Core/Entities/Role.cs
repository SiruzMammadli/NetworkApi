using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetworkApi.Core.Entities.Common;

namespace NetworkApi.Core.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}