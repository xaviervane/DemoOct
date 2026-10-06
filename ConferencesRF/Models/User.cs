using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferencesRF.Models;

[Table("User")]
public partial class User
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Логин обязателен для заполнения")]
    [StringLength(32, MinimumLength = 6, ErrorMessage = "Логин быть больше 6 символов")]
    public string Login { get; set; } = null!;
    [Required(ErrorMessage = "Пароль обязателен для заполнения")]
    [StringLength(32, MinimumLength = 8, ErrorMessage = "Пароль быть больше 8 символов")]
    public string Password { get; set; } = null!;
    [Required(ErrorMessage = "Имя обязательно для заполнения")]
    [StringLength(20)]
    public string FirstName { get; set; } = null!;
    [Required(ErrorMessage = "Фамилия обязательна для заполнения")]
    [StringLength(20)]
    public string LastName { get; set; } = null!;
    [StringLength(20)]
    public string MiddleName { get; set; } = null!;
    [Required(ErrorMessage = "Телефон обязателен для заполнения")]
    [StringLength(20)]
    public string Phone { get; set; } = null!;
    [Required(ErrorMessage = "Почта обязательна для заполнения")]
    [StringLength(64)]
    public string Email { get; set; } = null!;

    public int RoleId { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role Role { get; set; } = null!;
}
