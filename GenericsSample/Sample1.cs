using System;

namespace GenericsSample {
    class Sample1 {
        public void Main() {

            int? data = null;
            var result = Convert.ToInt32(data);

            Console.WriteLine("Type : " + result.GetType());
            Console.WriteLine("Value: " + result.ToString());
        }

    }
}
