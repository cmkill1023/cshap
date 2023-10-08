
using System;
using System.Runtime.CompilerServices;
namespace Program
{

    class CoffeeLuxer
    {

    }

    class CoffeePremuim
    {
        

        public static void Main(string[] args)
        {
            int val;
            CoffeePremuim CP = new CoffeePremuim();
            CP.selected_band();
          val = Int32.Parse(Console.ReadLine());
          CP.Line();
          CP.routes(val);
        }

        public void routes(int val)
        {
            CoffeePremuim CP = new CoffeePremuim();
               switch(val){
                case 1:{
                 CP.amezon();
                    break;
                }
                case 2:{
                CP.inthanin();
                    break;
                }
                 case 3:{
                CP.punthai();
                    break;
                }
                case 4:{
                CP.doro();
                    break;
                }




               }


        }












        public void Line()
        {
         Console.WriteLine("-------------------------------------------");
        }
        public void selected_band(){


            Console.WriteLine("Please selected Band Coffee ");
            Console.WriteLine("1 : Amezon ");
            Console.WriteLine("2 : Inthanin");
            Console.WriteLine("3 : Punthai");
            Console.WriteLine("4 : D-Oro");
            
            Console.Write("Selected : ");  
            

        }


        public void amezon()
        {
            Console.WriteLine("Amezon cafe");
            Console.WriteLine("manu");
            Console.WriteLine("Black Coffee");
            Console.WriteLine("Capu chino");
            Console.WriteLine("Late");
        }

        public void inthanin()
        {

            Console.WriteLine("Inthanin cafe");
            Console.WriteLine("manu");
            Console.WriteLine("Black Mix Orange");
            Console.WriteLine("Late");
            Console.WriteLine("Capu chino");
        }


        public void punthai()
        {

            Console.WriteLine("punthai cafe");
            Console.WriteLine("manu");
            Console.WriteLine("Chocolate");
            Console.WriteLine("Americano");
        }


        public void doro()
        {

            Console.WriteLine("doro cafe");
            Console.WriteLine("manu");
            Console.WriteLine("Milk Chocolate");
            Console.WriteLine("Capu chino");

        }





    }

}


