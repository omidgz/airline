using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.IteratorPattern();

            p.WriteLineToSeparate();
            p.StrategyPattern();

            p.WriteLineToSeparate();
            p.FactoryMethod();

            p.WriteLineToSeparate();
            p.GraspCreator();

            p.WriteLineToSeparate();
            p.GraspInformationExpert();

            p.WriteLineToSeparate();
            p.SingletonPattern();

            p.WriteLineToSeparate();
            p.ObserverPattern();

            p.WriteLineToSeparate();
            p.GRASPPolymorphismPattern();

            Console.ReadKey();
        }
        /// <summary>
        /// This function will call the example of Iterator Pattern
        /// </summary>
        private void IteratorPattern()
        {
            Console.WriteLine("Iterator Pattern");
            Console.WriteLine();

            AircraftManufacturer airBus = new AircraftManufacturer(1, "Airbus");
            AircraftModel airBusModel1 = new AircraftModel(1, "A12", airBus);
            AircraftModel airBusModel2 = new AircraftModel(2, "A13", airBus);
            AircraftModel airBusModel3 = new AircraftModel(3, "A14", airBus);
            Aircraft aircraft1 = new Aircraft(1, airBusModel1, "0014", 20, 10, 5);
            Aircraft aircraft2 = new Aircraft(2, airBusModel2, "0236", 20, 10, 6);

            AircraftManufacturer boeing = new AircraftManufacturer(1, "Airbus");
            AircraftModel boeingModel1 = new AircraftModel(1, "B12", boeing);
            AircraftModel boeingModel2 = new AircraftModel(2, "B22", boeing);
            Aircraft aircraft3 = new Aircraft(1, boeingModel1, "1120", 20, 10, 5);
            Aircraft aircraft4 = new Aircraft(2, boeingModel2, "4523", 20, 10, 6);

            AircraftCollection aircraftCollection = new AircraftCollection();
            aircraftCollection.Add(aircraft1);
            aircraftCollection.Add(aircraft2);
            aircraftCollection.Add(aircraft3);
            aircraftCollection.Add(aircraft4);

            foreach (Aircraft ac in aircraftCollection)
            {
                Console.WriteLine(nameof(ac.AircraftID) + " " + ac.AircraftID);
                Console.WriteLine(nameof(ac.AircraftModel.AircraftModelName) + " " + ac.AircraftModel.AircraftModelName);
                Console.WriteLine(nameof(ac.AircraftNumberSeatsBusiness) + " " + ac.AircraftNumberSeatsBusiness);
                Console.WriteLine(nameof(ac.AircraftNumberSeatsEconomy) + " " + ac.AircraftNumberSeatsEconomy);
                Console.WriteLine(nameof(ac.AircraftNumberSeatsPremiumEconomy) + " " + ac.AircraftNumberSeatsPremiumEconomy);
                Console.WriteLine(nameof(ac.AircraftSerialNumber) + " " + ac.AircraftSerialNumber);
            }

        }

        /// <summary>
        /// Write dotted line to separate the patterns.
        /// </summary>
        private void WriteLineToSeparate()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// This function will call the example of Strategy Pattern
        /// </summary>
        private void StrategyPattern()
        {
            Console.WriteLine("Strategy Pattern");
            Console.WriteLine();

            FlightList flightList = new FlightList();

            flightList.SetSearchStrategy(new SearchByDuration());
            flightList.SearchMethod();

            flightList.SetSearchStrategy(new SearchByTimeFrame());
            flightList.SearchMethod();
        }
        /// <summary>
        /// This function will call the example of Factory Method Pattern
        /// </summary>
        private void FactoryMethod()
        {
            Console.WriteLine("Factory Method Pattern");
            Console.WriteLine();

            PaymentFactory payment = new PaymentFactory();
            Console.WriteLine("Pay by Credit");
            Console.WriteLine(payment.ProcessPayment("Credit").GetType().Name);
            Console.WriteLine("Pay by PayPal");
            Console.WriteLine(payment.ProcessPayment("PayPal").GetType().Name);
        }

        /// <summary>
        /// This function will call the example of Creator Pattern
        /// </summary>
        private void GraspCreator()
        {
            Console.WriteLine("GRASP Creator Pattern");
            Console.WriteLine();

            Aircraft aircraft = new Aircraft(001, new AircraftModel(), "X001", 150, 40, 10);
            Flight flight = new Flight(aircraft);

            int countEconomy, countBusiness, countPremium;
            countEconomy = 0;
            countBusiness = 0;
            countPremium = 0;

            foreach (Seat s in flight.FlightSeats)
            {
                if (s.GetType() == typeof(EconomySeat))
                {
                    countEconomy++;
                }
                if (s.GetType() == typeof(BusinessSeat))
                {
                    countBusiness++;
                }
                if (s.GetType() == typeof(PremiumEconomySeat))
                {
                    countPremium++;
                }
            }


            Console.WriteLine("Number of Economy Seats created {0}", countEconomy);
            Console.WriteLine("Number of Business Seats created {0}", countBusiness);
            Console.WriteLine("Number of Premium Economy Seats created {0}", countPremium);
        }

        /// <summary>
        /// This function will call the example of Information Expert Pattern
        /// This also apply for Low Coupling because the Sale class does not need to
        /// know about the Seat Price, it gets this information from the Ticket class
        /// <seealso cref="Sale.getTotalPrice()"/>
        /// <seealso cref="Ticket.TicketPrice"/>
        /// <seealso cref="Seat.SeatPrice"/>
        /// </summary>
        private void GraspInformationExpert()
        {
            Console.WriteLine("GRASP Information Expert Pattern");
            Console.WriteLine();

            Sale s = new Sale();
            s.SaleTickets = new List<IObserverTicket>();

            Ticket t = new Ticket();
            t.TicketSeat = new BusinessSeat();
            t.TicketSeat.SeatPrice = 100;
            s.SaleTickets.Add(t);

            t = new Ticket();
            t.TicketSeat = new PremiumEconomySeat();
            t.TicketSeat.SeatPrice = 50;
            s.SaleTickets.Add(t);

            t = new Ticket();
            t.TicketSeat = new EconomySeat();
            t.TicketSeat.SeatPrice = 10;
            s.SaleTickets.Add(t);

            Console.WriteLine("Total Price paid for this Sale with 3 Tickets: $ {0}", s.SaleTotalPrice);
        }

        /// <summary>
        /// This function will call the example of Singleton Pattern
        /// </summary>
        private void SingletonPattern()
        {
            Console.WriteLine("Singleton Pattern");
            Console.WriteLine();

            LogWriter l1 = LogWriter.Instance();
            LogWriter l2 = LogWriter.Instance();

            Console.WriteLine("The number {0} from the first Instance must be equal to {1} the one from the second Instance", l1.SessionLogID, l2.SessionLogID);
        }
        /// <summary>
        /// This function is a empty which is used to explain the High Cohesion. We have
        /// AircraftCollection class which has method that only defines its properties.
        /// <see cref="AircraftCollection"/>
        /// </summary>
        private void HighCohesion()
        { }

        /// <summary>
        /// This function will call the example of Observer Pattern
        /// </summary>
        public void ObserverPattern() {
            Console.WriteLine("Observer Pattern");
            Console.WriteLine();

            Ticket t1 = new Ticket(1, new BusinessSeat(), "Passenger One");
            Ticket t2 = new Ticket(2, new BusinessSeat(), "Passenger Two");

            List<IObserverTicket> list = new List<IObserverTicket>();
            list.Add(t1);
            list.Add(t2);

            Sale sale = new Sale();
            sale.SaleTickets = list;

            Console.WriteLine("Sale state updated to 'Purchased'");
            sale.SaleState = "Purchased";
        }

        /// <summary>
        /// This function will call the example of GRASP Polymorphism Pattern
        /// </summary>
        public void GRASPPolymorphismPattern()
        {
            Console.WriteLine("GRASP Polymorphism Pattern");
            Console.WriteLine();

            Console.WriteLine("Creating an aircraft with 2 economy seats, 2 premium economy seats and 2 business seats.");
            Aircraft aircraft = new Aircraft(001, new AircraftModel(), "X001", 2, 2, 2);
            Console.WriteLine("Creating a flight with the aircraft informaton of number of seats for each seat type.");
            Flight flight = new Flight(aircraft);

            foreach(Seat seat in flight.FlightSeats)
            {
                seat.DisplayRefundPeriod();
            }
        }
    }
}
