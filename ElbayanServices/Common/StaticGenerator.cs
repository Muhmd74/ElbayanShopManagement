using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
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

        public static T FromByteArray<T>(byte[] data)
        {
            if (data==null)
            {
                return default(T);
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using MemoryStream stream = new MemoryStream(data);
            return (T) formatter.Deserialize(stream);
        }

        public static string GetLineNumber([CallerMemberName] string callerName= "")
        {
            return callerName;
        }
        public static class ProductStockStatues
        {
            public const string Sale = "مبيعات";
            public const string Procurement = "المشتريات ";
            public const string Returns = "مرتجعات";
            public const string Adjective = "تالف";
            public const string OpeningBalances = "أرصدة أفتتاحية";
           
        }
    }
}
