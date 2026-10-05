using System;
using System.Collections.Generic;

namespace ConferencesRF.Models;

public partial class Booking
{
    public int Id { get; set; }

    public string ConferenceName { get; set; } = null!;

    public int BookingStatusId { get; set; }

    public int UserId { get; set; }

    public int RoomId { get; set; }

    public int PaymentTypeId { get; set; }

    public DateTime Date { get; set; }

    public virtual BookingStatus BookingStatus { get; set; } = null!;

    public virtual ICollection<FeedBack> FeedBacks { get; set; } = new List<FeedBack>();

    public virtual PaymentType PaymentType { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
