using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    // Tên file: Employee.cs (hoặc Song.cs theo ảnh)
    public class Employee
    {
        // Mã nhân viên
        public string Id { get; set; }

        // Tên nhân viên
        public string Name { get; set; }

        // Tuổi
        public int Age { get; set; }

        // Giới tính (True/False, thường True là Nam/Checked)
        public bool Gender { get; set; }
    }
}
