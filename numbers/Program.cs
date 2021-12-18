using System;
public class numbers
{
    public static void Main(string[] args)
    {
        int a, b, check, prime;

        Console.WriteLine("Prime numbers program. ");
        Console.Write("Enter the number: ");
        a = Convert.ToInt32(Console.ReadLine());

        for (check = 2; check <= a; check++)
        {
            prime = 1;
            for (b = 2; b < check; b++)
            {
                if (check % b == 0)
                {
                    prime = 0;
                }

            }
            if (prime == 0)
            {

            }
            else
            {
                Console.WriteLine(check);
            }
        }
    }
}