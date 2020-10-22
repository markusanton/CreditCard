using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your personal code:");
            string idCode = Console.ReadLine();
            int idcodelenght = idCode.Length;

            if (Validate(idCode))
            {
                HelloUser(idCode);
                CardNumberValidation();
            }
            else
            {
                Console.WriteLine("wrong format.");
            }
        }
        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                    Console.WriteLine($"Wrong format = {e}");
                }
            }
            else
            {
                return false;
            }
        }
        public static void HelloUser(string idCode)
        {
            int firstnum = Int32.Parse(idCode[0].ToString());
            if (firstnum == 1 || firstnum == 3 || firstnum == 5)
            {
                Console.WriteLine("Hello, Sir!!");
            }
            else if (firstnum == 2 || firstnum == 4 || firstnum == 6)
            {
                Console.WriteLine("Hello, Madam!!");
            }

        }
        public static void CardNumberValidation()
        {
            Console.WriteLine("Enter your credit card number:");
            string CardNumber = Console.ReadLine();
            int CardNumberLength = CardNumber.Length;
            Console.WriteLine("Enter your CVV:");
            string CVVNumber = Console.ReadLine();
            int CVVNumberLength = CVVNumber.Length;
            
            if (CardNumberLength == 16 && CVVNumberLength == 3)
            {
                Console.WriteLine("Your card has been accepted.");
            }
            else
            {
                Console.WriteLine("Your card has been declined.");
            }
        }
    }
}