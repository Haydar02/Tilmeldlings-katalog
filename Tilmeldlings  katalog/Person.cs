using System;
using System.Collections.Generic;
using System.Text;

namespace Tilmeldlings__katalog
{
   public class Person
    {
        private int id;
        private string navn;
        private string adresse;
        private string patrulje;
        private DateTime fødselsdato;
    

        public Person(int id, string navn, string adresse, string patrulje, DateTime fødselsdato) 
        {
            this.id = id;
            this.navn = navn;
            this.adresse= adresse;
            this.patrulje = patrulje;
            this.fødselsdato = fødselsdato;
            
           
        
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Navn
        {
            get { return this.navn; }
            set { this.navn = value; }
        }
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }
        public string Patrulje
        {
            get { return this.patrulje; }
            set { this.patrulje = value; }
        }
       
        public DateTime Fødselsdato
        {
            get { return this.fødselsdato; }
            set { this.fødselsdato = value; }
        }
        public override string ToString() {
            return " ID  : " + this.id + " :   Navn  : " + navn + " Adresse  : " + adresse + " Patrulje  : " + patrulje + "Fødselsdato  :" + fødselsdato ;
        }
    }
}
