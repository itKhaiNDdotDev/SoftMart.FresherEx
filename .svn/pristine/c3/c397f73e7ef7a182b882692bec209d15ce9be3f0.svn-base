using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex6Dictionary
{
    /// <summary>
    /// Thực thi các yêu cầu của mục 2.2 Dictionary
    /// </summary>
    /// Author: KhaiND (30/03/2023)
    public class DictionaryProgram
    {
        /// <summary>
        /// Gọi các moethod và thực thi các yêu cầu tương ứng lên màn hình Console
        /// </summary>
        /// Author: KhaiND (30/03/2023)
        public static void RunConsole()
        {
            //Task 1
            Console.WriteLine(DictionaryHandle.SampleStudents());

            //Task 2
            Console.Write("So luong sinh vien can nhap: ");
            int quantity = int.Parse(Console.ReadLine());
            var students = DictionaryHandle.InputStudentsList(quantity);
            Console.Write("Nhap ma SV de tim kiem: ");
            int searchId = int.Parse(Console.ReadLine());
            string foundName = "";
            if (students.TryGetValue(searchId, out foundName))
            {
                Console.WriteLine(foundName);
            }
            else
            {
                Console.WriteLine("Không có SV có mã " + searchId);
            }    

            //Task 3
            var newStudent = DictionaryHandle.InputStudentsList(1);
            if (students.ContainsKey(newStudent.First().Key))
            {
                Console.WriteLine("Đã có SV có mã {0} trong Dictonary", newStudent.First().Key);
            }
            else
            {
                students.Add(newStudent.First().Key, newStudent.First().Value);
                Console.WriteLine("Đã thêm SV có mã {0}, tên {1} vào Dictionary", newStudent.First().Key, newStudent.First().Value);
            }

            //Task 4
            newStudent = DictionaryHandle.InputStudentsList(1);
            int newId = newStudent.First().Key;
            string newName = newStudent.First().Value;
            if (students.ContainsKey(newId))
            {
                string oldName = students[newId];
                if(newName.Equals(oldName))
                {
                    Console.WriteLine("Thông tin đã tồn tại!");
                }
                else
                {
                    Console.WriteLine("Đã thay tên SV có mã {0} trong Dictonary từ {1} thành {2}", newId, oldName, newName);
                }
            }
            else
            {
                students.Add(newId, newName);
                Console.WriteLine("Đã thêm SV có mã {0}, tên {1} vào Dictionary", newId, newName);
            }

            //Task 5
            Console.Write("Nhập mã SV cần xóa: ");
            int deleteId = int.Parse(Console.ReadLine());
            if (students.Remove(deleteId))
            {
                Console.WriteLine("Đã xóa!");
            }
            else
            {
                Console.WriteLine("Không có SV có mã {0}", deleteId);
            }

            DictionaryHandle.OutputStudentsList(students);
        }
    }
}
