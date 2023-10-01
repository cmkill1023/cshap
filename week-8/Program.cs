﻿using System;
using System.Numerics;
internal class Program



{

public static void Main(string[] args)
{

    int number_product = 0;
    string productname;
    string price;
    
   
    


    Console.Write("How many product? :");
    number_product = int.Parse(Console.ReadLine());

    string[][] data_product = new string[number_product][];



    
    

    for (int i = 0; i < number_product; i++)
    {




        Console.Write("input prouctname :");
        productname = Console.ReadLine();

        Console.Write("input product price :");
        price = Console.ReadLine();

    
        Console.WriteLine("----------------------------------------");


        data_product[i] = new string[] {productname, price };
    }
    double Discount=0;
    double money;
    double input_tax;

    

    Console.Write("input_money :");
    money = int.Parse(Console.ReadLine());
    

    Console.Write("input_taxdeducted :");
    input_tax = int.Parse(Console.ReadLine());

    Console.Write("Discount(bath) :");
    Discount = int.Parse(Console.ReadLine());
    
    


    

    Console.WriteLine("     Welcome to Computer Service             ");
    Console.WriteLine("                                             ");
    Console.WriteLine("#    product                            price");
    Console.WriteLine("---------------------------------------------");

    double product_price = 0.00;
    double tax = 0.00;
    double val = 100;
    double total = 0.00;
    double change = 0.00;


    for (int i = 0; i < number_product; i++)
    {
        Console.WriteLine(
                (i+1)+" "+
                data_product[i][0]+"  "+
                data_product[i][1]+"                "
            
            );
        total += double.Parse(data_product[i][1]);
    }

    tax=Math.Round(total * input_tax) / val + input_tax;
    total = (total-Discount);
    product_price = (total - tax);
    change = (money -total);


    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("product price                             " + product_price);
    Console.WriteLine("tax                                       " + tax);
    Console.WriteLine("Discount                                  " + Discount);
    Console.WriteLine("Total                                     " + total);
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("get the money                             " + money);
    Console.WriteLine("change                                    " + change);
    Console.WriteLine();
    Console.WriteLine("*_* Thank You*_*                          ***");








































}
}
