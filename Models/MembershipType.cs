using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCustomerMVCWithAuthentication.Models
{
    public class MembershipType
    {
       
        public int Id { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}