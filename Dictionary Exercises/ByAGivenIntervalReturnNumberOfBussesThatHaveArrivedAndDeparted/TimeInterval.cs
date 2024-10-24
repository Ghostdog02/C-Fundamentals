using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnNumberOfArrivedAndDepartedBusses
{
    public class TimeInterval
    {
        //public int ArriveMinute { get; }

        //public int ArriveHour { get; }

        //public int DepartureMinute { get; }

        //public int DepartureHour { get; }

        public DateTime Arrival { get; }

        public DateTime Departure { get; }

        //public TimeInterval(int arriveHour, int arriveMinute, int departureHour, int departureMinute)
        //{
        //    ArriveMinute = arriveMinute;
        //    ValidateArriveMinute();
        //    ArriveHour = arriveHour;
        //    ValidateArriveHour();
        //    DepartureMinute = departureMinute;
        //    ValidateDepartureMinute();
        //    DepartureHour = departureHour;
        //    ValidateDepartureHour();
        //}

        public TimeInterval(DateTime arrival, DateTime departure)
        {
            Arrival = arrival;
            Departure = departure;
        }

        //public override string ToString()
        //{
        //    return $"{ArriveMinute:00} : {ArriveHour:00} - {DepartureMinute:00} : {DepartureHour:00}";
        //}

        //public void ValidateArriveMinute()
        //{
        //    if (ArriveMinute < 0 && ArriveMinute > 60)
        //    {
        //        throw new ArgumentOutOfRangeException($"Invalid arrive minutes: {ArriveMinute}");
        //    }
        //}

        //public void ValidateDepartureMinute()
        //{
        //    if (DepartureMinute < 0 && DepartureMinute > 60)
        //    {
        //        throw new ArgumentOutOfRangeException($"Invalid departure minutes: {DepartureMinute}");
        //    }
        //}

        //public void ValidateArriveHour()
        //{
        //    if (ArriveHour < 0 && ArriveMinute > 24)
        //    {
        //        throw new ArgumentOutOfRangeException($"Invalid arrive hours: {ArriveHour}");
        //    }
        //}

        //public void ValidateDepartureHour()
        //{
        //    if (ArriveHour < 0 && ArriveMinute > 24)
        //    {
        //        throw new ArgumentOutOfRangeException($"Invalid departure hours: {DepartureHour}");
        //    }
        //}
    }
}
