using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample {
    class Sample1 {
        /// <summary>
        /// 
        /// </summary>
        public void OutPut() {

            int? data = null;

            var result = Convert.ToInt32(data);

            Console.WriteLine("result");
            Console.WriteLine("Type: " + result.GetType() + " Value: " + result.ToString());
            Console.WriteLine();
        }

    }
}
