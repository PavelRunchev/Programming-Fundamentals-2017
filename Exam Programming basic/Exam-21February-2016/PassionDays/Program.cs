using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int purchase = 0;
            decimal price = 0;      
            string enter = Console.ReadLine();       
            while (enter != "mall.Exit" || enter == "mall.Enter")
            {         
                string simbol = Console.ReadLine();
                if(simbol == "mall.Exit")
                {
                    break;
                }            
                    byte[] element = Encoding.ASCII.GetBytes(simbol);
                    foreach (byte i in element)
                    {
                        if (i >= 65 && i <= 90)
                        {
                            price = i * 0.5m;
                            if (money >= price)
                            {
                               purchase++;
                               money -= price;
                            }           
                        }
                        else if (i >= 97 && i <= 122)
                        {
                            price = i * 0.3m;
                            if (money >= price)
                            {
                                  purchase++;
                                  money -= price;
                             }            
                        }
                        else if (i == '%')
                        {
                            if (money > 0)
                            {
                                price = money / 2.0m;
                                purchase++;
                                money -= price;
                            }
                        }
                        else if (i == '*')
                        {
                            money += 10;
                        }
                        else
                        {                    
                            if (money >= i)
                            {
                                purchase++;
                                money -= i;
                            }                                    
                        }
                   }                                  
            }
            if(purchase != 0)
            {
                Console.WriteLine($"{purchase} purchases. Money left: {money:f2} lv.");            
            }
            else
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
        }
    }
}

