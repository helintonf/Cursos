using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    class MyValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(((string)value).Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return base.IsValid(value);
        }

    }
}
