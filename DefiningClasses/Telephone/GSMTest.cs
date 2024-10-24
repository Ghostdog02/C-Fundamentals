
namespace Telephone
{
    public class GSMTest
    {
        static void Test()
        {
            var gsm1 = new GSM("kp", "fsd", "323$", "ALehandro", new Battery("ttt", 45, 43, Battery.Type.NiMH),
                new Screen("1090x780", "black"));
            gsm1.PrintGSMInfo();
            GSM.NokiaN95.PrintGSMInfo();
        }
                
    }
}
