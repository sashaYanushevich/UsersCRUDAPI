using System;
namespace UsersCRUDAPI.Models
{
	public class Role
	{
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public List<UserRole> UserRoles { get; set; }
    }
}

