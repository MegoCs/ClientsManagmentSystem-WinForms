using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mo7meen
{
    class ComboBoxItem
    {
        public String Text { set; get; }
        public String value { set; get; }
        public override string ToString()
        {
            return Text;
        }
    }
}
