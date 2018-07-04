using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace secure.mymusicworld.com.Utilities
{
    public class Utility
    {
        public static bool IsBool(string input)
        {
            bool IsBool = bool.TryParse(input, out IsBool);
            return IsBool;
        }
    }


}
