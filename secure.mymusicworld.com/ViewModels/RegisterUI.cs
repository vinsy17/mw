using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace secure.mymusicworld.com.ViewModels
{
    public class RegisterUI
    {
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public int HowYouFindUsId { get; set; }
        //<select id="HowYouFindUsId" name="HowYouFindUsId" tabindex="7" style="margin-top: 10px;" class="multiSelect ermsg"><option value="">How You Found Us?</option><option value="3"> Google</option><option value="13"> Google Ads</option><option value="8"> Bing/Yahoo</option><option value="1"> IRS</option><option value="7"> Email</option><option value="14"> Sales Call</option><option value="9"> Facebook/Twitter</option><option value="2"> From an Accountant</option><option value="5"> From a Friend</option><option value="11"> other</option></select>
    }
}