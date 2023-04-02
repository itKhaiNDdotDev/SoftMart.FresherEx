using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex3BoolDec
{
    /// <summary>
    /// Thực hiện các yêu cầu mục 1.3 Decimal
    /// </summary>
    /// Author: KhaiND (29/03/2023)
    public class DecimalProgram
    {
        /// <summary>
        /// Kiểm tra xem chuỗi có định dạng hợp lệ để chuyển về Decimal hay không?
        /// Nếu hợp lệ thì trả về giá trị tương ứng nhận được
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <returns>Giá trị Decimal nhận được</returns>
        /// Author: KhaiND (29/03/2023)
        public static decimal CheckParseDecimal(string inputString)
        {
            decimal value;
            if(Decimal.TryParse(inputString, out value))
            {
                Console.WriteLine("Chuỗi hợp lệ.");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi decimal.");
            }
            return value;
        }

        /// <summary>
        /// Chuyển đổi giá trị Decimal thành String theo Format yêu cầu và làm tròn về 2 số thập phân sau dấu phẩy
        /// </summary>
        /// <param name="value">Giá trị decimal đầu vào</param>
        /// <returns>String tương ứng sau khi format</returns>
        /// Author: KhaiND (29/03/2023)
        public static string FormatDecimalToString(decimal value)
        {
            return Math.Round(value, 2).ToString("N");
        }

        /// <summary>
        /// Thực thi các yêu cầu lên màn hình Console tương ứng bài 1, 2 của mục 1.3 Decimal
        /// </summary>
        /// Auhtor: KhaiND (29/03/2023)
        public static void RunConsole()
        {
            Console.WriteLine("DECIMAL: ");
            string inputString = Console.ReadLine();
            decimal decimalValue = CheckParseDecimal(inputString);
            Console.WriteLine(decimalValue);
            Console.WriteLine(FormatDecimalToString(decimalValue));
        }
    }
}
