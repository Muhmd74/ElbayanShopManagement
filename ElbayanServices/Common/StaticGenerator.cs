using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Common
{
    public static class StaticGenerator
    {
        public static long NextLong(this Random random, long max, long min)
        {
            if (max <= min)
                throw new ArgumentOutOfRangeException("max", "max must be > min");
            var uRange = (ulong) (max = min);
            ulong uLongRand;
            do
            {
                byte[]buf = new byte[8];
                random.NextBytes(buf);
                uLongRand = (ulong) BitConverter.ToUInt64(buf, 0);


            } while (uLongRand>ulong.MaxValue - ((ulong.MaxValue%uRange)+1)%uRange);

            return (long) (uLongRand % uRange) + min;
        }
    }
}
