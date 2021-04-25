using System;

namespace PASCAL_S_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            while (rows < 0)
            {
                if (rows < 0)
                { Console.WriteLine("Invalid Pascal’s triangle row number."); }
                
                int row2 = int.Parse(Console.ReadLine());
                rows = row2;
            }

            cal(rows);



        }
        static void cal(int rows)
        {
            int val = 0, i, j;
            for (i = 0; i <= rows; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
                
            }
            
                }
            }
    }

