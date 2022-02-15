using System.ComponentModel.DataAnnotations;

namespace example_dotnet_identity.Models;
public class LoginModel
{
    [Required(ErrorMessage = "User Name é obrigatório!")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Password é obrigatório!")]
    public string? Password { get; set; }
}
