﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechKnowPro
{
    public class Customer
    {
        //public int cust_id,user_id,quest_id;
        //public string fN, lN, address, pos_title, email, phone,ques_answer;
        public Survey survey;

        public string customer_id { get; set; }
        public string user_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string fullname { get; set; }
        public string positionTitle { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string questionId { get; set; }
        public string questionAnswer { get; set; }
        public string description { get; set; }

    }
}