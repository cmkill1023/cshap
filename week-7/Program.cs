using System;
using System.Numerics;
namespace Progams

{

    class Finance
    {

        public static void Main(string[] args)
        {
            int number_product = 0;//จำนวนชิ้น
            string code;
            string productname;
            string price;


            Console.WriteLine("number of product? :");
            number_product = Int32.Parse(Console.ReadLine()); //แปลจากstatin เป็น int

            string[][] data_product = new string[number_product][];


        for (int i = 0; i < number_product; i++)
            {

                Console.WriteLine("cod prouct :");
                code = Console.ReadLine();

                Console.WriteLine("prouctname :");
                productname = Console.ReadLine();

                Console.WriteLine("price :");
                price = Console.ReadLine();

                Console.WriteLine("----------------------------------------");


                data_product[i] = new string[] { code, productname, price };

            }

                Console.WriteLine( "Bigc");
                Console.WriteLine( "---------------------------------------------"); 
                Console.WriteLine( "title(code)        price"); 
                Console.WriteLine( "---------------------------------------------");

              double product_price =0.00;
              double vat   =0.00;
              double val   =107; //val 7%
              double total =0.00;





              for (int i = 0; i < number_product; i++)
            {
                Console.WriteLine(
                    (i+1)+" "+
                    data_product[i][1]+"  "+
                    data_product[i][0]+"                "+
                    data_product[i][2]+"  "
                    
                    );
                    total += double.Parse(data_product[i][2]);
            }
                 vat =Math.Round(total*7)/val;
                total=total;
                product_price=total-vat;






                Console.WriteLine( "---------------------------------------------");
                Console.WriteLine( "product price                            "+product_price);
                Console.WriteLine( "vat                                       "+vat);
    
                Console.WriteLine( "Total                                     "+total);
                Console.WriteLine();
                Console.WriteLine( "*_* Thank You*_*                          ***");


            /*for (int i = 0; i < number_product; i++)
            {
                Console.WriteLine(data_product[i][0]);
            }*/
        }


    }


}
