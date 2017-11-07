using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main()
        {
            var period = int.Parse(Console.ReadLine());
            var treatPatient = 0;
            var untreatPatient = 0;
            var doctors = 7;
            for (int i = 1; i <= period; i++)
            {
                var numberPatient = int.Parse(Console.ReadLine());

                if(i % 3 == 0)
                {
                    if(untreatPatient > treatPatient)
                        doctors++;
                }

                if(numberPatient > doctors)
                {
                    treatPatient += doctors;
                    untreatPatient += numberPatient - doctors;              
                }
                if(numberPatient <= doctors)
                {
                    treatPatient += numberPatient;
                }
            }
            Console.WriteLine($"Treated patients: {treatPatient}.\nUntreated patients: {untreatPatient}.");
        }
    }
}
