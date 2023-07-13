using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2_kviz
{
    internal class Otazka
    {
        private String znenie;
        private String moznostA;
        private String moznostB;
        private String moznostC;
        private String moznostD;
        private char spravnaMoznost;

        public Otazka(String znenie, String moznostA, String moznostB, 
                        String moznostC, String moznostD, char spravnaMoznost) { 
            this.znenie = znenie;
            this.moznostA = moznostA;
            this.moznostB = moznostB;
            this.moznostC = moznostC;
            this.moznostD = moznostD;
            this.spravnaMoznost = spravnaMoznost;
        }

        public String getZnenie() {
            return this.znenie;
        }

        public String getOdpovede()
        {
            return "a) " + this.moznostA + "\nb) " + this.moznostB + "\nc) " + this.moznostC + "\nd) " + this.moznostD;
        }

        public char getSpravnaMoznost()
        {
            return this.spravnaMoznost;
        }
    }
}
