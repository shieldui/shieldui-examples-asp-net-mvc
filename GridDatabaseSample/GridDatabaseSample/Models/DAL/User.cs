using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GridDatabaseSample.Models.DAL
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Index(IsUnique = true), Required, StringLength(256)]
        public string Email { get; set; }

        [Index, StringLength(256)]
        public string Name { get; set; }

        [Index, Required]
        public int Age { get; set; }
    }
}