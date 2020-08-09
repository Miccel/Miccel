using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miccel.Models
{
    public class MemberShipType
    {
        public byte Id { set; get; }
        public short SignUpFee { set; get; }
        public byte DurationForMonth { set; get; }
        public short DiscountRate { set; get; }
    }
}