using System;
using System.Collections.Generic;

namespace AcecraftPinkDB.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Useremail { get; set; }
        public string? Password { get; set; }
        public string? Confpassword { get; set; }
        public string? Pname { get; set; }
        public string? Adno { get; set; }
    }
}
