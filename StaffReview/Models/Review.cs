using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StaffReview.Models
{
    //Public clas to be created for review
    public class Review
    {
        //ReviewID to be inherited for get set function 
        public virtual int ReviewId { get; set; }
        //Staffname to be inherited for get set function
        public virtual string StaffName { get; set; }
        //StaffSurname to be inherited for get set function
        public virtual string StaffSurname { get; set; }
        //Descrption to be inherited for get set function
        public virtual string Description { get; set; }
        //Rating to be inherited for get set function
        public virtual decimal Rating { get; set; }

    }
}