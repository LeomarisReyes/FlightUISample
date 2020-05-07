using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FlightUISample.Models;

namespace FlightUISample.ViewModels
{
    public class FlightViewModel
    {
        public ObservableCollection<Flight> flight { get; set; }

        public FlightViewModel()
        {
            flight = new ObservableCollection<Flight>()
            {
                new Flight
                {
                    From            ="MAC",
                    To              ="SDQ",
                    FromDate        ="24 May, 12:30",
                    ToDate          ="20:30",
                    Number          ="AR 712",
                    ClassType       ="First",
                    Boarding        ="21:35",
                    Terminal        ="B",
                    Total           ="$1,536",
                    IsSplitPayment  =true,
                    passenger      = new List<Passenger>
                    {
                        new Passenger
                        {
                            Name = "Leo R.",
                            Email = "leoreyes@hotmail.com",
                            Seat="17-C",
                            Picture="LeoR",
                            IsConfirmed = false
                        },
                        new Passenger
                        {
                            Name = "Victor R.",
                            Email = "victorr@hotmail.com",
                            Seat="16-A",
                            Picture="VictorR",
                            IsConfirmed = true
                        }
                    }
                },
                 new Flight
                {
                    From            ="LAS",
                    To              ="NYC",
                    FromDate        ="26 May, 10:30",
                    ToDate          ="14:30",
                    Number          ="AR 352",
                    ClassType       ="Economic",
                    Boarding        ="21:35",
                    Terminal        ="B",
                    Total           ="$1,096",
                    IsSplitPayment  =false,
                    passenger       = new List<Passenger>
                    {
                        new Passenger
                        {
                            Name = "Jessie L.",
                            Email = "jessie@hotmail.com",
                            Seat="17-B",
                            Picture="JessieL",
                            IsConfirmed = true
                        }
                    }
                }
            };
        }
    }
}
