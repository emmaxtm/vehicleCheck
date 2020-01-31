using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Check
{
    class MotorSUS
    {
        private int brojCilindara;
        private double precnik_Klipa;
        private double hodKlipa;

        public MotorSUS(int cilindri, double precnik,double hod)
        {
            brojCilindara = cilindri;
            precnik_Klipa = precnik;
            hodKlipa = hod;
        }
        public int Broj_Cilindara
        {
            get { return brojCilindara; }
            set { brojCilindara = value; }
        }
        public double Precnik_Klipa
        {
            get { return precnik_Klipa; }
            set { precnik_Klipa = value; }
        }
        public double Hod_Klipa
        {
            get { return hodKlipa; }
            set { hodKlipa = value; }
        }
    }
}
