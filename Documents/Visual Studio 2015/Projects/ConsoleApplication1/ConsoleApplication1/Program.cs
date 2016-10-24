using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//facand proprietatile protected, ele devin inaccesibile in main
//facand si clasa protected, primim eroarea ca in namespace clasele nu pot fi declarate private, protected sau protected-internal
//facand clasa si proprietatile internal, programul ruleaza si afiseaza pe consola
namespace ConsoleApplication1
{
    public class Mercedes : AbstractCar {
        private string _Description;
        private int _Price;
        private int counter;
        public static int staticcounter;
        public Mercedes() {
            _Description ="E Class";
            _Price =67000;
        }
        public Mercedes(int n) { }

        public void PrintMercedesLogo() {

            Console.WriteLine("This is from Mercedes");
            counter++;
            if (counter == 3) { return; }
            PrintMercedesLogo();
        }

        public void PrintNewMercedes(int c) {
            if (c == 3) { return; }
            Console.WriteLine("Merces no=" + c);
        }

        public static void StartEngine() {
            Console.WriteLine("Engine started.");

        }
        internal int Price {
            get { return _Price; }
            set { _Price = value; }
        }
        internal string Description {
            get { return _Description; }
            set { _Description = value; }
        }

    }
    interface ICar {
    }
    public abstract class AbstractCar : ICar {
    }
    struct EngineStruct {
    }
    class Program
    {
        static int counter;
        static void PrintLogo() {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C# is great!");
            PrintLogo2();
        }

        static void PrintLogo(int i) {
            Console.WriteLine(i);
        }

        static void PrintLogo2() {
            counter++;
            if (counter == 3) { return; }
            Console.WriteLine("This is PrintLogo2!");
            PrintLogo2();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("This is my first C# project!");
            //Mercedes mercedes = new Mercedes();
            //EngineStruct engine1 = new EngineStruct();
            //ICar car = new Mercedes();
            //AbstractCar car2 = new Mercedes(5);
            //Console.WriteLine("Mercedes is: " + mercedes.Description);
            //Console.WriteLine("Mercedes costs: " + mercedes.Price);
            PrintLogo();
            PrintLogo(1);
            Mercedes mercedes1 = new Mercedes();
            //mercedes.PrintMercedesLogo();
            mercedes1.PrintNewMercedes(Mercedes.staticcounter++);
            Mercedes mercedes2 = new Mercedes();
            mercedes2.PrintNewMercedes(Mercedes.staticcounter++);
            Mercedes mercedes3 = new Mercedes();
            mercedes3.PrintNewMercedes(Mercedes.staticcounter++);
            Mercedes mercedes4 = new Mercedes();
            mercedes4.PrintNewMercedes(Mercedes.staticcounter++);
            Mercedes.StartEngine();
            Console.ReadKey();
        }
    }
}
