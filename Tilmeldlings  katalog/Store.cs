using System;
using System.Collections.Generic;
using System.Text;

namespace Tilmeldlings__katalog
{
    public class Store
    {

        public void Start() {

            //Console.WriteLine("____________| Tilmeldt dig nu|___________");
            //Console.WriteLine("skriv navn");
            //string navn = Console.ReadLine();
            //Console.WriteLine("skriv Adresse");
            //string adresse = Console.ReadLine();
            //Console.WriteLine("skriv Patrulje Navn");
            //string patrulje = Console.ReadLine();
            //Console.WriteLine("skriv dit fødselsdato");
            //string fødselsdatostring = Console.ReadLine();
            //DateTime dateTime = Convert.ToDateTime(fødselsdatostring);

            //Console.WriteLine("Du har skrevet : " + navn);




            Console.WriteLine("________|Tilmeldter personer|________");
            DateTime fødselsdag = Convert.ToDateTime("1987-11-25");
            Person p1 = new Person(1,"Haydar","Amagerfælledvej", "Patrulje : A", Convert.ToDateTime("1987-11-25"));
            Person p2 = new Person(2, "Yasser", "Amagerfælledvej", "Patrulje: A", Convert.ToDateTime("1988-11-25"));
            Person p3 = new Person(3, "Ebu", "Ishøj", "Patrulje B", Convert.ToDateTime("1990-02-01"));
            try
            {
                TilmeldingsCat t = new TilmeldingsCat(" :sommer leje", true, Convert.ToDateTime("2022-06-12"), Convert.ToDateTime("2022-06-27"));
                t.CreatePerson(p1);
                t.CreatePerson(p2);
                Console.WriteLine(t);
                TilmeldingsCat t1 = new TilmeldingsCat(":  Kabyssen", true, Convert.ToDateTime("2022-06-13"), Convert.ToDateTime("2022-06-28"));
                t1.CreatePerson(p3);
                Console.WriteLine(t1);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


           
           


            
            Console.ReadKey();
  
        }
    }
}
