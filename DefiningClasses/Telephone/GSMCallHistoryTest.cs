
namespace Telephone
{
    public class GSMCallHistoryTest
    {
        static void Test()
        {
            List<Call> calls = new List<Call>();
            Call call = new Call("0", "23:20:43", "3:24", calls);
            Call call1 = new Call("21.7.2023", "15:36:43", "3:14", calls);
            var gsm1 = new GSM("kp", "fsd", "323$", "ALehandro", new Battery("ttt", 45, 43, Battery.Type.NiMH),
                new Screen("1090x780", "black"), new Call("20.7.2023", "15:26:43", "3:24:25", calls));
            call.PrintCall();
            call1.PrintCall();
            gsm1.AddCall(call, calls);
            gsm1.AddCall(call1, calls);
            gsm1.CalculateCallPrice(0.40M, calls);
            gsm1.RemoveCalls(calls);
            gsm1.CalculateCallPrice(0.40M, calls);

        }

        static void Main()
        {
            Test();
        }
    }
}
