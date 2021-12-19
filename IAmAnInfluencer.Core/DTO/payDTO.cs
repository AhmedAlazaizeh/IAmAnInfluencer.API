using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class payDTO
    {
        public string cardNumber { get; set; }
        public string CVV { get; set; }
        public DateTime expDate { get; set; }
        public double cartSum { get; set; }
    }
}
