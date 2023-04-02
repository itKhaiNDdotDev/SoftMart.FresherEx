using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex6Dictionary
{
    /// <summary>
    /// Xây dựng các method xử lý cho các yêu cầu
    /// </summary>
    /// Author: KhaiND (30/03/2023)
    public class DictionaryHandle
    {
        /// <summary>
        /// Nhập dữ liệu Dictionary thông tin Sinh viên vào từ bàn phím (Console)
        /// </summary>
        /// <param name="quantity">Số lượng bản ghi thông tin nhập vào</param>
        /// <returns>Object Dictionary chứa thông tin Sinh viên đã nhập</returns>
        /// Author: KhaiND (30/03/2023)
        public static Dictionary<int, string> InputStudentsList(int quantity)
        {
            Console.WriteLine("Nhập danh sách Sinh viên: ");
            Dictionary<int, string> students = new Dictionary<int, string>();
            for(int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Sinh viên {0}:", i+1);
                Console.Write("- Mã SV: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("- Họ tên: ");
                string name = Console.ReadLine();
                students.Add(id, name);
            }
            return students;
        }

        /// <summary>
        /// In ra màn hình danh sách thông tin Sinh viên trong Dictionary
        /// </summary>
        /// <param name="students">Dictionary chứa danh sách thongo tin Sinh viên</param>
        /// Author: KhaiND (30/03/2023)
        public static void OutputStudentsList(Dictionary<int, string> students)
        {
            Console.WriteLine("======== DANH SÁCH tHÔNG TIN:  ==============");
            foreach(var student in students)
            {
                Console.WriteLine("  " + student.Key + "\t" + student.Value);
            }    
        }

        /// <summary>
        /// Khởi tạo một danh scsh 5 Sinh viên với Dictionary và in ra kết quả
        /// </summary>
        /// <returns>Đối tượng Dictionary chứa thông tin danh sách Sinh viên</returns>
        /// Author: KhaiND (30/03/2023)
        public static Dictionary<int, string> SampleStudents()
        {
            var students = new Dictionary<int, string>()
            {
                { 12, "Lai Van Do" },
                { 33, "Ngueyn Dinh Dung" },
                { 47, "Nguyen Duy Khai" },
                { 10, "Tran Viet Hung" },
                { 71, "Dinh The Anh" }
            };
            OutputStudentsList(students);
            return students;
        }
    }
}
