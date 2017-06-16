using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StaffReview.Models
{
    //Public class to be created for Staff
    public class Staff
    {
        //StaffID to be inherited for get set function
        public virtual int StaffID { get; set; }
        //StaffName to be inherited for get set function
        public virtual string StaffName { get; set; }
        //StaffSurname to be inherited for get set function
        public virtual string StaffSurname { get; set; }
        //Date Of Birth to be inherited for get set function
        public virtual DateTime DateOfBirth { get; set; }
        //JobTitle to be inherited for get set function
        public virtual string JobTitle { get; set; }
        //Address to be inherited for get set function
        public virtual string Address { get; set; }
        //Contact details to be inherited for get set function
        public virtual string ContactDetails { get; set; }
    }
}