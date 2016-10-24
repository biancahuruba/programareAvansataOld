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
    internal class Mercedes : AbstractCar {
        private string _Description;
        private int _Price;
        public Mercedes() {
            _Description ="E Class";
            _Price =67000;
        }
        public Mercedes(int n) { }
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
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first C# project!");
            Mercedes mercedes = new Mercedes();
            EngineStruct engine1 = new EngineStruct();
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes(5);
            Console.WriteLine("Mercedes is: " + mercedes.Description);
            Console.WriteLine("Mercedes costs: " + mercedes.Price);
            Console.ReadKey();
        }
    }
}
