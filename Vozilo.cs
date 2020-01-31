using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Check
{
    class Vozilo
    {
        private MotorSUS m;
        
        public Vozilo(MotorSUS motor)
        {
            this.m = motor;
        }
        public double Registracija()
        {
            double kubikaza = m.Broj_Cilindara * m.Precnik_Klipa * m.Hod_Klipa;
            double cena = 0;
            if (kubikaza > 1000 && kubikaza < 1600)
                cena = 20000;
            else if (kubikaza > 1600)
                cena = 50000;
            return cena;
        }
       
    }
}
