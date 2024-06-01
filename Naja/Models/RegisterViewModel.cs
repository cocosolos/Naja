using System.ComponentModel.DataAnnotations;

public class RegisterModel
{
    [Required]
    [StringLength(15, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 15 characters long.")]
    public required string Username { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password confirmation is required.")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    [StringLength(32, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 32 characters long.")]
    public required string ConfirmPassword { get; set; }
}
