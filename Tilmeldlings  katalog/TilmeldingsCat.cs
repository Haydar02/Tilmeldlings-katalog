using System;
using System.Collections.Generic;
using System.Text;

namespace Tilmeldlings__katalog
{
    class TilmeldingsCat 
    {
        Dictionary<int, Person> personer;
        private string lejrID;
        private bool ugeRegel { get; set; }
        private DateTime startDato;
        private DateTime slutDato;
        
        public TilmeldingsCat(string lejrID , bool ugeRegel, DateTime startDato, DateTime slutDato)
        {
      
            if (startDato > slutDato)
                throw new ArgumentException("start dato er senere end slut dato");
            if (ugeRegel == true && startDato.AddDays(15) != slutDato)
                throw new ArgumentException("startdato til slutdato dækker ikke præcis to uger");
            this.lejrID = lejrID;
            this.ugeRegel = ugeRegel;
            this.startDato = startDato;
            this.slutDato = slutDato;
            personer = new Dictionary<int, Person>();


        }
        public string LejrId
        {
            get { return this.lejrID; }
            set { this.lejrID = value; }
        }
       
        public DateTime StartDato
        {
            get { return this.startDato; }
            set { this.startDato = value; }
            
        }
        public DateTime SlutDato
        {
            get { return this.slutDato; }
            set { this.slutDato = value; }
        }

        public override string ToString() {
            string result  = "Lejr ID" + lejrID + " Uge " + ugeRegel + " Start Dato " + startDato + " Slut Dato " + slutDato +"\n Personer som er tilmeldt \n";
            foreach (var p in personer)
            {
                result +=p.Value.ToString() + "\n";
            }
            return result;
        }

        public void CreatePerson(Person person) {
            personer.Add(person.ID, person);


        }
        //public Person ReadPerson(int ID) {
        //    return personer[ID];
        //}

        //public void UpdatePerson(Person person) {
        //    Person p = ReadPerson(person.ID);
        //    p.Navn = person.Navn;
        //    p.Patrulje = person.Patrulje;
        //    p.Fødselsdato = person.Fødselsdato;
        //}

        public void DeletePerson(int id) {
            personer.Remove(id);
        }
    }
}
