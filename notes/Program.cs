using System;

namespace Notes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            setup();
            run(args);

            Console.WriteLine("Program Ended...");
            Console.ReadKey();
        }

        static void setup(){
            Console.Title = "Notes";
        }
        static void run(string[] args){
            new Menu().show();
        }
    }
}