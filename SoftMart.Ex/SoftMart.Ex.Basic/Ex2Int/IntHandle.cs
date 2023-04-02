using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex2Int
{
    /// <summary>
    /// Xây dựng các xử lý cho các yêu cầu với Int
    /// </summary>
    /// Author: KhaiND (29/03/2023)
    public class IntHandle
    {
        /// <summary>
        /// Nhập một số nguyên vào
        /// (Dữ liệu nhập từ bàn phím trên Console)
        /// </summary>
        /// <returns>Số nguyên tương ứng đã nhập</returns>
        /// Author: KhaiND (29/03/2023)
        public static int InputInt()
        {
            Console.Write("Input Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Kiểm tra số bé hơn 0 hay không, nếu không thì số là chẵn hay lẻ
        /// </summary>
        /// <param name="inputNumber">Số nguyên đầu vào</param>
        /// Author: KhaiND (29/03/2023)
        public static void CheckOddEven(int inputNumber)
        {
            if(inputNumber <= 0)
            {
                Console.WriteLine("Số <= 0.");
            }
            else if(inputNumber%2 == 0)
            {
                Console.WriteLine("Số chẵn.");
            }
            else
            {
                Console.WriteLine("Số lẻ.");
            }
        }

        /// <summary>
        /// Tính trị tuyệt đối của số nguyên
        /// </summary>
        /// <param name="inputNumber">Số nguyên đầu vào</param>
        /// <returns>Giá trị kết quả trị tuyệt dối</returns>
        /// Author: KhaiND (29/03/2023)
        public static int GetAbs(int inputNumber)
        {
            return Math.Abs(inputNumber);
        }

        /// <summary>
        /// Tính 2 mũ x với x là một số nguyên đầu vào
        /// </summary>
        /// <param name="inputNumber">Số nguyên đầu vào x</param>
        /// <returns>Giá trị kết quả 2 mũ x tương ứng</returns>
        /// Author: KhaiND (29/03/2023)
        public static int Get2Pow(int inputNumber)
        {
            return Convert.ToInt32(Math.Pow(2, inputNumber));
        }

        /// <summary>
        /// Tính toán phép chia có dư
        /// </summary>
        /// <param name="dividend">Số bị chia</param>
        /// <param name="divisor">Số chia</param>
        /// Author: KhaiND (29/03/2023)
        public static void GetFullDivMod(int dividend, int divisor)
        {
            Console.WriteLine($"{dividend} chia {divisor} bằng {dividend/divisor} dư {dividend%divisor}");
        }

        /// <summary>
        /// Kiểm tra có là số nguyên tố không
        /// </summary>
        /// <param name="inputNumber">Số nguyên đầu vào cần kiểm tra</param>
        /// <returns>Kết quả kiểm tra: true - là số nguyên tóo, false - không là số nguyên tố</returns>
        /// Author: KhaiND (29/03/2023)
        public static bool IsPrime(int inputNumber)
        {
            if (inputNumber <= 1)
            {
                return false;
            }
            if (inputNumber == 2)
            {
                return true;
            }    
            if (inputNumber%2 == 0)
            {
                return false;
            }    

            var boundary = (int)Math.Floor(Math.Sqrt(inputNumber));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (inputNumber % i == 0)
                {
                    return false;
                }    
            }
            return true;
        }

        /// <summary>
        /// Kiểm tra có là chuỗi số (chuỗi toàn các chữ số) hay không
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <returns>Kết quả kiểm tra: true - chuỗi số, false: không là chuỗi số</returns>
        /// Author: KhaiND (29/03/2023)
        public static bool IsInt32String(string inputString)
        {
            return Regex.IsMatch(inputString, @"^\d+$");
        }
    }
}
