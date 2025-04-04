using BookingApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BookingApp.Business.Operations.Hotel.Dtos
{
    public class AddHotelDto
    {
        public string Name { get; set; }
        public int? Stars { get; set; }
        public string Location { get; set; }
        public AccomodationType AccomodationType { get; set; }
        public List<int> FeatureIds { get; set; }
    }
}