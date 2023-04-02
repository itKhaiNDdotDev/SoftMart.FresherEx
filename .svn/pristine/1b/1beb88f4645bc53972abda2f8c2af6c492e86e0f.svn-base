using System;
using System.Text.RegularExpressions;

namespace SoftMart.Ex.Basic.Ex1String
{
    /// <summary>
    /// Thực hiện các xử lý chuỗi có trong yêu cầu
    /// </summary>
    /// Author: KhaiND (28/03/2023)
    public class StringHandle
    {
        /// <summary>
        /// Nhập String vào
        /// (Hiêjn tại đang là đọc 1 dòng từ bàn phím với Console)
        /// </summary>
        /// <returns>String đã nhập</returns>
        /// Author: KhaiND (28/03/2023)
        public static string InputString()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Kiểm tra các trường hợp null, chuỗi rỗng, chuỗi space hay là một chuỗi bình thường
        /// (yêu cầu 1)
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào để kiểm tra</param>
        /// <returns>Các chuỗi kết quả kiểm tra tương ứng</returns>
        /// Author: KhaiND (28/03/2023)
        public static string CheckInput(string inputString)
        {
            if (inputString == null)
            {
                return "Chuỗi bị null.";
            }
            else if (inputString.Length == 0)
            {
                return "Chuỗi rỗng.";
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                return "Chuỗi Space.";
            }
            else
            {
                return inputString;
            }
        }

        /// <summary>
        /// In chuỗi ra màn hình trên một dòng mới có cách dòng
        /// </summary>
        /// <param name="outputString">Chuỗi đầu ra cần được in lên</param>
        /// Author: KhaiND (28/03/2023)
        public static void OutputString(string outputString)
        {
            Console.WriteLine();
            Console.WriteLine(outputString);
        }

        /// <summary>
        /// Cắt bỏ các space ở đầu và cuối chuỗi
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <returns>Chuỗi kết quả sau khi cắt bỏ tương ứng</returns>
        /// Author: KhaiND (28/03/2023)
        public static string RemoveSpaceHeadLast(string inputString)
        {
            return inputString.Trim();
        }

        /// <summary>
        /// Cắt bỏ các khoảng trắng ở đầu chuỗi
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <returns>Chuỗi kết quả sau khi cắt bỏ tương ứng</returns>
        /// Author: KhaiND (28/03/2023)
        public static string RemoveSpaceHead(string inputString)
        {
            return inputString.TrimStart();
        }

        /// <summary>
        /// Loại bỏ các khoảng trắng có trong String
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <returns>Chuỗi kết quả sau khi cắt bỏ tương ứng</returns>
        /// Author: KhaiND (28/03/2023)
        public static string RemoveAllSpace(string inputString)
        {
            return inputString.Replace(" ", "");
        }

        /// <summary>
        /// Chuẩn hóa chuỗi để các ký tự ngay sau dấu cách và ký tự đầu tiên được viết hoa (Như họ tên)
        /// </summary>
        /// <param name="inputString">Xâu đầu vào</param>
        /// <returns>Xâu kết quả đã chuẩn hóa</returns>
        /// Author: KhaiND (28/03/2023)
        public static string FormatUpperBehindSpace(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            bool foundSpace = true;
            for (int i = 0; i < charArray.Length; i++)
            {
                //sử dụng phương thức IsLetter() để kiểm tra từng phần tử có phải là một chữ cái
                if (Char.IsLetter(charArray[i]))
                {
                    if (foundSpace)
                    {
                        //nếu phải thì sử dụng phương thức ToUpper() để in hoa ký tự đầu
                        charArray[i] = Char.ToUpper(charArray[i]);
                        foundSpace = false;
                    }
                }
                else
                {
                    foundSpace = true;
                }
            }
            return new string(charArray);
        }

