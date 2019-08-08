using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompanyHRSystem
{
    public class Filter
    {
        public Filter(string Category, string Value)
        {
            this.Category = Category;
            this.Value = Value;
        }

        public string Category { get; }

        public string Value { get; set; }
    }
}
