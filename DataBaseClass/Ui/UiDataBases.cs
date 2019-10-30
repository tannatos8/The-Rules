using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataBaseClass.Ui
{
    public class UiDataBases
    {
        public bool validationUserName(string chain)
        {
            return Regex.Match(chain, @"^[1-9á-úa-zA-ZñÑ\s]+$").Success;
        }
        public bool validationName(string chain)
        {
            return Regex.Match(chain, @"^[á-úa-zA-ZñÑ\s]+$").Success;
        }

        public bool validationLastName(string chain)
        {
            return Regex.Match(chain, @"^[á-úa-zA-ZñÑ\s]+$").Success;
        }

        public bool validationEmail(string chain)
        {
            return Regex.Match(chain, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success;
        }

        public bool validationPassword(string chain)
        {
            return Regex.Match(chain, @"^(\S){8,15}$").Success;
        }
    }
}
