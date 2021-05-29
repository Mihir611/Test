using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class MainError
    {
        private string e1;
        public string e2
        {
            get
            {
                return e1;
            }
            set
            {
                e1 = value;
            }
        }
    }
}