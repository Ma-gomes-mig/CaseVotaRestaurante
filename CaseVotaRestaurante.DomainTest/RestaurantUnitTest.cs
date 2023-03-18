using CaseVotaRestaurante.Domain.Entities;
using FluentAssertions;

namespace CaseVotaRestaurante.DomainTest
{
    public class RestaurantUnitTest
    {
        [Fact(DisplayName ="CreateRestaurantWithValidName")]
        public void CreateRestaurant_WithValidName_ResultAMessageError()
        {
            Action action = () => new Restaurant(1, null);
            action.Should()
                .Throw<CaseVotaRestaurante.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("O nome é necessário");
        }
    }
}