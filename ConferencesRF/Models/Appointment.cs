using System;
using System.Collections.Generic;

namespace ConferencesRF.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public DateTime DateOf { get; set; }

        public int PaymentTypeId { get; set; }

        public int AppointmentStatusId { get; set; }

        public int UserId { get; set; }

        public virtual AppointmentStatus AppointmentStatus { get; set; } = null!;

        public virtual PaymentType PaymentType { get; set; } = null!;

        public virtual Room Room { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
