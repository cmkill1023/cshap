using System;
namespace Program{



  class CoffeeLuxer
  { }

  class CoffeePremuim
  {
     public static void Main(string[] args){  

        int val;

     CoffeePremuim CP = new CoffeePremuim();
     CP.selected_band(); 
     val =Int32.Parse(Console.ReadLine());
     CP.Line();
     CP.Routes(val);
     CP.Line();
    


    }

   

    public void Routes(int val)
    {
        CoffeePremuim CP = new CoffeePremuim();
        int menu;

        switch(val)
        {
            case 1:
             CP.amezon();
             menu = Int32.Parse(Console.ReadLine());
             CP.amezon_menu(menu);
             break;
            
            case 2:
             CP.inthanin();
             menu = Int32.Parse(Console.ReadLine());
             CP.inthanin_menu(menu);
             break;
            
            case 3:
             CP.punthai();
             menu = Int32.Parse(Console.ReadLine());
             CP.punthai_menu(menu);
             break;
            
            case 4:
             CP.doro();
             menu = Int32.Parse(Console.ReadLine());
             CP.doro_menu(menu);
             break;
            default:
             break;
        }





    }
    











    
    public void Line()
    {
        Console.WriteLine("...........................");
    }
    
    public void selected_band()
    {
     

     Console.WriteLine("Plese selected band coffee ");
     Console.WriteLine("1 : Amezon ");
     Console.WriteLine("2 : Inthanin ");
     Console.WriteLine("3 : Punthai ");
     Console.WriteLine("4 : D-Oro ");

     Console.Write("Selected : ");
    
    
    }
    
    public void amezon(){
        Console.WriteLine("Please Select Menu :");
        Console.WriteLine("1.  Black Coffee  ");
        Console.WriteLine("2.  Capu Chino    ");
        Console.WriteLine("3.  Late          ");
        
    }

    public void amezon_menu(int menu)
    {
        switch(menu)
        {
            case 1:
                {
                 Console.WriteLine("Amezon - Black Coffee 80 Bath");   
                 break;
                }
            case 2:
                {
                 Console.WriteLine("Amezon - Capu Chino 60 Bath");   
                 break;
                }
            case 3:
                {
                 Console.WriteLine("Amezon - Late 55 Bath");   
                 break;
                }
        }
    }
    
    public void inthanin(){
    
        Console.WriteLine("1.  Black Mix Orange");
        Console.WriteLine("2.  Late ");
        Console.WriteLine("3.  Capu Chino ");
    }

    public void inthanin_menu(int menu)
    {
        switch(menu)
        {
            case 1:
                {
                 Console.WriteLine("Inthanin - Black Mix Orange 70 Bath");   
                 break;
                }
            case 2:
                {
                 Console.WriteLine("Inthanin - Late 50 Bath");   
                 break;
                }
            case 3:
                {
                 Console.WriteLine("Inthanin - Capu Chino 55 Bath");   
                 break;
                }
        }
    }
  
    public void punthai(){
     
        Console.WriteLine("1.  Chocolate     ");
        Console.WriteLine("2.  Americano     ");
    }

    public void punthai_menu(int menu)
    {
        switch(menu)
        {
            case 1:
                {
                 Console.WriteLine("Punthai - Chocolate  65 Bath");   
                 break;
                }
            case 2:
                {
                 Console.WriteLine("Punthai - Americano  60 Bath");   
                 break;
                }
           
        }
    }
    public void doro(){
       
        Console.WriteLine("1.  Milk Chocolate");
        Console.WriteLine("2.  Capu Chino    ");
        
    }

        public void doro_menu(int menu)
    {
        switch(menu)
        {
            case 1:
                {
                 Console.WriteLine("D-Oro - Milk Chocolate  65 Bath");   
                 break;
                }
            case 2:
                {
                 Console.WriteLine("D-Oro - Capu Chino   55 Bath");   
                 break;
                }
           
        }
    }
  




  }
}
