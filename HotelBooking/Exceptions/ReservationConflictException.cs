using HotelBooking.Models;
using System.Runtime.Serialization;

namespace HotelBooking.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncomingReservation { get; }

        public ReservationConflictException(Reservation existingReservation, Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string? message, Reservation existingReservation, Reservation incomingReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string? message, Reservation existingReservation, Reservation incomingReservation, Exception? innerException) : base(message, innerException)
        {
        }

        protected ReservationConflictException(SerializationInfo info, Reservation existingReservation, Reservation incomingReservation, StreamingContext context) : base(info, context)
        {
        }
    }
}
