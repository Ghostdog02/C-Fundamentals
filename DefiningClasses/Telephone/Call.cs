
namespace Telephone
{
    public class Call
    {
        private string? date = default;
        private string? beggining = default;
        private string? duration = default;
        private List<Call> callHistory = new List<Call>();

        public string? Date { get => date; set => date = value; }

        public string? Beggining { get => beggining; set => beggining = value; }

        public string? Duration { get => duration; set => duration = value; }

        public List<Call> CallHistory { get => callHistory; set => callHistory = value; }

        public Call(string? date, string? begginig, string? duration, List<Call> callHistory)
        {
            this.Date = date;
            this.Beggining = begginig;
            this.Duration = duration;
            this.CallHistory = callHistory;
        }

        public void PrintCall()
        {
            Console.WriteLine($"StartDate:{Date} StartHour:{Beggining} Duration:{Duration}");
        }
    }
}
