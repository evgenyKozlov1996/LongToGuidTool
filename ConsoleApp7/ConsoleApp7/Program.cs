using System;

namespace ConsoleApp7
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your int value!");
            long value;
            long.TryParse(Console.ReadLine(), out value);

            if (value != 0)
            {
                Console.WriteLine("Your GUID is:");
                Console.WriteLine(value.ToGuid());
            }

            Console.ReadLine();
        }

        public static Guid ToGuid(this long value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }
    }
}
