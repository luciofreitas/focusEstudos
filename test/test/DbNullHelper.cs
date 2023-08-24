using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test
{
    public class DbNullHelper
    {
        public static object CheckNullity<T>(T value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }
    }
}