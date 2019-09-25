using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_TP2_Martin_laugere
{
    class Parcelle
    {
        private int id_parcelle;
        private DateTime date_semis;
        private DateTime date_recolte_prevue;
        private int surface_parcelle;
        private EspeceCultivee lEspece;

        public Parcelle(int id, DateTime ds, DateTime dr, int s)
        {
            this.id_parcelle = id;
            this.date_semis = ds;
            this.date_recolte_prevue = dr;
            this.surface_parcelle = s;
        }

        public EspeceCultivee getLespece()
        {
            return this.lEspece;
        }
    }
}
