using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// credit to this guy > https://stackoverflow.com/a/11473510

namespace progFinal
{
    public static class StaticRandom
    {
        private static int seed;

        private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
            (() => new Random(Interlocked.Increment(ref seed)));

        static StaticRandom() {
            seed = Environment.TickCount;
        }

        public static Random Instance { get { return threadLocal.Value; } }
    }
}
