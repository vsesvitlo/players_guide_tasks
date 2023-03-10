using System;
namespace hello_world_lesson1
{
	public class Program
	{
		
            static void Main(string[] args) /*first program*/
            {
                Console.WriteLine("How much is the triangle's area?");
                Console.WriteLine("Write the base size, please");
                var baseSize = Console.ReadLine();
                var baseSizeInt = Convert.ToSingle(baseSize);
                Console.WriteLine("Write the height, please");
                var height = Console.ReadLine();
                var heightInt = Convert.ToSingle(height);
                float areaTriangle = (baseSizeInt + heightInt) / 2;

                Console.WriteLine(areaTriangle);
            }

           


            /*Console.WriteLine("How much is the triangle's area?");
            Console.WriteLine("Write the base size, please");
            var baseSize = Console.ReadLine();
            var baseSizeInt = Convert.ToInt32(baseSize);
            Console.WriteLine("Write the height, please");
            var height = Console.ReadLine();
            var heightInt = Convert.ToInt32(height);
            float areaTriangle = Convert.ToSingle(baseSizeInt + heightInt)/ 2;

            Console.WriteLine(areaTriangle);*/



            /*Console.WriteLine("How much is the triangle's area?");
            Console.WriteLine("Write the base size, please");
            var baseSize = Console.ReadLine();
            Console.WriteLine("Write the height, please");
            var height = Console.ReadLine();
            int areaTriangle = (Convert.ToInt32(baseSize) + Convert.ToInt32(height)) / 2;
            Console.WriteLine(areaTriangle);*/
            //floating point division
        }
   
}

