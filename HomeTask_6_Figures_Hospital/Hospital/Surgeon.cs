using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Hospital
{
    public class Surgeon : Doctor
    {
        public override string Treat()
        {
            return "Surgical treatment";
        }
    }
}
