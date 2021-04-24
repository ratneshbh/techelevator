using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao _hotelDao;
        private static IReservationDao _reservationDao;

        public HotelsController()
        {
            _hotelDao = new HotelDao();
            _reservationDao = new ReservationDao();
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return _hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public Hotel GetHotel(int id)
        {
            Hotel hotel = _hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }

            return null;
        }

        [HttpGet("reservations")]
        public List<Reservation> ListReservations()
        {
            return _reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        public Reservation GetReservation(int id)
        {
            return _reservationDao.Get(id);
        }

        //hotels/1/reservation
        [HttpGet("hotels/{id}/reservation")]//update route
        public List<Reservation> GetReservationsByHotel(int id)
        {
            List<Reservation> reservations = _reservationDao.FindByHotel(id);
            if (reservations.Count > 0)
            {
                return _reservationDao.FindByHotel(id);
            }
            else
            {
                return null;
            }
        }

        [HttpGet("reservation/{id}/hotels")]//update route
        public List<Reservation> GetReservationsByHotelV2(int id)
        {
            List<Reservation> reservations = _reservationDao.FindByHotel(id);
            if (reservations.Count > 0)
            {
                return _reservationDao.FindByHotel(id);
            }
            else
            {
                return null;
            }
        }

        [HttpPost("reservation")]
        public Reservation AddReservation(Reservation reservation)
        {
            return _reservationDao.Create(reservation);
        }

        [HttpGet("hotels/filter")]
        public List<Hotel> FilterHotels(int stars, int price)
        {
            stars = stars;
            price = price;
            return null;

        }
    }
}
