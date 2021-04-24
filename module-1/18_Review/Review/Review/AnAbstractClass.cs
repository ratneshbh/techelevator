using System;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    abstract class AnAbstractClass
    {

        //fields SHOULD always be private
        private string _aValue;

        public string AValue {
            get {
                return _aValue;
            }
            set
            {
                if (value == "")
                {
                    _aValue = "not entered";
                }
                else
                {
                    _aValue = value;
                }
            }
        }

        public AnAbstractClass()
        {
            //AValue = "value";
        }

        public AnAbstractClass(string value)
        {
            AValue = value;
        }
    }
}
