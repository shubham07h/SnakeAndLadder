using System;

class SnakeLadder
{
    static void Main()
    {
        int position = 0; // uc 1
        int dice; // To store the value of dice
        int count = 0;
        Random r = new Random();

        while (position < 100) //uc4
        {
            dice = r.Next(1, 7);// uc 2
            Console.Write("You got {0} ", dice);
            position = position + dice;
            count++;
            if (position > 100)
            {
                Console.WriteLine("Sorry, You can't go beyond 100.");//uc5
                position = position - dice;
            }
            else
            {
                Console.WriteLine("You are at {0} now.", position);
            }

            if (position == 8)
            {
                Console.WriteLine("Wow, a ladder. Climb up.");
                position = position + dice; //uc3
            }
            else if (position == 11)
            {
                Console.WriteLine("Oops, a snake. Go down ");
                position = position - dice;//uc3
            }
            else if (position == 13)
            {
                Console.WriteLine("Wow, a ladder. Climb up.");
                position = position + dice;//uc3
            }
            else if (position == 25)
            {
                Console.WriteLine("Oops, a snake. Go down .");
                position = position - dice;//uc3
            }
            else if (position == 38)
            {
                Console.WriteLine("Oops, a snake. Go down .");
                position = position - dice;//uc3
            }
            else if (position == 40)
            {
                Console.WriteLine("Wow, a ladder. Climb up.");
                position = position + dice;//uc3
            }
            else if (position == 52)
            {
                Console.WriteLine("Oops, a snake. ");
                position = position - dice;//uc3
            }
            else if (position == 65)
            {
                Console.WriteLine("Oops, a snake. Go down");
                position = position - dice;//uc3
            }
            else if (position == 76)
            {
                Console.WriteLine("Wow, a ladder. Climb up.");
                position = position + dice;//uc3
            }
        }
        Console.WriteLine("Steps we need to reach at 100 is:" + count); //uc 6
    }
}