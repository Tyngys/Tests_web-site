using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CP.Web.Models
{
    public class TestSecond
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string RightAnswer { get; set; }

        public TestSecond()
        {
            
        }

        public TestSecond(string question, string rightAnswer)
        {
            this.Question = question;
            this.Answer = "";
            this.RightAnswer = rightAnswer;
        }
    }
}