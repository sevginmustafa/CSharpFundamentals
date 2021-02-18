using System;
using System.Linq;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PasswordValidator(input);
        }

        static void PasswordValidator(string password)
        {
            if (CharactersCount(password) || LetterAndDigitsCheck(password) || DigitsCounter(password))
            {
                if (CharactersCount(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (LetterAndDigitsCheck(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (DigitsCounter(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CharactersCount(string password)
        {

            if (password.Length >= 6 && password.Length <= 10)
            {
                return false;
            }

            return true;
        }

        static bool LetterAndDigitsCheck(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                int convert = password[i];
                if ((convert >= 0 && convert <= 47) || (convert >= 58 && convert <= 64) || (convert >= 91 && convert <= 96) || convert >= 123)
                {
                    return true;

                }
            }

            return false;
        }

        static bool DigitsCounter(string password)
        {
            int digitsCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                int convert = password[i];
                if (convert >= 48 && convert <= 57)
                {
                    digitsCounter++;
                }
            }
            if (digitsCounter < 2)
            {
                return true;
            }

            return false;
        }
    }
}
