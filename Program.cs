using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"1.Water", 10.0},
            {"2.milk", 20.0},
            {"3.candy", 2.0},
            {"4.egg", 7.0},
            {"5.noodle", 7.0},
            {"6.cocoa", 25.0},
            {"7.oil", 69.0},
            {"8.fish sauce", 45.0},
            {"9.salt", 10.0},
            {"10.drug", 30.0},
            {"11.ice cream", 110.0},
            {"12.alcohol", 120.0},
            {"13.cigarette", 130.0},
            {"14.lighter", 15.0},
            {"15.Snack", 20.0}
        };
          Dictionary<int, int> moneyDenominations = new Dictionary<int, int>
        {
            {1000, 1000},
            {500, 500},
            {100, 100},
            {20, 20},
        };

        List<string> selectedProducts = new List<string>();
        double totalPrice = 0.0;

        Console.WriteLine("ร้านขายสินค้า");

        while (true)
        {
            Console.WriteLine("ร้านเอ็มบ้านไร่");
            Console.WriteLine("\nรายการสินค้า:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} - {product.Value} บาท");
            }

            Console.Write("\nเลือกสินค้า (หากต้องการคิดเงิน พิมพ์ 'done'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;
            }

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

        double payment=0.0;
        while (payment < totalPrice)
        {
            Console.Write("กรุณาใส่จำนวนเงิน (1000, 500, 100, 50, 20): ");
            int.TryParse(Console.ReadLine(), out int paymentDenomination);
            
            if (moneyDenominations.ContainsKey(paymentDenomination))
            {
                moneyDenominations[paymentDenomination]++;
                payment += paymentDenomination;
            }
            else
            {
                Console.WriteLine("ไม่รองรับเงินตรานี้ กรุณาใส่เงินใหม่");
            }
        }


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