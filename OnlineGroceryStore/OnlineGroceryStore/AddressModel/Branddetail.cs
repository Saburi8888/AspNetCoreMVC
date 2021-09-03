using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineGroceryStore.AddressModel
{
    public partial class Branddetail
    {
        public string Brandname { get; set; }
        public DateTime? Contractstartdate { get; set; }
        public int? Totalnoofyearcontract { get; set; }
        public byte[] Brandlogo { get; set; }
    }
}
