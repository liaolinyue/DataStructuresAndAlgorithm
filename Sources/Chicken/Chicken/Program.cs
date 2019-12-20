using System;

namespace Chicken
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (var x = 0; x <= 20; x++)
            {
                for (var y = 0; y <= 33; y++)
                {
                    for (var z = 0; z <= 100; z++)
                        if ((5 * x + 3 * y + z / 3) == 100 && (x + y + z) == 100)
                        {
                            Console.WriteLine("公鸡有{0}只,母鸡有{1}只,小鸡有{2}只",x,y,z);

                        }
                }
            }

            
        }
    }
}
