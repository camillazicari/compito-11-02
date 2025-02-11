using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito_11_02.models
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public string ScriviNome()
        {
            return Nome;
        }

        public string ScriviCognome()
        {
            return Cognome;
        }

        public int ScriviEta()
        {
            return Eta;
        }
    }
}
