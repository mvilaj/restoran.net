using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_Testiranje
{
    public class Trokut
    {
        private float stranicaA;

        public Trokut(float stranicaA) {
            this.stranicaA = stranicaA;
        }

        public float IzracunajVisinu() {
            float visina = 0;
            if(stranicaA>=0)
            visina=(stranicaA*(float)Math.Sqrt(3))/2;
            return visina;
        }

        public float IzracunajPovrsinu() {
            float povrsina = 0;

            povrsina=(stranicaA*stranicaA*(float)Math.Sqrt(3))/4;

            return povrsina;
        }

        public float IzrcunajOpseg() {
            float opseg = 0;
            if(stranicaA>=0)
            opseg = stranicaA * 3;

            return opseg;
        }
    }
}
