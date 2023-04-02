using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex3BoolDec
{
    /// <summary>
    /// Thực hiện các yêu cầu mục 1.2 Bool
    /// </summary>
    /// Author: KhaiND (29/03/2023)
    public class BoolProgram
    {
        /// <summary>
        /// Kiểm tra chuỗi có hợp lệ để chuyển về giá trị Boolean không
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <returns>Giá trị bool nhận được từ chuỗi - mặc định là false</returns>
        /// Author: KhaiND (29/03/2023)
        public static bool CheckBoolString(string inputString)
        {
            bool result = false;
            if(Boolean.TryParse(inputString, out result))
            {
                Console.WriteLine("Chuỗi hợp lệ.");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi bool.");
            }    
            return result;
        }

        /// <summary>
        /// Thực thi task 1 của 1.2 Bool, nhập chuỗi và kiểm tra/chuyển đổi về giá trị bool hợp lệ
        /// </summary>
        /// Author: KhaiND (29/03/2023)
        public static void RunConsole()
        {
            Console.WriteLine("BOOLEAN: ");
            string inputString = Console.ReadLine();
            Console.WriteLine(CheckBoolString(inputString));
        }
    }
}