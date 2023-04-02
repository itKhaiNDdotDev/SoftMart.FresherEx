using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex7OOP
{
    /// <summary>
    /// Thoong tin người là Sinh viên
    /// </summary>
    /// Author: KhaiND (30/03/2023)
    public class Student : Employee
    {
        #region Property

        /// <summary>
        /// Chuyên ngành
        /// </summary>
        public string Major { get; set; }

        #endregion

        #region Constructor

        public Student(string name, int age, DateTime createdTime, string major) : base(name, age, createdTime)
        {
            this.Major = major;
        }

        #endregion

        #region Method

        /// <summary>
        /// Hiển thị thông tin cơ bản
        /// </summary>
        /// Author: KhaiND (30/03/2023)
        public override void ShowInfo()
        {
            Console.WriteLine("Tôi tên là {0}, {1} tuổi. Tôi là Sinh Viên.", this.Name, this.Age);
        }

        /// <summary>
        /// Hiển thị thông tin bổ sung
        /// Đề yêu cầu thời gian hiển thị đến ngày nhưng do thấy "lúc" nên em đã thêm cả giờ
        /// </summary>
        /// Author: KhaiND (30/03/2023)
        public override void ExtInfo()
        {
            var hhOfCreatedTime = this.CreatedTime.Hour < 10 ? "0" + this.CreatedTime.Hour : this.CreatedTime.Hour.ToString();
            var minuteOfCreatedTime = this.CreatedTime.Minute < 10 ? "0" + this.CreatedTime.Minute : this.CreatedTime.Minute.ToString();
            var ddOfCreatedTime = this.CreatedTime.Day < 10 ? "0" + this.CreatedTime.Day : this.CreatedTime.Day.ToString();
            var mMOfCreatedTime = this.CreatedTime.Month < 10 ? "0" + this.CreatedTime.Month : this.CreatedTime.Month.ToString();
            string createdTimeFormated = hhOfCreatedTime + ":" + minuteOfCreatedTime + " ngày " + ddOfCreatedTime + " tháng " + mMOfCreatedTime + " năm " + this.CreatedTime.Year;
            Console.WriteLine("Tôi là Sinh viên tên {0}, học chuyên ngành {1}, được tạo ra lúc {2}.", this.Name, this.Major, createdTimeFormated);
        }

        #endregion
    }
}
