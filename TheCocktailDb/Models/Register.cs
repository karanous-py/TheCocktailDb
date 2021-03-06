﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCocktailDb.Models
{
    public class Register
    {
        public int UserId { get; set; }

        public string FellName { get; set; }

        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "format email vard shode sahih nist gole mn")]
        public string Email { get; set; }

        public List<string> favorites { get; set; }
    }
}
