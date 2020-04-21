using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedDogAdmin.Models
{
    public class RedDogUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }
}
