﻿using System;
namespace UsersCRUDAPI.Models
{
	public class User
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;
        public List<UserRole> UserRoles { get; set; }
    }
}

