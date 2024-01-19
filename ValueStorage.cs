using System;
namespace int_String_DegerlerdeIntSilme
{
    class ValueStorage
    {
        private List<string> stringList;

        public ValueStorage()
        {
            stringList = new List<string>();
        }

        public void AddValues(string strInput, string intInput)
        {
            stringList.Add(strInput);
        }

        public void DisplayStringValues()
        {
            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
        }
    }
}