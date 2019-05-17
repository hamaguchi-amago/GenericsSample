using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample {
    class Sample2 {
        public void OutPut() {

            int? data1 = null;
            long? data2 = null;

            var result1 = Convert.ToInt32(data1);
            var result2 = Convert.ToInt32(data2);

            Console.WriteLine("result1");
            WriteData(result1);
            Console.WriteLine("result2");
            WriteData(result2);
        }

        private void WriteData(object data) {
            Console.WriteLine("Type: " + data.GetType() + " Value: " + data.ToString());
            Console.WriteLine();
        }
    }
}
