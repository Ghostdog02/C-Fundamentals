using SetImplementation;

namespace ReturnNumberOfArrivedAndDepartedBusses
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var schedule = new HashSet<TimeInterval>
            //{
            //    new TimeInterval(08, 24, 08, 33),
            //    new TimeInterval(08, 20, 09, 00),
            //    new TimeInterval(08, 32, 08, 37),
            //    new TimeInterval(09, 00, 09, 15)
            //};

            //var interval = new TimeInterval(08, 22, 09, 05);
            var schedule = new HashSet<TimeInterval>
            {
                  new TimeInterval(new DateTime(1999, 1, 1, 8, 24, 0), new DateTime(1999, 1, 1, 8, 33, 0)),
                  new TimeInterval(new DateTime(1999, 1, 1, 8, 20, 0), new DateTime(1999, 1, 1, 9, 0, 0)),
                  new TimeInterval(new DateTime(1999, 1, 1, 8, 32, 0), new DateTime(1999, 1, 1, 8, 37, 0)),
                  new TimeInterval(new DateTime(1999, 1, 1, 9, 0, 0), new DateTime(1999,  1, 1, 9, 15, 0)),

            };

            var interval = new TimeInterval(new DateTime(1999, 1, 1, 8, 22, 0), new DateTime(1999, 1, 1, 9, 5, 0));
            Console.WriteLine(GetBussesCount(interval, schedule));

        }

        static int GetBussesCount(TimeInterval interval, HashSet<TimeInterval> schedule)
        {
            int count = 0;
            //var setOfArrival = new HashSet<TimeInterval>();
            //var setOfDeparture = new HashSet<TimeInterval>();
            foreach (var bus in schedule)
            {
                if ((bus.Arrival >= interval.Arrival) && (bus.Departure <= interval.Departure))
                {
                    count++;
                }
            }

            return count;
        }
    }
}