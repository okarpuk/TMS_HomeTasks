using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Hospital
{
    public class Patient
    {
        public string patientName;
        public int PlanOfThreatment;

        public Patient(string patientName, int PlanOfThreatment)
        {
            this.patientName = patientName;
            this.PlanOfThreatment = PlanOfThreatment;
        }

        public void doctorSelection()
        {
            if (PlanOfThreatment == 1)
            {
                Console.WriteLine(new Surgeon().Treat());
            }
            else if (PlanOfThreatment == 2)
            {
                Console.WriteLine(new Dentist().Treat());
            }
            else
            {
                Console.WriteLine(new Therapist().Treat());
            }
        }
    }
}
