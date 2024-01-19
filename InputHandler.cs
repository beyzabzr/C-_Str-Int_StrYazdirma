using System;
namespace int_String_DegerlerdeIntSilme
{
    class InputHandler
    {
        public string GetInput(string message)
        {
            //          string input = Console.ReadLine();
            //            string[] inputs = input.Split(' ');

            Console.Write(message);
            return Console.ReadLine();


        }
    }
}