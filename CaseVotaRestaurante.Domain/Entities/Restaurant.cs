using CaseVotaRestaurante.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Domain.Entities
{
    public class Restaurant : Base
    {
        public string Name { get; private set; }


        //Construtor vazio
        public Restaurant() { }

        //Construtor com nome
        public Restaurant(int id,string name)
        {
            Id = id;
            ValidateName(name);
        }

        //Constructor para update
        public void Update(string name)
        {
            ValidateName(name);
        }

        public ICollection<Vote> Votes { get; set; }

        private void ValidateName(String name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "O nome é necessário");
            Name = name;
        }

    }
}
