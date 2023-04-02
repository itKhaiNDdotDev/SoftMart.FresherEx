using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex7OOP
{
    /// <summary>
    /// Thoong tin người là Giáo viên
    /// </summary>
    /// Author: KhaiND (30/03/2023)
    public class Teacher : Employee
    {
        #region Property

        /// <summary>
        /// Bộ môn
        /// </summary>
        public string Department { get; set; }

        #endregion

        #region Constructor

        public Teacher(string name, int age, DateTime createdTime, string department) : base(name, age, createdTime)
        {
            this.Department = department;
        }

        #endregion

        #region Method

        /// <summary>
        /// Hiển thị thông tin cơ bản
        /// </summary>
        /// Author: KhaiND (30/03/2023)
        public override void ShowInfo()
        {
            Console.WriteLine("Tôi là Giáo Viên, {0} tuổi, tôi tên là {1}.", this.Age, this.Name);
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
            Console.WriteLine("Tôi là Giáo Viên tên {0}, thuộc bộ môn {1}, được tạo ra lúc {2}.", this.Name, this.Department, createdTimeFormated);
        }

        #endregion
    }
}
