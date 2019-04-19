using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your int value!");
            int value;
            int.TryParse(Console.ReadLine(), out value);

            if(value != 0)
            {
                Console.WriteLine("Your GUID is:");
                Console.WriteLine(ToGuid(value));
            }

            Console.ReadLine();
        }

        public static Guid ToGuid(int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }
    }
}
