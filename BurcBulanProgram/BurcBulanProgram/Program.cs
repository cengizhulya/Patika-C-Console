using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogumAyi;
            int dogumGunu;

            Console.Write("Dogdugunuz ayi sayi olarak girin:");
            dogumAyi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Dogdugunuz gunu girin:");
            dogumGunu =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            switch (dogumAyi)
            {
                case 1:
                    {
                        if ( dogumGunu >=1 && dogumGunu <= 21)
                        {
                            Console.WriteLine("Oglak Burcu");
                        }
                        else 
                        {
                            Console.WriteLine("Kova Burcu");
                        }
                        break;
                    }
                case 2:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 19)
                        {
                            Console.WriteLine("Kova Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Balik Burcu");
                        }
                        break;
                    }
                case 3:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 20)
                        {
                            Console.WriteLine("Balik Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Koc Burcu");
                        }
                        break;
                    }
                case 4:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 20)
                        {
                            Console.WriteLine("Koc Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Boga Burcu");
                        }
                        break;
                    }
                case 5:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 21)
                        {
                            Console.WriteLine("Boga Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Ikizler Burcu");
                        }
                        break;
                    }
                case 6:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 22)
                        {
                            Console.WriteLine("Ikizler Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Yengec Burcu");
                        }
                        break;
                    }
                case 7:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 22)
                        {
                            Console.WriteLine("Yengec Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Aslan Burcu");
                        }
                        break;
                    }
                case 8:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 22)
                        {
                            Console.WriteLine("Aslan Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Basak Burcu");
                        }
                        break;
                    }
                case 9:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 22)
                        {
                            Console.WriteLine("Basak Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Terazi Burcu");
                        }
                        break;
                    }
                case 10:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 22)
                        {
                            Console.WriteLine("Terazi Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Akrep Burcu");
                        }
                        break;
                    }
                case 11:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 21)
                        {
                            Console.WriteLine("Akrep Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Yay Burcu");
                        }
                        break;
                    }
                case 12:
                    {
                        if (dogumGunu >= 1 && dogumGunu <= 21)
                        {
                            Console.WriteLine("Yay Burcu");
                        }
                        else
                        {
                            Console.WriteLine("Oglak Burcu");
                        }
                        break;
                    }

                    Console.ReadLine();
            }


        }
    }
}