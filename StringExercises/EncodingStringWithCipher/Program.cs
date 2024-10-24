using System;

namespace EncodingStringWithCipher
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine($"Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Enter cipher: ");
            string cipher = Console.ReadLine();
            var index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                //index = index > cipher.Length - 1 ? 0 : index;

                ushort number = Convert.ToUInt16(text[i] ^ cipher[index % cipher.Length]);
                Console.Write("\\u{0:x4}", number);
                index++;
            }
        }
    }
}
