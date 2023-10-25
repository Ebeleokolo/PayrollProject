using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject
{
    public class BaseEntity
    {
        public string EmployeeID { get; set; } = Guid.NewGuid().ToString();
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = new DateTime();
    }
}
