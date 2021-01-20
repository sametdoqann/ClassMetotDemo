using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Musteri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CustomerNo { get; set; }

        public Musteri(int id, string name, string surname, int customerNo)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.CustomerNo = customerNo;

        }
    }
}
