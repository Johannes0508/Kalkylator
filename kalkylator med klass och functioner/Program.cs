using System;
using System.Text;

namespace kalkylator_med_klass_och_functioner
{

    public class Calculator
    {
        
        public void text()
        {
            Console.WriteLine("välj en siffra mellan 1-4");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraktion");
            Console.WriteLine("3. multiplication");
            Console.WriteLine("4. division");
        }

        public void rules()
        {
            int a, b, c;
            int abc = Int32.Parse(Console.ReadLine());

            switch (abc)
            {
                //det här är den första kaset som räknar ut svaret (c) med addition
                case 1:
                    Console.WriteLine("skriv in A");
                    a = Convert.ToInt32(Console.ReadLine()); //lägger in svaret som man skriver in i variabeln a
                    Console.WriteLine("skriv in B");
                    b = Convert.ToInt32(Console.ReadLine()); //lägger in svaret som man skriver in i variabeln b
                    c = a + b; //räknar ut vad svaret a + b blir som sedan blir C
                    Console.WriteLine(c); //visar vad svaret c blir
                    break;

                //det här är den andra kaset som räknar ut svaret (c) med subtraktion
                case 2:
                    Console.WriteLine("skriv in A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("skriv in B");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine(c);

                    break;

                //det här är den tredje kaset som räknar ut svaret (c) med multiplication
                case 3:
                    Console.WriteLine("skriv in A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("skriv in B");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine(c);

                    break;
                //det här är den sista kaset som räknar ut svaret (c) med division
                case 4:
                    Console.WriteLine("skriv in A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("skriv in B");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine(c);

                    break;

            }
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            Calculator miniR = new Calculator(); 

            miniR.text(); 
            miniR.rules();

        }
    }

}
