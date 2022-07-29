using System;

namespace WebApiForCountries
{
    public class Countries
    {
        public int ID { get; set; }
        public string Short_form_name { get; set; }

        public string Long_form_name { get; set; }

        public string GENC2A_code { get; set; }

        public string GENC3A_code { get; set; }

        public string Capital { get; set; }

        public string Continent { get; set; }
    }
}
