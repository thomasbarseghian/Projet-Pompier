    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barseghian_Nezami_SAE25
{
    public class VehiculeNecessaire
    {
        private string codeTypeEngin;

        private int numero;

        private int idCaserne;

        public string CodeTypeEngin { get => codeTypeEngin; set => codeTypeEngin = value; }
        public int Numero { get => numero; set => numero = value; }

        public int IdCaserne { get => idCaserne; set => idCaserne = value; }

    }
}
