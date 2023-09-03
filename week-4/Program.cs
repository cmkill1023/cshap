/*plus
int plus1=2;
int plus2=3;
int plus3=4;

total = plus1 + plus2;

Console.Write(total);*/

/*int minus1=4;
int minus2=2;
int total=minus1+minus2;

Console.Write(total);*/

/*int modul1=5;
int modul2=3;
int total=modul1%minusl2;

Console.Write(total);*/

/*int plus=0; 
int total=0;

//total=plus++;
plus++;

total=plus;

Console.Write(plus);*/

/*int minus_down=10; //ลดลงที่ละ1
int total=0;
minus_down--;
total=minus_down;
Console.Write(total);*/

































/*int min=Math.Min(4,4);
Console.Write(min);

int Max=Math.Max(4,10);
Console.Write(Max);*/

/*string hello="hello";
string World="World";

Console.WriteLine(hello+" "+World);*/

/*bool val=false;
bool check=false;
Console.WriteLine(val==check);*/


//lf else
/*int input;

Console.Write("input Value :")
input=Int32.Parse.(Console.ReadLine());

if(input == 2)
{
    Console.WriteLine("true success");
}
{
    Console.WriteLine("False Value Check");
}
else if(input == 3)
{
    Console.WriteLine("yes this 3 Value success");
}
else if(input == 4)
{
    Console.WriteLine("yes this 4 Value success");
}
else if(input == 5)
{
    Console.WriteLine("yes this 5 Value success");
}else if(input ==6|| input==12);
{
    Console.WriteLine("yes this 6 or12 Value success");
}

else{
    Console.WriteLine("false Value Check");
}*/
/*
int day = 8;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
    
    default;
    Console.WriteLine("Not Found")
    break;
}*/
// Outputs "Thursday" (day 4)


















string[] Id = {"663245001", "663245002", "663245003", "663245004","663245005","663245006","663245009","663245025"};



string[] prefix= {"Mr","Mr", "Mr", "Mr","Mr","Ms","Mr","Ms"};

string[] firstname= {"Kittiphong", "Tanakorn", "Pongsakon", "Watchrapong","Intat",
"Kannikar","Kitisask","Thanaporn"};

string[] lastname= {"Chaimon", "Suphut", "kongnoi", "ManeeNgam","Kanalaksombat",
"Patposri","Srisak","Hongngam"};

int i = 0;
//int seq =1;
while (i < 8) 
{
    
  //Console.WriteLine((i+seq)+"."+Id+prefix+" "+firstname+lastname);
  //Console.WriteLine("{0} {1} {2} {3} {4}",seq++,Id[i+]+prefix)
  Console.WriteLine(Id[i]+" "+prefix[i]+"."+" "+firstname[i]+" "+lastname[i]);
  i++;
}

