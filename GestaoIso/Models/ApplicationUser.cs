using Microsoft.AspNetCore.Identity;

namespace GestaoIso.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

    }
}
