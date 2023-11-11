using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"water", 10.0},
            {"milk", 20.0},
            {"candy", 2.0},
            {"egg", 7.0},
            {"noodle", 7.0},
            {"cocoa", 25.0},
            {"oil", 69.0},
            {"fish sauce", 45.0},
            {"salt", 10.0},
            {"drug", 30.0},
            {"ice cream", 110.0},
            {"alcohol", 120.0},
            {"cigarette", 130.0},
            {"lighter", 15.0},
            {"Snack", 20.0}
        };

        List<string> selectedProducts = new List<string>();
        double totalPrice = 0.0;

        Console.WriteLine("ร้านโชห่วย");

        while (true)
        {
            
            Console.WriteLine("ชื่อร้านเอ็มบ้านไร่");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\nรายการสินค้า:");
            
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} - {product.Value} บาท");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\nกรุณาพิมพ์(ชื่่อรายการสินค้าที่คุณต้องการโดย ไม่ต้องใส่ราคาสินค้า)");
            Console.Write("\nเลือกสินค้า (หากต้องการคิดเงิน พิมพ์ 'done'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;
            }
            Console.WriteLine("---------------------------------------");
            if (products.ContainsKey(input))
            {
                selectedProducts.Add(input);
                totalPrice += products[input];
                Console.WriteLine($"{input} ถูกเพิ่มในตะกร้าสินค้า");
            }
            else
            {
                Console.WriteLine("ไม่พบสินค้านี้ กรุณาเลือกใหม่");
            }
        }

        Console.WriteLine($"\nราคารวมทั้งสิ้น: {totalPrice} บาท");

        double payment;
        do
        {
            Console.Write("กรุณาใส่จำนวนเงินที่ลูกค้าชำระ: ");
        } while (!double.TryParse(Console.ReadLine(), out payment) || payment < totalPrice);

        double change = payment - totalPrice;
        Console.WriteLine($"เงินทอน: {change} บาท");

        Console.WriteLine("\nสินค้าที่ลูกค้าซื้อ:");
        foreach (var product in selectedProducts)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("\nขอบคุณที่ใช้บริการ!");
    }
}