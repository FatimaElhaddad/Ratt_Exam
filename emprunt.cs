using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class emprunt
    {
        private int Debut;
        private int FinDate;

        public emprunt(int Debut, int FinDate)
        {
            this.Debut = Debut;
            this.FinDate = FinDate;
        }
    }
}
