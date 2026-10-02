using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferencesRF.Models;

public partial class Booking
{
    public int Id { get; set; }
    [StringLength(40)]
    [Required(ErrorMessage ="Название конференции обязательно для заполнения")]
    public string ConferenceName { get; set; } = null!;

    public int BookingStatusId { get; set; }

    public int UserId { get; set; }

    [Required(ErrorMessage = "Помещение обязательно для заполнения")]
    public int RoomId { get; set; }

    [Required(ErrorMessage = "Способ оплаты обязателен для заполнения")]
    public int PaymentTypeId { get; set; }

    [Required(ErrorMessage = "Дата обязательна для заполнения")]
    public DateTime Date { get; set; }

    public virtual BookingStatus BookingStatus { get; set; } = null!;

    public virtual ICollection<FeedBack> FeedBacks { get; set; } = new List<FeedBack>();

    public virtual PaymentType PaymentType { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
