string fname="";
double height=0.0D;
double weight=0.0D;
double BMI=0.0D;

Console.Write("imput fname:");
Console.ReadLine();

Console.Write("imput heignt: ");
height=Int32.Parse(Console.ReadLine());

Console.Write("imput weight: ");
weight=Double.Parse(Console.ReadLine());

BMI=height/weight;

BMI=Math.Pow(BMI,2);
Console.WriteLine("BMI is:"+BMI);