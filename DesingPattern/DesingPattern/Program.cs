using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern
{

    public interface Tasit
    {
        aracCalistirOzellik aracCalistir();

    }

    class ConcreteFactory1 : Tasit
    {

        public aracCalistirOzellik aracCalistir()
        {
            return new ConcreteProductC1();
        }


    }
    class ConcreteFactory3 : Tasit
    {
        public aracCalistirOzellik aracCalistir()
        {
            return new ConcreteProductC3();
        }
    }

    class ConcreteFactory2 : Tasit
    {

        public aracCalistirOzellik aracCalistir()
        {
            return new ConcreteProductC2();
        }
    }

 

    public interface aracCalistirOzellik
    {
        string Ozellik();
    }

    class ConcreteProductC1 : aracCalistirOzellik
    {
        public string Ozellik()
        {
            return "BinekOto 4 tekerlikli bir araçtır.En fazla 5 kişi binebilir.";
        }
    }

    class ConcreteProductC2 : aracCalistirOzellik
    {
        public string Ozellik()
        {
            return "Karavan 4 tekerlikli bir araçtır.Ayrıca seyyar bir ev için kullanılır.";
        }
      
    }
   


    class ConcreteProductC3 : aracCalistirOzellik
    {
        public string Ozellik()
        {
            return "Motosiklet 2 tekerlikli bir araçtır ve sadece 2 kişi binebilir.";
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("Araç Çeşidi: BinekOto");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Araç Çeşidi: Karavan");
            ClientMethod(new ConcreteFactory2());
            Console.WriteLine();

            Console.WriteLine("Araç Çeşidi: Motosiklet");
            ClientMethod(new ConcreteFactory3());
        }

        public void ClientMethod(Tasit factory)
        {
            
            var productC = factory.aracCalistir();
            Console.WriteLine(productC.Ozellik());
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}

