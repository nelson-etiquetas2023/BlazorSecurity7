using System.ComponentModel.DataAnnotations;

namespace BlazorSecurity.Net7.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string NombreCuenta { get; set; } = string.Empty;
		public byte[] PassswordHash { get; set; } = null!;
		public byte[] PasswordSalt { get; set; } = null!;
		public string Token { get; set; } = string.Empty;
		public string Rol { get; set; } = string.Empty;
		public String Claim { get; set; } = string.Empty;
		public string NombreUsuario { get; set; } = string.Empty;
	}
}
