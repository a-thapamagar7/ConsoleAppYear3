using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Year3.week5
{
    public class SampleModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public long Salary { get; set; }
    }
}
