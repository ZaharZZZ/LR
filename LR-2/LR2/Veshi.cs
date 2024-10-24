using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Veshi
    {
        string veshiName;
        double veshiValue;

        public void NameVesh(string s)
        {
            veshiName = s;
        }
        public string ValueString()
        {
            return veshiName;
        }
        public void Value(double v)
        {
            veshiValue=v;
        }
        public Veshi(string Name, double Price)
        {
            veshiName=Name;
            veshiValue= Price;
        }
    }
}