        /// <summary>
        /// Đếm số khoảng trắng (space) trong xâu và in ra kết quả tương ứng
        /// </summary>
        /// <param name="inputString">Xâu đầu vào</param>
        /// Author: KhaiND (28/03/2023)
        public static void CountSpace(string inputString)
        {
            int count = 0;
            foreach (char key in inputString)
            {
                if (key == ' ' || key == '\t')
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Có {count} ký tự space.");
        }

        /// <summary>
        /// Đếm số ký tự không phải khoảng trắng có trong xâu và in ra thông báo tương ứng
        /// </summary>
        /// <param name="inputString">Xâu đầu vào</param>
        /// Author: KhaiND (28/03/2023)
        public static void CountLetter(string inputString)
        {
            // Convert sang charArrray rồi dùng char.Ietter hoặc:
            int count = 0;
            foreach (char key in inputString)
            {
                if (key != ' ' && key != '\t')
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Có {count} ký tự không phải space.");
        }

        /// <summary>
        /// So sánh hai chuỗi có giống nhau không có phân biệt chữ hoa thường
        /// </summary>
        /// <param name="input1">Chuỗi 1</param>
        /// <param name="input2">Chuỗi 2</param>
        /// Author: KhaiND (28/03/2023)
        public static void CompareStringTight(string input1, string input2)
        {
            if (input1 == input2) //String.Compare(input1, input2, false) == 0
            {
                Console.WriteLine($"Chuỗi {input1} giống chuỗi {input2}");
            }
            else
            {
                Console.WriteLine($"Chuỗi {input1} khác chuỗi {input2}");
            }
        }

        /// <summary>
        /// So sánh 2 chuỗi có giống nhau hay không mà không phân biệt hoa thường
        /// </summary>
        /// <param name="input1">Chuỗi 1</param>
        /// <param name="input2">Chuỗi 2</param>
        /// Author: KhaiND (28/03/2023)
        public static void CompareStringLoose(string input1, string input2)
        {
            if (String.Compare(input1, input2, true) == 0)
            {
                Console.WriteLine($"Chuỗi {input1} giống chuỗi {input2}");
            }
            else
            {
                Console.WriteLine($"Chuỗi {input1} khác chuỗi {input2}");
            }
        }

        /// <summary>
        /// Chuyển các xâu con "ABC" có trong xâu thành "DEF"
        /// </summary>
        /// <param name="inputString">XChuỗi đầu vào</param>
        /// <returns>Xâu kết quả sau khi đã thay thế</returns>
        /// Author: KhaiND (28/03/2023)
        public static string ReplaceABCToDEF(string inputString)
        {
            return inputString.Replace("ABC", "DEF");
        }

        /// <summary>
        /// Đưa ra xâu chào, chúc theo xâu tên đầu vào của yêu cầu số 10
        /// </summary>
        /// <param name="customerName">Xâu (tên) đầu vào</param>
        /// <returns>Xâu kết quả tương ứng cần hiển thị</returns>
        /// Author: KhaiND (28/03/2023)
        public static string SayGoodToCustomer(string customerName)
        {
            return String.Format($"Kính chào ông {customerName}. Chúc ngon miệng.", customerName);
        }

        /// <summary>
        /// Đảo ngược chuỗi
        /// </summary>
        /// <param name="inputString">Xâu đầu vào</param>
        /// <returns>Xâu kết quả đã đảo ngược</returns>
        /// Author: KhaiND (28/03/2023)
        public static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Lấy ra một số lượng ký tự đầu tiên của chuỗi mong muốn
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <param name="count">Số ký tự muốn lấy</param>
        /// <returns>Xâu kết quả cnont ký tự đầu tiên của chuỗi inputSintr</returns>
        /// Author: KhaiND (28/03/2023)
        public static string GetFirstCountChar(string inputString, int count)
        {
            return inputString.Substring(0, count);
        }

        /// <summary>
        /// Lấy ra một số lượng ký tự cuối của chuỗi mong muốn
        /// </summary>
        /// <param name="inputString">Chuỗi đầu vào</param>
        /// <param name="count">Số ký tự muốn lấy</param>
        /// <returns>Xâu kết quả cnont ký tự cuối của chuỗi inputSintr</returns>
        /// Author: KhaiND (28/03/2023)
        public static string GetLastCountChar(string inputString, int count)
        {
            return inputString.Substring(inputString.Length - count);
        }


    }
}