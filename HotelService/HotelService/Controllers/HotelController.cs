using HotelDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelService.Controllers
{
    public class HotelController : ApiController
    {
        public IEnumerable<hotel> GetHotel()
        {
            using (BookingProductsEntities entities = new BookingProductsEntities())
            {
                return entities.hotels.ToList();
            }
        }
           
    }
}
