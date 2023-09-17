using System;
namespace Progams{

class Grade{

    public string grade_is;
public Grade(int score){
    int point;
point=score;

    //ตัดเกรด
    if (point>=80){
        grade_is="A";
    }else if(point>=75){
        grade_is="B+";
    }else if(point>=70){
        grade_is="B";

     }else if(point>=65){
        grade_is="C+";
     }else if(point>=60){
        grade_is="C";
     }else if(point>=55){
        grade_is="D+";
     }else if(point>=50){
        grade_is="D";
     }else if(point>=49){
        grade_is="E";
     }else if(point==0){
        grade_is="I";
     }else{
        grade_is="E";
     }


}



static void Main(string[]args){


int loop =0;//วนloop รับข้อมูล3รอบ

Console.Write("How meny reccord intput :");
loop=Int32.Parse(Console.ReadLine());



string Student_ID,prefix,fname,lname,score;

string[][] data= new string[loop][];
string grade;
int point;

//loopเพื่อเก็บ
for(int i=0; i < loop;i++){



Console.Write("input Student ID");
Student_ID=Console.ReadLine();

Console.Write("input prefix");
prefix =Console.ReadLine();

Console.Write("input first_name ");
fname=Console.ReadLine();

Console.Write("input last_name ");
lname=Console.ReadLine();

Console.Write("input score ");
score=Console.ReadLine();

Console.WriteLine(".....................");
//เริ่มเก็บdata
data[i]= new string [] {Student_ID,prefix,fname,lname,score};
}
for(int i=0; i < loop;i++){

Grade Score =new Grade(Int32.Parse(data[i][4]));
Console.WriteLine(Score.grade_is);




}

}
}
}