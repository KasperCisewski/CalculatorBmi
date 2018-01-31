using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorBmi
{
    public class Person
    {

        public string FullName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Result> ResultList = new List<Result>();


    }
}
