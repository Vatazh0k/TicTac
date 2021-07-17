using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTac.Infrastructure.Common
{
    public static class Locker
    {
        public static Mutex Mutex { get; set; } = new Mutex(false, "ConnectionLocker");
    }
}
