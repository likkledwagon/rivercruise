using System;

namespace DataModels
{
    public class Crew
    {
        public int Id { get; set; }
        public int? NauticalCrew { get; set; }
        public int? HotelStaff { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
    }
}