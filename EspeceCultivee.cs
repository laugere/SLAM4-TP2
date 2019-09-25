using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_TP2_Martin_laugere
{
    class EspeceCultivee
    {
        private int id_espece;
        private string nom_espece;

        public EspeceCultivee(int id, string n)
        {
            this.id_espece = id;
            this.nom_espece = n;
        }

        public string getNomEspece()
        {
            return this.nom_espece;
        }
    }
}
