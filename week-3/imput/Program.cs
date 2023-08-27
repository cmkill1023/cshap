string firstname="";
string lastname ="";
double height=0.0D;
double weight=0.0D;
string prefix =""; 
int ID =0;
double BMI=0.0D;

BMI=height/weight;

BMI=Math.Pow(BMI,2);

Console.Write("prefix is:");
Console.ReadLine();

Console.Write("firstname is:");
firstname=Console.ReadLine();

Console.Write("lastname is:");
lastname =Console.ReadLine();

Console.Write("ID: ");
ID=Int32.Parse(Console.ReadLine());

Console.Write("your fo heignt: ");
height=Int32.Parse(Console.ReadLine());

Console.Write("your fo weight is: ");
weight=Double.Parse(Console.ReadLine());



Console.WriteLine("*******************");
Console.WriteLine("student id is:"+ID);
Console.WriteLine(" fullname is:"+prefix+firstname+" "+lastname);
Console.WriteLine("you height ");
Console.WriteLine("you weight is:");
Console.WriteLine("you BMI is"+BMI);
Console.WriteLine("*******************");