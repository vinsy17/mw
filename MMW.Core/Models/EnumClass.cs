using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMW.Core.Models
{

    public enum UserStatus
    {
        INVALID = 0,
        SUCCESS = 1,
        DUPLICATE = 2,
        DELETED = 3
    }

    public enum LoginStatus
    {
        INVALID = 0,
        SUCCESS = 1
    }

    public enum HowUFindUs
    {
        GOOGLE=1,
        FB_TWITTER=2,
        BING_YAHOO=3,
        FRIEND=4,
        EMAIL=5,
        OTHERS=6
    }
}
