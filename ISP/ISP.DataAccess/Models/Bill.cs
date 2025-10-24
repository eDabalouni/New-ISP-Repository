﻿using ISP.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISP.DataAccess.Models

{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime PayementAt { get; set; }
        public double TotalAmount { get; set; }
        public enum PayementStatus { Checked, Unchecked }
        public PayementStatus Status { get; set; }

        public bool IsDeleted { get; set; } = false;


        public Customer Customer { get; set; }//Navigation Property

        //One to Many Relationship between customer and Bill
        public int CustomerId { get; set; }


        //One to one relationship between payment and bill
        public Payment Payment { get; set; }

    }
}
