using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex4DateTime
{
    /// <summary>
    /// Xây dựng các phương thức xử lý DateTime cho các yêu cầu tương ứng
    /// </summary>
    /// Author: KhaiND (29/03/2023)
    public class DateTimeHandle
    {
        /// <summary>
        /// Nhập dữ liệu DateTime vào từ bàn phím
        /// (Trên màn hình Console)
        /// </summary>
        /// <returns>Dữ liệu DateTime đã nhập</returns>
        /// Author: KhaiND (29/03/2023)
        public static DateTime? InputDateTime()
        {
            Console.Write("Nhập thời gian theo định dạng YYYY/MM/DD (VD: 2022/11/20): ");
            DateTime inputDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out inputDateTime))
            {
                return inputDateTime;
            }
            Console.WriteLine("Dữ liệu nhập vào không hợp lệ với định dạng DateTime.");
            return null;
        }

        /// <summary>
        /// In dữ liệu DateTime ra với thông tin ngày theo format Tiếng Việt
        /// </summary>
        /// <param name="inputDateTime">Dữ liệu DateTime đầu vào</param>
        /// <returns>Chuỗi ký tự đầu ra tương ứng thời gian đầu vào sau khi định dạng</returns>
        /// Author: KhaiND (29/03/2023)
        public static string OutputDateTime(DateTime inputDateTime)
        {
            var dayOfWeek = inputDateTime.DayOfWeek;
            string dayOfWeekFormated = "";
            switch(dayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayOfWeekFormated = "thứ 2";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeekFormated = "thứ 3";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeekFormated = "thứ 4";
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeekFormated = "thứ 5";
                    break;
                case DayOfWeek.Friday:
                    dayOfWeekFormated = "thứ 6";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeekFormated = "thứ 7";
                    break;
                case DayOfWeek.Sunday:
                    dayOfWeekFormated = "chủ nhật";
                    break;
            } 
            var day = inputDateTime.Day;
            string dd = day < 10 ? "0" + day : day.ToString();
            var month = inputDateTime.Month;
            string mm = month < 10 ? "0" + month : month.ToString();
            string yyyy = inputDateTime.Year.ToString();

            return dayOfWeekFormated + " ngày " + dd + " tháng " + mm + " năm " + yyyy;
        }

        /// <summary>
        /// Lấy ngày tiếp theo của thời gian ở DateTime đầu vào
        /// </summary>
        /// <param name="inputDateTime">Dữ liệu DateTime đầu vào</param>
        /// <returns>Ngày kế tiếp (liền sau) ngày ở dữ liệu ddaauf vào</returns>
        /// Author: KhaiND (29/03/2023)
        public static DateTime GetNextDay(DateTime inputDateTime)
        {
            return inputDateTime.AddDays(1);
        }

        /// <summary>
        /// Lấy ngày hôm qua của thời gian ở DateTime đầu vào
        /// </summary>
        /// <param name="inputDateTime">Dữ liệu DateTime đầu vào</param>
        /// <returns>Ngày hôm qua (liền trước) ngày ở dữ liệu ddaauf vào</returns>
        /// Author: KhaiND (29/03/2023)
        public static DateTime GetPreviousDay(DateTime inputDateTime)
        {
            return inputDateTime.AddDays(-1);
        }

        /// <summary>
        /// Kiểm tra xem DateTime được đưa vào là ở ngày hiện tại, ngày trong quá khứ hay tương lai
        /// </summary>
        /// <param name="inputDateTime">Dữ liệu DateTime đầu vào để kiểm tra</param>
        /// <returns>Chuỗi thông báo đầu ra tương ứng các giá trị: Ngày hôm nay, Ngày tương lai, Ngày quá khứ</returns>
        /// Author: KhaiND (29/03/2023)
        public static string CheckPastPresentFuture(DateTime inputDateTime)
        {
            if(inputDateTime.Date < DateTime.Today.Date)
            {
                return "Ngày quá khứ";
            }
            if (inputDateTime.Date > DateTime.Today.Date)
            {
                return "Ngày tương lai";
            }
            return "Ngày hôm nay";
        }

        /// <summary>
        /// In ra màn hình lần lượt các định dạng thời gian tương ứng theo yêu cầu
        /// </summary>
        /// <param name="inputDateTime">Dữ liệu DateTime đầu vào</param>
        /// Author: KhaiND (29/03/2023)
        public static void DisplayDateFormat(DateTime inputDateTime)
        {
            var day = inputDateTime.Day;
            string dd = day < 10 ? "0" + day : day.ToString();
            var month = inputDateTime.Month;
            string mm = month < 10 ? "0" + month : month.ToString();
            string yyyy = inputDateTime.Year.ToString();
            Console.WriteLine(dd + "/" + mm + "/" + yyyy);
            Console.WriteLine(yyyy + "/" + mm + "/" + dd);
            Console.WriteLine(mm + "/" + yyyy);
            Console.WriteLine(mm + "-" + yyyy);
        }

        /// <summary>
        /// Lấy ra thời gian tương ứng 10 ngày trước so với dữ liệu đầu vào
        /// </summary>
        /// <param name="inputDateTime">Thời gian tương ứng dữ liệu đầu vào</param>
        /// <returns>Thời gian tương ứng 10 ngày trước đó</returns>
        /// Author: KhaiND (29/03/2023)
        public static DateTime Get10DaysAgo(DateTime inputDateTime)
        {
            return inputDateTime.AddDays(-10);
        }

        /// <summary>
        /// Đưa ra thời gian tương ứng ngày cuối cùng của tháng ở thời gian đầu vào
        /// </summary>
        /// <param name="inputDateTime">Dữ liệu thời gian đầu vào</param>
        /// <returns>Thời gian tương ứng ngày cuối cùng của tháng</returns>
        /// Author: KhaiND (29/03/2023)
        public static DateTime GetLastDayOfMonth(DateTime inputDateTime)
        {
            // Yêu cầu thì chỉ return đơn giản DayOFWWeek, return full cho tiện
            return new DateTime(inputDateTime.Year, inputDateTime.Month, DateTime.DaysInMonth(inputDateTime.Year, inputDateTime.Month));
        }

        /// <summary>
        /// Lấy ra dữ liệu ngày cuối cùng của năm tương ứng thời gian đầu vào
        /// </summary>
        /// <param name="inputDateTime">Dữ liệu thời gian đầu vào</param>
        /// <returns>Dữ liệu ngày cuối cùng của năm tương ứng</returns>
        /// Author: KhaiND (29/03/2023)
        public static DateTime GetLastDayOfYear(DateTime inputDateTime)
        {
            return new DateTime(inputDateTime.Year, 12, 31);
        }

        /// <summary>
        /// Tính số ngày cách nhau giữa 2 mốc thời gian (ngày) ở đầu vào
        /// </summary>
        /// <param name="day1">Thời gian đầu vào 1</param>
        /// <param name="day2">Thời gian đầu vào 2</param>
        /// <returns>Giá trị tương ứng số ngày cách nhau giữa 2 ngày ở đầu vào</returns>
        /// Author: KhaiND (29/03/2023)
        public static int GetDistance(DateTime day1, DateTime day2)
        {
            return Math.Abs((day2.Date - day1.Date).Days);
        }
    }
}
