using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2Year3.week5
{
    internal class Class1
    {
        public static void Serialization()
        {
            var sampleModel = new SampleModel()
            {
                Name = "Ram",
                Department = "HR",
                Address = "Kamalpokhari",
                PhoneNumber = 9800000000,
                Salary = 20000
            };
            string jsonString = JsonSerializer.Serialize(sampleModel);
            Console.WriteLine(jsonString);
        }
    }
}
