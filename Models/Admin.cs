using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}