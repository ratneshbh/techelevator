using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {

        public int? Id { get; set; }

        [Required(ErrorMessage ="The field 'HotelId' is required")]
        public int HotelId { get; set; }

        [Required(ErrorMessage = "The field 'FullName' is required")]
        public string FullName { get; set; }
        
        [Required(ErrorMessage = "The field 'Check in date' is required")]
        public string CheckinDate { get; set; }

        [Required(ErrorMessage = "The field 'Check out date' is required")]
        public string CheckoutDate { get; set; }
        
        [Range(1, 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Guests { get; set; }

        public Reservation()
        {
            //must have parameterless constructor to deserialize
        }

        public Reservation(int? id, int hotelId, string fullName, string checkinDate, string checkoutDate, int guests)
        {
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelId = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Guests = guests;
        }
    }
}
