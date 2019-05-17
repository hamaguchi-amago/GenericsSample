using System;

namespace GenericsSample {
    class Sample2 {
        public void Main() {

            int? data1 = null;
            long? data2 = null;

            var result1 = Convert.ToInt32(data1);
            var result2 = Convert.ToInt64(data2);

            WriteData(result1);
            WriteData(result2);
        }

        private void WriteData(object data) {
            Console.WriteLine("Type : " + data.GetType());
            Console.WriteLine("Value: " + data.ToString());
            Console.WriteLine();
        }
    }
}
