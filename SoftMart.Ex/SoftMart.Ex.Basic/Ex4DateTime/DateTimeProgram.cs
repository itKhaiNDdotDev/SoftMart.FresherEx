using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex4DateTime
{
    /// <summary>
    /// Thực thi các yêu cầu tương ứng 1.4 DateTime
    /// </summary>
    /// Author: KhaiND (29/03/2023)
    public class DateTimeProgram
    {
        /// <summary>
        /// Gọi các method đã xây dựng để thực hiện tương ứng lần lượt các yêu cầu
        /// (Lên màn hình Console).
        /// </summary>
        /// Author: KhaiND (29/03/2023)
        public static void RunConsole()
        {
            //Task 1
            Console.Write("Hôm nay là ");
            Console.WriteLine(DateTimeHandle.OutputDateTime(DateTime.Today));

            DateTime? inputDateTime = DateTimeHandle.InputDateTime();
            if (inputDateTime != null)
            {
                //Task 2
                Console.Write("Hôm nay là ");
                Console.WriteLine(DateTimeHandle.OutputDateTime(inputDateTime.Value));

                //Task 3
                Console.Write("Hôm sau là ");
                Console.WriteLine(DateTimeHandle.OutputDateTime(DateTimeHandle.GetNextDay(inputDateTime.Value)));

                //Task 4
                Console.Write("Hôm trước là ");
                Console.WriteLine(DateTimeHandle.OutputDateTime(DateTimeHandle.GetPreviousDay(inputDateTime.Value)));

                //Task 5
                Console.WriteLine(DateTimeHandle.CheckPastPresentFuture(inputDateTime.Value));

                //Task 6
                DateTimeHandle.DisplayDateFormat(inputDateTime.Value);

                //Task 7
                Console.Write("10 ngày trước là ");
                Console.WriteLine(DateTimeHandle.OutputDateTime(DateTimeHandle.Get10DaysAgo(inputDateTime.Value)));

                //Task 8
                Console.Write("Cuối tháng là ");
                Console.WriteLine(DateTimeHandle.OutputDateTime(DateTimeHandle.GetLastDayOfMonth(inputDateTime.Value)));

                //Task 9
                Console.Write("Cuối năm là ");
                Console.WriteLine(DateTimeHandle.OutputDateTime(DateTimeHandle.GetLastDayOfYear(inputDateTime.Value)));
            }

            //Task 10
            DateTime? day1 = DateTimeHandle.InputDateTime();
            if (day1 != null)
            {
                DateTime? day2 = DateTimeHandle.InputDateTime();
                if (day2 != null)
                {
                    Console.WriteLine($"2 ngày cách nhau {DateTimeHandle.GetDistance(day1.Value, day2.Value)} ngày.");
                }
            }
        }
    }
}
