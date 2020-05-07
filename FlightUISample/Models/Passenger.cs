using System;
namespace FlightUISample.Models
{
    public class Passenger
    {
        public string Name        { get; set; }
        public string Email       { get; set; }
        public string Seat        { get; set; }
        public string Picture     { get; set; }
        public bool   IsConfirmed { get; set; }
    }
}
