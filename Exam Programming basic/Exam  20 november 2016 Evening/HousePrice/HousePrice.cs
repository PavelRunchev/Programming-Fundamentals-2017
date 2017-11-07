using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class HousePrice
    {
        static void Main()
        {
            var smallRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var priceSquareMeter = double.Parse(Console.ReadLine());

            var secondRoom = smallRoomArea + (smallRoomArea * 0.10);
            var bigRoom = secondRoom + (secondRoom * 0.10);
            var bathRoom = smallRoomArea / 2;
            var allArea = smallRoomArea + kitchenArea + secondRoom + bigRoom + bathRoom;
            var corridor = allArea * 0.05;
            var totalArea = allArea + corridor;

            var price = totalArea * priceSquareMeter;
            Console.WriteLine($"{price:f2}");
        }
    }
}
