using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex5List
{
    /// <summary>
    /// Triển khai các thực thi cho chương trình với List theo các yêu cầu mục 2.1 List
    /// </summary>
    /// Author: KhaiND (30/03/2023)
    public class ListProgram
    {
        /// <summary>
        /// Thực thi lần lượt các yêu cầu lên màn hình Console
        /// </summary>
        /// Author: KhaiND (29/03/2023)
        public static void RunConsole()
        {
            //Task 1
            Console.WriteLine(ListHandle.InitSample());

            //Task 2
            var inputList = ListHandle.InputList();
            inputList.Sort();
            Console.WriteLine("Sắp xếp: ");
            ListHandle.OutputList(inputList);

            //Task 3
            inputList.Reverse();
            Console.WriteLine("Đảo ngược: ");
            ListHandle.OutputList(inputList);

            //Task 4
            Console.Write("Số X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            inputList.RemoveAll((item) => item < x);
            Console.WriteLine("Bỏ đi các phần tử nhỏ hơn X: ");
            ListHandle.OutputList(inputList);

            //Task 5
            inputList = ListHandle.InputList();
            Console.Write("Số X: ");
            x = Convert.ToInt32(Console.ReadLine());
            inputList.RemoveAll((item) => item%x == 0);
            Console.WriteLine("Bỏ đi các phần tử chia hết cho X: ");
            ListHandle.OutputList(inputList);

            //Task 6
            inputList = ListHandle.InputList();
            Console.Write("Số X: ");
            x = Convert.ToInt32(Console.ReadLine());
            inputList = ListHandle.EnhanceX(inputList, x);
            Console.WriteLine("Cộng thêm X cho các phần tử bé hơn X: ");
            ListHandle.OutputList(inputList);

            //Task 7
            var lastList = inputList.GetRange(inputList.Count - x, x);
            Console.WriteLine("X phần tử cuối cùng: ");
            ListHandle.OutputList(lastList);

            //Task 8
            Console.WriteLine("X phần tử cuối cùng đảo ngược: ");
            lastList.Reverse();
            ListHandle.OutputList(lastList);
        }
    }
}