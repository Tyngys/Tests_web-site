using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CP.Web.Models
{
    public class TestModel
    {
       public string Question { get; set; }
       public string Answer { get; set; }

        public TestModel()
        {

        }

        public TestModel(string question)
        {
            this.Answer = "";
            this.Question = question;
        }

        
    }
}