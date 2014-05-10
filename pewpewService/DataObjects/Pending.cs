using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pewpewService.DataObjects
{
    public class Pending
    {
        public string id { get; set; }

        public string townID { get; set; }

        public string ownerID { get; set; }

        public string assetName { get; set; }
    }
}