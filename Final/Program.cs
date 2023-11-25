using System;




public class Program
{
    public static void Main()
    {
        Grocerystore m = new Grocerystore();
        m.MainMenu();
    }
}
class Grocerystore
{
    public string store;
    public string price;
    public void MainMenu()
    {
        Grocerystore m = new Grocerystore();
        Console.WriteLine("GrocerystoreM");
        Console.WriteLine("\nรายการสินค้า:");
        Console.WriteLine("1.water", 10.0);
        Console.WriteLine("2.milk", 20.0);
        Console.WriteLine("3.candy", 2.0);
        Console.WriteLine("4.egg", 7.0);
        Console.WriteLine("5.noodle", 7.0);
        Console.WriteLine("6.cocoa", 25.0);
        Console.WriteLine("7.oil", 69.0);
        string userChoice = Console.ReadLine().ToUpper();
        m.initialChoice(userChoice);
    }
    public void initialChoice(string Choice)
    {
        Grocerystore m = new Grocerystore();
        if (Choice == "1" || Choice == "2" || Choice == "3")
        {
            m.products(Int32.Parse(Choice));

        }
        else
        {
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("The menu you selected was not found.");
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("Press Q = Exit, H = Back To Menu");
            string NotfoundChoice = Console.ReadLine().ToUpper();
            if (NotfoundChoice == "H")
            {
                m.MainMenu();
            }
            else if (NotfoundChoice == "Q")
            {
                m.initialChoice("Q");
            }
        }

    }

    public void products(int productsId)
    {
        double water = 10.0;
        double milk = 20.0;
        double candy = 2.0;
        switch (productsId)
        {
            case 1:
                store = "water";
                break;
            case 2:
                store = "milk";
                break;
            case 3:
                store = "candy";
                break;

        }
    }
    public void change()
    {
        Grocerystore m = new Grocerystore();
        Console.WriteLine("chang");
        string userchange = Console.ReadLine().ToUpper();
        if (userchange == "1000" || userchange == "500" || userchange == "100")
            m.money(Int32.Parse(userchange));


    }


    public void money (int moneyId)
    {
        
        double onethousand = 1000;
        double Fivehundred = 500;
        double onehundred = 100;
        switch (moneyId)
        {
            case 1000:
                price = "onethousand";
                break;
            case 500:
                price = "Fivehundred";
                break;
            case 100:
                price = "onehundred";
                break;

        }
        
    }










































}








































































































