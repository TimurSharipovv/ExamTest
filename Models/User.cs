using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamTest.Models
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("login")]
        public string? Login { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("surname")]
        public string? Surname { get; set; }
        [Column("role")]
        public string? Role { get; set; }
    }
}
