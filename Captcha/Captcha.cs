using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Captcha
{
    public class Captcha
    {
        private int pattern;
        private int leftOperand;
        private int oper;
        private int rightOperand;

        public Captcha(int pattern, int left, int oper, int right)
        {
            this.pattern = pattern;
            this.leftOperand = left;
            this.oper = oper;
            this.rightOperand = right;
        }

        public string Get()
        {
            return "One + 1";
        }
    }
}
