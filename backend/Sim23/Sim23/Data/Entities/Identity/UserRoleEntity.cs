using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sim23.Data.Entities.Identity
{
    public class UserRoleEntity : IdentityUserRole<int>
    {
        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        [ForeignKey("Role")]
        public virtual int RoleId { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual RoleEntity Role { get; set; }
    }
}
