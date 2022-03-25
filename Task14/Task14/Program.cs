using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin");
            string numstr1 = Console.ReadLine();
            Console.WriteLine("ikinci ededi daxil edin");
            string numstr2 = Console.ReadLine();
            Console.WriteLine("Ucuncu ededi daxil edin");
            string numstr3 = Console.ReadLine();
            Console.WriteLine("Dosrduncu ededi daxil edin");
            string numstr4 = Console.ReadLine();
            Console.WriteLine("Besinci ededi daxil edin");
            string numstr5 = Console.ReadLine();
            Console.WriteLine("Altinci ededi daxil edin");
            string numstr6 = Console.ReadLine();
            if (numstr1.Length+1>=6 && numstr2.Length+1>=6 && numstr3.Length + 1 >= 6 && numstr4.Length + 1 >= 6 && numstr5.Length + 1 >= 6 && numstr6.Length + 1 >= 6)
            {
                //Parsing numbers
                int numint1 = int.Parse(numstr1);
                int numint2 = int.Parse(numstr2);
                int numint3 = int.Parse(numstr3);
                int numint4 = int.Parse(numstr4);
                int numint5 = int.Parse(numstr5);
                int numint6 = int.Parse(numstr6);
                // Sum method 
                int sum1 = numint1 + numint2 + numint3 + numint4 + numint5 + numint6;
                //Paste
                string numpst1 = numint1.ToString();
                string numpst2 = numint3.ToString();
                string numpst3 = numpst1 + numpst2;
                long numlaint = long.Parse(numpst3);
                //Diffirance
                long diff1 = sum1 - numlaint;
                //Persentage
                double perc1 = diff1 * 0.1;
                //Sum
                double resultsum = perc1 + numint5 + numint6;
                Console.WriteLine("--------");
                Console.WriteLine("Netice :");
                Console.WriteLine(resultsum * 0.11);
            }
            else
            {
                Console.WriteLine("Xais olunur serte uygun eded daxil edin");
            }
        }
    }
}
