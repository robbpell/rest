using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rest_api.Models
{
    public class Employer
    {
        public Guid id { get; set; }
        public string company { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}