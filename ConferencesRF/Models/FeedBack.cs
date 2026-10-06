using System;
using System.Collections.Generic;

namespace ConferencesRF.Models;

public partial class FeedBack
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public int BookingId { get; set; }

    public virtual Booking Booking { get; set; } = null!;
}
