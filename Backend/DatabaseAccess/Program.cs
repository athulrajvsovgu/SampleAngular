using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TrainingDatabase();

            foreach(var game in context.Games)
            {
                Console.WriteLine(game.Title);
                game.Title += "!";
                Console.WriteLine(game.Title);
            }

            context.SaveChanges();
            Console.WriteLine("Program Finished");
            Console.ReadLine();
        }
    }
}
