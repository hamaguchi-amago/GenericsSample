using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample {

    class Sample3 {
        public int? Int { get; set; }

        public long? Long { get; set; }

        public Decimal? Decimal { get; set; }

        public void OutPut() {

            Int = null;
            Long = null;
            Decimal = null;

            /// null許容型のintをintへ変換
            var result1 = Convert<int?, int>(Int);
            ///  null許容型のlongをlongへ変換
            var result2 = Convert<long?, long>(Long);
            ///  null許容型のDecimalをDecimalへ変換
            var result3 = Convert<Decimal?, Decimal>(Decimal);

            Console.WriteLine("パターン1");
            Console.WriteLine("result1");
            WriteData(result1);
            Console.WriteLine("result2");
            WriteData(result2);
            Console.WriteLine("result3");
            WriteData(result3);

            ///  null許容型のintをDecimalへ変換
            var result4 = Convert<int?, Decimal>(Int);
            ///  null許容型のlongをintへ変換
            var result5 = Convert<long?, int>(Long);
            ///  null許容型のDecimalをintへ変換
            var result6 = Convert<Decimal?, int>(Decimal);

            Console.WriteLine("パターン2");
            Console.WriteLine("result4");
            WriteData(result4);
            Console.WriteLine("result5");
            WriteData(result5);
            Console.WriteLine("result6");
            WriteData(result6);

            // int の最大値は	2147483647
            Int = 2147483647;
            Long = 2147483648;
            Decimal = 1000;

            /// null許容型のintをintへ変換
            var result7 = Convert<int?, int>(Int);
            ///  null許容型のlongをlongへ変換
            var result8 = Convert<long?, long>(Long);
            ///  null許容型のDecimalをDecimalへ変換
            var result9 = Convert<Decimal?, Decimal>(Decimal);

            Console.WriteLine("パターン3");
            Console.WriteLine("result7");
            WriteData(result7);
            Console.WriteLine("result8");
            WriteData(result8);
            Console.WriteLine("result9");
            WriteData(result9);
        }

        private void WriteData(object data) {
            Console.WriteLine("Type: " + data.GetType() + " Value: " + data.ToString());
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
