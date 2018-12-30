﻿using System.ComponentModel.DataAnnotations;
using MediatR;
using Toss.Shared.Account;

namespace Toss.Shared
{
    public class EditAccountCommand : IRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Name { get; set; }
    }
}