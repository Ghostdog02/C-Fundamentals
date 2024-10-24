
namespace Telephone
{
    public class GSM
    {
        private string? model = null;
        private string? manufacturer = null;
        private string? price = null;
        private string? owner = null;
        private Battery? battery = null;
        private Screen? screen = null;
        private static GSM nokiaN95 = new GSM("Nokia N95", "HMD Global Oy", "730$", "Alehandro", new Battery("Veliki", 6, 8),
            new Screen("1080x908", "black"));
        private Call? call = null;

        public string? Model { get => model; set => model = value; }

        public string? Manufacturer { get => manufacturer; set => manufacturer = value; }

        public string? Price { get => price; set => price = value; }

        public string? Owner { get => owner; set => owner = value; }

        public Battery? Battery { get => battery; set => battery = value; }

        public Screen? Screen { get => screen; set => screen = value; }

        public static GSM NokiaN95 { get => nokiaN95; }

        public Call? Call { get => call; set => call = value; }

        public GSM(string? model)
            : this(model, null)
        {

        }

        public GSM(string? model, string? manufacturer)
            : this(model, manufacturer, null)
        {

        }

        public GSM(string? model, string? manufacturer, string? price)
            : this(model, manufacturer, price, null)
        {

        }

        public GSM(string? model, string? manufacturer, string? price, string? owner)
    : this(model, manufacturer, price, owner, null)
        {

        }

        public GSM(string? model, string? manufacturer, string? price, string? owner, Battery? battery)
            : this(model, manufacturer, price, owner, battery, null)
        {

        }

        public GSM(string? model, string? manufacturer, string? price, string? owner, Battery? battery, Screen? screen)
            : this(model, manufacturer, price, owner, battery, screen, null)
        {

        }

        public GSM(string? model, string? manufacturer, string? price, string? owner, Battery? battery, Screen? screen, Call? call)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Screen = screen;
            this.Call = call;
        }

        public void PrintGSMInfo()
        {
            Console.WriteLine($"The model of the GSM is {Model}, manifactured by {Manufacturer}," +
                $" the price of the GSM is {Price} and it is owned by {Owner}");
            Console.WriteLine($"It has {Battery.HoursTalk} battery hours talk, it is of type {Battery.BatteryType}," +
                $" {Battery.IdleTime}");
            Console.WriteLine($"{Screen.Size} {Screen.Color}");
        }

        public void PrintGSMInfo(GSM nokia95N)
        {
            Console.WriteLine($"The model of the GSM is {nokia95N.Model}, manifactured by {nokia95N.Manufacturer}," +
                $" the price of the GSM is {Price} and it is owned by {nokia95N.Owner}");
            Console.WriteLine($"It has {nokia95N.Battery.HoursTalk} battery hours talk, it is of type {nokia95N.Battery.BatteryType}," +
                $" {nokia95N.Battery.IdleTime}");
            Console.WriteLine($"{Screen.Size} {Screen.Color}");
        }

        public void AddCall(Call call, List<Call> callHistory)
        {
            callHistory.Add(call);
        }

        public void RemoveCall(Call call, List<Call> callHistory)
        {
            callHistory.Remove(call);
        }

        public void RemoveCalls(List<Call> callHistory)
        {
            callHistory.Clear();
        }

        public void CalculateCallPrice(decimal price, List<Call> callHistory)
        {
            decimal callsCount = callHistory.Count;
            Console.WriteLine(callsCount * price);
        }
    }
}