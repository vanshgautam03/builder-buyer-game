
namespace program_execution;
class Program
{
    static  void Main(string[] args)
    {
        try{
            Console.WriteLine("Welcome");
            Console.WriteLine("");
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write($"Hello {name}!");
            Console.Write(" Wanna play the game 'Self-Made Builder Buyer'?(yes/no):");
            string answer = Console.ReadLine();
            if (answer == "YES" || answer == "Yes" || answer == "yes")
            {
                Console.WriteLine("Great! Let's start!");

                Game game = new Game();
                game.start();
            }
            else if (answer == "NO" || answer == "No" || answer == "no")
            {
                Console.WriteLine("OK Sure, We'll meet some other day!");
            }
            else
            {
                Console.WriteLine("Sorry, I didn't get that!");
            }
        }
        catch(Exception){
            Console.WriteLine("Invaid value  entered! write only in characters don't use the digits something");
        }
    }
}
