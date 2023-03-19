using CaseVotaRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.DTOs
{
    public class VoteDTO
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        //[StringLength(70)]
        //[DisplayName("RestaurantName")]
        //public string RestaurantName { get; set; }

        [Required]
        public DateTime VoteDate { get; set; }

        //[Required]
        //[StringLength(70)]
        //[DisplayName("PeopleName")]
        //public string PeopleName { get; set; }

        public int PeopleId { get; set; }
        public People People { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
