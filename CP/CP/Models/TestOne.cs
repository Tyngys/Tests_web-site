using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CP.Web.Models
{
    public class TestOne
    {
       public string Question { get; set; }
       public string Answer { get; set; }

        public TestOne()
        {

        }

        public TestOne(string question)
        {
            this.Answer = "";
            this.Question = question;
        }

        
    }
}