using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPersonJSON
{
    [Serializable]
    public class JsonProperties
    {
        [JsonProperty("Products")]
        public List<JsonPropertie> ProductList { get; set; } = new List<JsonPropertie>();

    }
    [Serializable]
    public class JsonPropertie
    {
        public JsonPropertie() { }
        //пол //фамилия //имя //отчество //почта //дата рождения //гражданство //номер //срок действия 
        //номер пассажира //от //куда //дата с //дата к
        public JsonPropertie(Guid orderID, string sex, string name, string surname, string middleName, string email, DateTime dateBirth,string citizenship,
            int numberPas, int numberPassanger, DateTime validity, string from, string where, DateTime dateOne, DateTime dateTwo, bool orderCompleted)
        { 
            this.orderID = orderID;          
            this.sex = sex;
            this.name = name;
            this.surname = surname;
            this.middleName = middleName;
            this.email = email;
            this.dateBirth = dateBirth;
            this.citizenship = citizenship;
            this.numberPas = numberPas;
            this.numberPassanger = numberPassanger;
            this.validity = validity;
            this.from = from;
            this.where = where;
            this.dateOne = dateOne;
            this.dateTwo = dateTwo;
            this.orderCompleted = orderCompleted;
        }
        
        [JsonProperty("Order ID")]
        public Guid orderID { get; set; }
        [JsonProperty("Sex")]
        public string sex { get; set; }
        [JsonProperty("Name")]
        public string name { get; set; }
        [JsonProperty("Surname")]
        public string surname { get; set; }
        [JsonProperty("Middle Name")]
        public string middleName { get; set; }
        [JsonProperty("Shopper Email")]
        public string email { get; set; }
        [JsonProperty("Date Birth")]
        public DateTime dateBirth { get; set; }
        [JsonProperty("Citizenship")]
        public string citizenship { get; set; }
        [JsonProperty("Number Pas")]
        public int numberPas { get; set; }
        [JsonProperty("Number Passanger")]
        public int numberPassanger { get; set; }
        [JsonProperty("Validity")]
        public DateTime validity { get; set; }
        [JsonProperty("From?")]
        public string from { get; set; }
        [JsonProperty("Where?")]
        public string where { get; set; }
        [JsonProperty("Date One")]
        public DateTime dateOne { get; set; }
        [JsonProperty("Date Two")]
        public DateTime dateTwo { get; set; }
        [JsonProperty("Completed")]
        public bool orderCompleted { get; set; }
    }
}
