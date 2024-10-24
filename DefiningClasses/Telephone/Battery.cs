
namespace Telephone
{
    public class Battery
    {
        private string? model = null;
        private int idleTime = 0;
        private int hoursTalk = 0;
        private Type batteryType = 0;

        public string? Model { get => model; set => model = value; }

        public int IdleTime { get => idleTime; set => idleTime = value; }

        public int HoursTalk { get => hoursTalk; set => hoursTalk = value; }

        public Type BatteryType { get => batteryType; set => batteryType = value; }

        public Battery(string? model)
           : this(model, 0)
        {

        }

        public Battery(string? model, int idleTime)
    : this(model, idleTime, 0)
        {

        }

        public Battery(string? model, int idleTime, int hoursTalk)
    : this(model, idleTime, hoursTalk, 0)
        {

        }

        public Battery(string? model, int idleTime, int hoursTalk, Type batteryType)
        {
            this.Model = model;
            this.IdleTime = idleTime;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public enum Type
        {
            NiCd,
            NiMH,
            LiIon,
            LiPo
        }
    }
}
