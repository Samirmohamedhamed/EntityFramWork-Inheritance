using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCodeByEntityFramWork.Models
{
    public class Employee:Person
    {
      public int Salary { get; set; }
    }
}
