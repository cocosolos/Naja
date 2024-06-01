using System.ComponentModel.DataAnnotations;

public class LoginViewModel
{
    [Required]
    public required string Login { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    public bool RememberMe { get; set; }
}
