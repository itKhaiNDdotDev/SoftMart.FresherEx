using SoftMart.Ex.Basic.Ex1String;
using SoftMart.Ex.Basic.Ex2Int;
using SoftMart.Ex.Basic.Ex3BoolDec;
using SoftMart.Ex.Basic.Ex4DateTime;
using SoftMart.Ex.Basic.Ex5List;
using SoftMart.Ex.Basic.Ex6Dictionary;
using SoftMart.Ex.Basic.Ex7OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic
{
    class Program
    {
        /// <summary>
        /// Gọi các method ra để thực thi theo đúng đề bài
        /// </summary>
        /// <param name="args">Tham số dòng lệnh</param>
        /// Author: KhaiND (28/03/2023)
        public static void Main(string[] args)
        {
            //// 1.1
            //StringProgram.RunConsole();

            //// 1.2 (1.1)
            //IntProgram.RunConsole();

            //// 1.2 (1.2)
            //BoolProgram.RunConsole();

            //// 1.3 (1.3)
            //DecimalProgram.RunConsole();

            //// 1.4
            //DateTimeProgram.RunConsole();

            //// 2.1
            //ListProgram.RunConsole();

            //// 2.2
            //DictionaryProgram.RunConsole();

            // 3
            var employee = new Employee("Nguyễn Văn Nguoi", 15, new DateTime(2023, 03, 30, 14, 15, 05));
            var student = new Student("Trần Học Sinh", 22, DateTime.Now.AddDays(-1), "Công nghệ thông tin");
            Teacher teacher = new Teacher("Lê Giáo Viên", 30, DateTime.Now, "Tổ Văn phòng");
            employee.ShowInfo();
            employee.ExtInfo();
            student.ShowInfo();
            student.ExtInfo();
            teacher.ShowInfo();
            teacher.ExtInfo();
        }
    }
}
