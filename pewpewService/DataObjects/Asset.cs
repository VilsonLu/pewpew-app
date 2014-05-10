using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pewpewService.DataObjects
{
    public class Asset
    {
        public string id { get; set; }

        public string name { get; set; }

        public string owner { get; set; }

        public string borrower { get; set; }

        public string status { get; set; }
    }
}