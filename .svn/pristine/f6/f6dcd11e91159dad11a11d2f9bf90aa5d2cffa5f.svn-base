using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex2Int
{
    /// <summary>
    /// Triển khai các thực thi theo yêu cầu của mục 1.2 Int (1.2)
    /// </summary>
    /// Author: KhaiND (29/03/2023)
    class IntProgram
    {
        /// <summary>
        /// Gọi các method tương ứng để thực hiện các yêu cầu mục 1.2 (1.1) lên Console
        /// </summary>
        /// Author: KhaiND (29/03/2023)
        public static void RunConsole()
        {
            int inputNumber = IntHandle.InputInt();

            //Task 1
            IntHandle.CheckOddEven(inputNumber);

            //Task 2
            Console.WriteLine("Trị tuyệt dối: " + IntHandle.GetAbs(inputNumber));

            //Task 3
            Console.WriteLine($"2 mũ {inputNumber} = " + IntHandle.Get2Pow(inputNumber));

            //Task 4
            Console.Write("Số bị chia - ");
            int dividend = IntHandle.InputInt();
            Console.Write("Số chia - ");
            int divisor = IntHandle.InputInt();
            IntHandle.GetFullDivMod(dividend, divisor);

            //Task 5
            if(IntHandle.IsPrime(inputNumber))
            {
                Console.WriteLine("Số nguyên tố.");
            }
            else
            {
                Console.WriteLine("Không phải số nguyên tố.");
            }

            //Task 6
            Console.Write("Input String: ");
            string inputString = Console.ReadLine();
            if(IntHandle.IsInt32String(inputString))
            {
                Console.WriteLine("Chuỗi số.");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi số.");
            }    
        }
    }
}
