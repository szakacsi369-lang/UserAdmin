using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Text;

namespace UserAdmin.Models
{
    internal class User
    {
        public string? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; } = string .Empty;
        public DateTime RegisteredAt { get; set; }
    }
}
