using System;
using System.Collections.Generic;

namespace FlightUISample.Models
{
    public class Flight
    {
        public string From { get; set; }
        public string FromDate { get; set; }
        public string To { get; set; }
        public string ToDate { get; set; }
        public string Number { get; set; }
        public string ClassType { get; set; }
        public string Boarding { get; set; }
        public string Terminal { get; set; }
        public string Total { get; set; }
        public bool IsSplitPayment { get; set; }
        public List<Passenger> passenger { get; set; }
    }
}
