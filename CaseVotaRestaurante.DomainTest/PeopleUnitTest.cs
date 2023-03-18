using CaseVotaRestaurante.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.DomainTest
{
    public class PeopleUnitTest
    {
        [Fact(DisplayName = "CreatePeopleWithValidName")]
        public void CreatePeople_WithInvalidName_ResultAMessageError() 
        {
            Action action = () => new People(1, null);
            action.Should()
                .Throw<CaseVotaRestaurante.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("O nome é necessário");
        }
    }
}
