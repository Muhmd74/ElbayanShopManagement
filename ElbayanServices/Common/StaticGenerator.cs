using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Common
{
    public static class StaticGenerator
    {
        public static long NextLong(this Random random, long min, long max)
        {
            if (max <= min)
                throw new ArgumentOutOfRangeException("max", "max must be > min!");

            var uRange = (ulong)(max - min);

            ulong ulongRand;
            do
            {
                byte[] buf = new byte[8];
                random.NextBytes(buf);
                ulongRand = (ulong)BitConverter.ToInt64(buf, 0);
            } while (ulongRand > ulong.MaxValue - ((ulong.MaxValue % uRange) + 1) % uRange);

            return (long)(ulongRand % uRange) + min;
        }
        public static class ProductStockStatues
        {
            public const string Sale = "مبيعات";
            public const string Procurement = "المشتريات ";
            public const string ReturnProcurement = " المشتريات ";
            public const string ReturnsOrder = " مرتجع مبيعات";
            public const string Adjective = "تالف";
            public const string OpeningBalances = "أرصدة أفتتاحية";
           
        }
    }
}
