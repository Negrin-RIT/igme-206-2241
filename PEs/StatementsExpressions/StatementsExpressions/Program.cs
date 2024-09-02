namespace StatementsExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* five stats
                Strength
                Dexterity
                Intelligence
                Health
                Charisma */


            // Print character name to the screeen
            Console.WriteLine("Character Name: Porthos");

            //Character starts with 50 points - no variables
            
            //First stat is 20% of 50 = 10
            Console.WriteLine("Strength: " + 50 * .20);

            //Second stat is half of first stat
            Console.WriteLine("Dexterity: " + (50 * .20)*.5);

            //Third stat is always 7
            Console.WriteLine("Intelligence: " + 7);

            //The fourth stat is the sum of second and third stats, minus 2 points.
            Console.WriteLine("Health: " + ((((50 * .20) * .5 + 7)) - 2));

            // All leftover points go to the fifth stat.
            Console.WriteLine("Fifth stat name:" +
                (50 -
                    ((50 * .20) +                       // First stat calc
                     ((50 * .20) * .5) +                // 2nd stat calc
                     (7) +                              // 3rd stat calc
                     (((((50 * .20) * .5 + 7)) - 2))             // 4th stat calc
                    )
                )
                );

        }
    }
}
