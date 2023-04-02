using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftMart.Ex.Basic.Ex7OOP
{
    /// <summary>
    /// Thông tin người (cơ bản)
    /// </summary>
    /// Author: KhaiND (30/03/2023)
    public class Employee
    {
        // Đề bài đang mổ tả phần này dùng Field (không nói Property)
        #region Property

        /// <summary>
        /// Họ và tên
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tuổi
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Thời gian tạo
        /// </summary>
        public DateTime CreatedTime { get; set; }

        #endregion

        #region Constructor

        public Employee(string name, int age, DateTime createdTime)
        {
            this.Name = name;
            this.Age = age;
            this.CreatedTime = createdTime;
        }

        #endregion

        #region Method

        /// <summary>
        /// Hiển thị thông tin cơ bản
        /// </summary>
        /// Author: KhaiND (30/03/2023)
        public virtual void ShowInfo()
        {
            Console.WriteLine("Tôi tên là {0}, {1} tuổi.", this.Name, this.Age);
        }

        /// <summary>
        /// Hiển thị thông tin bổ sung
        /// Đề yêu cầu thời gian hiển thị đến ngày nhưng do thấy "lúc" nên em đã thêm cả giờ
        /// </summary>
        /// Author: KhaiND (30/03/2023)
        public virtual void ExtInfo()
        {
            var hhOfCreatedTime = this.CreatedTime.Hour < 10 ? "0"+this.CreatedTime.Hour: this.CreatedTime.Hour.ToString();
            var minuteOfCreatedTime = this.CreatedTime.Minute < 10 ? "0" + this.CreatedTime.Minute : this.CreatedTime.Minute.ToString();
            var ddOfCreatedTime = this.CreatedTime.Day < 10 ? "0" + this.CreatedTime.Day : this.CreatedTime.Day.ToString();
            var mMOfCreatedTime = this.CreatedTime.Month < 10 ? "0" + this.CreatedTime.Month : this.CreatedTime.Month.ToString();
            string createdTimeFormated = hhOfCreatedTime + ":" + minuteOfCreatedTime + " ngày " + ddOfCreatedTime + " tháng " + mMOfCreatedTime + " năm " + this.CreatedTime.Year;
            Console.WriteLine("Tôi tên là {0}, được tạo ra lúc {1}.", this.Name, createdTimeFormated);
        }

        #endregion
    }
}