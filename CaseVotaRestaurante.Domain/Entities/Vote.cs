using CaseVotaRestaurante.Domain.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Domain.Entities
{
    public class Vote : Base
    {
        //public string RestaurantName { get; private set; }

        [Required]
        public DateTime VoteDate { get; private set; }

        
        //public string PeopleName { get; private set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }


        //Construtor vazio
        public Vote() { }

        
        



        

        

    }
}
