using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DAL
{
    public class Car
    {
        public int CId { get; set; }
        public string CCarCi { get; set; }
        public string CStart { get; set; }
        public string CEnd { get; set; }
        public DateTime CStateTime { get; set; }
        public DateTime CEndTime { get; set; }
        public double CPrice { get; set; }
        public string CBeiZhu { get; set; }
    }
}