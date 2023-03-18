using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Application.DTOs
{
    public class RestaurantDTO
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é necessário")]
        [StringLength(70)]
        [DisplayName("Name")]
        public string Name { get; set; }
    }
}
