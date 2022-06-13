using System;
using System.Collections.Generic;
using System.Text;

namespace Tilmeldlings__katalog
{
    class PatruljeFører : Person {
        private bool OK;
        private DateTime fødselsdato;

        public PatruljeFører(int id, string navn, string adresse, string patrulje,  DateTime fødselsdato) : base(id, navn, adresse, patrulje,  fødselsdato) {
            this.fødselsdato = fødselsdato;
        }


        public bool Ok
        {
            get
            {
                if (fødselsdato.AddYears(18) >= DateTime.Now)
                    OK = true;
                else
                    OK = false;
                return OK;
            }
            
        }

    }
}
