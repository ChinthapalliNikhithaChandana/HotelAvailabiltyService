using HotelAvailabilityServiceDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAvailabilityServiceDocker.Repository
{
    public interface IAvailabilityRepository
    {
        public AvailableHotels GetById(int id);
        public IEnumerable<AvailableHotels> GetAll();
        public bool Reduce(int id);
        public AvailableHotels AddHotel(AvailableHotels hotel);
    }
}
