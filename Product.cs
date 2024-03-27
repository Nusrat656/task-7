using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;

public class Product
{
    public string Name;
    public double Price;
    public int Count;
    public double TotalIncome; 

    public void FullInfo()
    {
        Console.WriteLine($"Product name: {Name}, Product Price: {Price}, Product Count: {Count}, Totalincome: {TotalIncome}");
    }
    public void AddProduct()
    {
        Console.WriteLine("mehsulun adini daxil edin");
        Name = Console.ReadLine();
        Console.WriteLine("mehsulun qiymetini daxil et");
        Price = double.Parse(Console.ReadLine());
        Console.WriteLine("mehsulun sayini daxil edin");
        Count = int.Parse(Console.ReadLine());
    }
    public void Sell()
    {
        Console.WriteLine("Mehsulu almaq isteyirsiz");
        bool isWant = bool.Parse(Console.ReadLine());
        if (isWant)
        {
            Console.WriteLine("Nece eded istiyirsiz");
            int want = int.Parse(Console.ReadLine());
            if (want <= Count)
            {
                Console.WriteLine($"Odediyiniz mebleg {Price * want} manat");
                Console.WriteLine("Odenisi edeceysiniz");
                bool YEsNo = bool.Parse(Console.ReadLine());
                if (YEsNo)
                {
                    TotalIncome = (Price * want);
                    Console.WriteLine("Odenis olundu");
                    Count -= want;
                    FullInfo();
                }
                else
                {
                    Console.WriteLine("Odenis olunmadi Sagolun");
                }
            }
            else
            {
                Console.WriteLine("Mehsuldan qalmayib");
            }
        }
        else
        {
            Console.WriteLine("Sagolun");
        }
    }
}