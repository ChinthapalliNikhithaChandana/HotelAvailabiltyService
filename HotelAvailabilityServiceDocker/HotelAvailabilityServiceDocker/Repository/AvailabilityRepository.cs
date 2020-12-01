using HotelAvailabilityServiceDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAvailabilityServiceDocker.Repository
{
    public class AvailabilityRepository : IAvailabilityRepository
    {
        List<AvailableHotels> availableHotels = new List<AvailableHotels>()
        {
        new AvailableHotels() {Id=1,Name="novotel",AvailableRooms=20, CostPerDay=200 },
        new AvailableHotels() {Id=2,Name="park",AvailableRooms=30, CostPerDay=300 },
        new AvailableHotels() {Id=3,Name="dolphin",AvailableRooms=10, CostPerDay=2000 },
        new AvailableHotels() {Id=4,Name="lemontree",AvailableRooms=40, CostPerDay=4000 }
        };



        public AvailableHotels AddHotel(AvailableHotels hotel)
        {
            availableHotels.Add(hotel);
            return hotel;
        }

        public IEnumerable<AvailableHotels> GetAll()
        {
            return availableHotels;
        }

        public AvailableHotels GetById(int id)
        {
            var hotel = availableHotels.Find(x => x.Id == id);
            return hotel;
        }

        public bool Reduce(int id)
        {
            var hotel = availableHotels.Find(x => x.Id == id);
            if (hotel == null || hotel.AvailableRooms == 0)
                return false;
            hotel.AvailableRooms = hotel.AvailableRooms - 1;
            availableHotels.Insert(id, hotel);
            return true;

        }
    }
}
