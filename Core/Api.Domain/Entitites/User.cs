using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entitites
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string? RefreshEventArgs  { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

    }
}
