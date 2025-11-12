using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluffy_umbrella.Models
{
    public class User
    {
        public int Id { get; set; }  // ✅
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}