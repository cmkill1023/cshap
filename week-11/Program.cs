using System;

public class Program
{
    public static void Main()
    {
        Movie m = new Movie();
        m.MMenu();
    }
}








class Movie
{
    public string Movie_name;
    public string round_name;







    public void MMenu()//แสดงตัวเลือกชื่อหนัง
{
        Movie m = new Movie();
        Console.WriteLine("---Welcome To M Cineplex---");
        Console.WriteLine("---Please Selected Movie---");
        Console.WriteLine("----------1.Sapalur--------");
        Console.WriteLine("--------2.The Marvel-------");
        Console.WriteLine("----------3.TeeYod---------");
        Console.WriteLine("---Press q = Exit Program--");
        Console.WriteLine("---------------------------");
        Console.Write("Please Enter Your Input Selected : ");
        string userChoice = Console.ReadLine(); //รับค่าตวเลือกหนัง
        Console.WriteLine(" --------------------------");
        m.MChoice(userChoice);//ส่งไปcheckตัวเลือกที่รับค่า
    }










        public void MChoice(string Choice)//checkตัวเลือกที่รับค่าจากชื่อหนังและรอบหนัง
    {
        Movie m = new Movie();
        
        if (Choice == "1" || Choice == "2" || Choice == "3"){
            m.ChoiceNameMovie(Int32.Parse(Choice));
            m.RoundTimes();
        }else{
            
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("The menu you selected was not found.");
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("Press q = Exit, h = Back To Menu");
            string NotfoundChoice = Console.ReadLine();
            if ( NotfoundChoice == "h"){
                m.MMenu();
            }else if (NotfoundChoice == "q"){
                m.MChoice("q");
            }
        }
    }










    public void RoundTimes()//ตัวเลือกรอบหนัง
    {
        Movie m = new Movie();

        Console.WriteLine(" ---------------------------------- ");
        Console.WriteLine("Your Selected Movie : {0}", Movie_name);
        Console.WriteLine("Please Selected Movie Round Times");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("-----------1. 10:00 - 12:00---------");
        Console.WriteLine("-----------2. 12:00 - 14:00---------");
        Console.WriteLine("-----------3. 14:00 - 16:00---------");
        Console.WriteLine("--Press q = Exit, h = Back To Menu--");
        Console.WriteLine(" ---------------------------------- ");
        Console.Write("Please Enter Your Input Selected : ");
        string uRoundTimes = Console.ReadLine();
        Console.WriteLine(" ---------------------------------- ");
        if (uRoundTimes == "1" || uRoundTimes == "2" || uRoundTimes == "3"){
            m.ChoiceRoundTimes(Int32.Parse(uRoundTimes), Movie_name);

            m.Finish();
        }else{
            m.MChoice(null);
        }
    }










    public void ChoiceNameMovie(int MoviesM)//ตรวจตัวเลือกที่รับค่า
    {
        switch (MoviesM)
        {
            case 1:
                Movie_name = "Sapalur";
                break;
            case 2:
                Movie_name = "The Marvel";
                break;
            case 3:
               Movie_name = "TeeYod";
                break;
        }
    }











        public void ChoiceRoundTimes(int user, string WMovie_Name)//ตรวจตัวเลือกที่รับค่า
    {
        Movie_name = WMovie_Name;
        switch (user)
        {
            case 1:
                round_name = "10:00 - 12:00";
                break;
            case 2:
                round_name = "12:00 - 14:00";
                break;
            case 3:
                round_name = "14:00 - 16:00";
                break;
        }
    }












 public void Finish()//แสดงผลรับสุดท้าย
    {
        Console.WriteLine("-------------Finish----------------");
        Console.WriteLine(" Movie name : {0}", Movie_name);
        Console.WriteLine(" Round Times : {0}",  round_name);
        Console.WriteLine("-----------------------------------");
    }






    
































































































































}