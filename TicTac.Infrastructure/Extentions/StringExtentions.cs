﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac.Infrastructure.Extentions
{
    public static class StringExtentions
    {
        public static int ToInt32(this string current) => Convert.ToInt32(current);
    }
}
