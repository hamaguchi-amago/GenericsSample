using System;

namespace GenericsSample {

    class Sample3 {
        public int? Int { get; set; }

        public long? Long { get; set; }

        public Decimal? Decimal { get; set; }

        public void Main() {

            Console.WriteLine("Pattern1");
            Pattern1();

            Console.WriteLine("Pattern2");
            Pattern2();

            Console.WriteLine("Pattern3");
            Pattern3();
        }

        private void Pattern1() {
            Int = null;
            Long = null;
            Decimal = null;

            var result_1_1 = Convert<int?, int>(Int);
            var result_1_2 = Convert<long?, long>(Long);
            var result_1_3 = Convert<Decimal?, Decimal>(Decimal);

            WriteData(result_1_1);
            WriteData(result_1_2);
            WriteData(result_1_3);
        }

        private void Pattern2() {
            Int = null;
            Long = null;
            Decimal = null;

            var result_2_1 = Convert<int?, Decimal>(Int);
            var result_2_2 = Convert<long?, int>(Long);
            var result_2_3 = Convert<Decimal?, int>(Decimal);

            WriteData(result_2_1);
            WriteData(result_2_2);
            WriteData(result_2_3);
        }

        private void Pattern3() {
            Int = 2147483647;
            Long = 2147483648;
            Decimal = 1000;

            var result_3_1 = Convert<int?, int>(Int);
            var result_3_2 = Convert<long?, long>(Long);
            var result_3_3 = Convert<Decimal?, Decimal>(Decimal);

            WriteData(result_3_1);
            WriteData(result_3_2);
            WriteData(result_3_3);
        }

        private void WriteData(object data) {
            Console.WriteLine("Type : " + data.GetType());
            Console.WriteLine("Value: " + data.ToString());
            Console.WriteLine();
        }

        private T2 Convert<T1, T2>(T1 data) {
            if (data == null) {
                return (T2)(dynamic)(0);
            } else {
                return (T2)(dynamic)data;
            }
        }
    }
}
