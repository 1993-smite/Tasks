using System;
using System.Collections.Generic;
using System.Text;

namespace TestDb
{
    public static class ExtensionConvert
    {
        public static T GetValue<T>(this object input)
        {
            return (T)input;
        }
    }
}
