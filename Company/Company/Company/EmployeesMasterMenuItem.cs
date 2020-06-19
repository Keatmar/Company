using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{

    public class EmployeesMasterMenuItem
    {
        public EmployeesMasterMenuItem()
        {
            TargetType = typeof(EmployeesMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}