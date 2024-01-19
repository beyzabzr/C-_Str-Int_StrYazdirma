using System;
namespace int_String_DegerlerdeIntSilme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Kullanicidan String + Int deger alip iint degerleri silerek konsola yazdiran program***");
            Console.WriteLine("Lutfen string ve int deger girmek icin Enter'a basin (Cikmak icin 'exit' yazin):");

            InputHandler inputHandler = new InputHandler();
            ValueStorage valueStorage = new ValueStorage();

            while (true)
            {
                string strInput = inputHandler.GetInput("String Deger: ");
                if (strInput.ToLower() == "exit")
                {
                    break;
                }

                string intInput = inputHandler.GetInput("Tam Sayi Deger: ");
                if (intInput.ToLower() == "exit")
                {
                    break;
                }
                valueStorage.AddValues(strInput, intInput);
            }

            Console.WriteLine("\n Girilen string degerler: ");
            valueStorage.DisplayStringValues();
        }
    }
}