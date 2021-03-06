﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10,MinimumLength =3, ErrorMessage ="You must specify password between 3 to 10 characters.")]
        public string Password { get; set; }
    }
}
