using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex5List
{
    /// <summary>
    /// Xây dựng các method cần thiết để xử lý cho List theo yêu cầu
    /// </summary>
    /// Author: KhaiND (30/03/2023)
    public class ListHandle
    {
        /// <summary>
        /// Nhập List 10 số int vào từ bàn phím
        /// </summary>
        /// <returns>Object danh sách đã nhập</returns>
        /// Author: KhaiND (30/03/2023)
        public static List<int> InputList()
        {
            List<int> sampleList = new List<int>(10);
            Console.WriteLine("Nhập lần lượt 10 phần tử số nguyên: ");
            for(int i = 0; i < 10; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                sampleList.Add(value);
            }
            return sampleList;
        }

        /// <summary>
        /// In kết quả danh sách số int lên màn hình mỗi phần tử cách nhau bởi một khoảng trắng tab
        /// </summary>
        /// <param name="inputList">Đối tượng của List số int</param>
        /// Author: KhaiND (30/03/2023)
        public static void OutputList(List<int> inputList)
        {
            Console.WriteLine("  " + String.Join("\t", inputList));
        }

        /// <summary>
        /// Khởi tạo một List 10 phần tử kiểu int với các giá trị định sẵn và in ra màn hình
        /// </summary>
        /// <returns>Object danh sách vừa tạo</returns>
        /// Author: KhaiND (30/03/2022)
        public static List<int> InitSample()
        {
            List<int> sampleList = new List<int>()
            {
                1, 5, 7, 4, 5, 3, 10, 55, 103, -40
            };
            OutputList(sampleList);
            return sampleList;
        }

        /// <summary>
        /// Kiểm tra nếu phần tử nào của List nhỏ hơn X thì cộng X cho phần tử đó
        /// </summary>
        /// <param name="inputList">Danh sách int nhập vào</param>
        /// <param name="x">Giá trị X</param>
        /// <returns>Dãy sau khi đã kiểm tra và cộng (tăng cường X)</returns>
        /// Author: KhaiND (30/03/2023)
        public static List<int> EnhanceX(List<int> inputList, int x)
        {
            List<int> temp = new List<int>();
            foreach(int item in inputList)
            {
                if(item < x)
                {
                    temp.Add(item + x);
                }
                else
                {
                    temp.Add(item);
                }    
            }    
            return temp;
        }

        /// <summary>
        /// Dãy Fibonaci của số X? Không rõ ràng lắm
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        /// Author: KhaiND (30/03/2023)
        public static List<int> CanculateFibonaciList(int x)
        {
            //Dãy vô hạn
            return null;
        }
    }
}
