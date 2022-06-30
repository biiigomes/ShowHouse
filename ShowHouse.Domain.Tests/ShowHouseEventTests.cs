using FluentAssertions;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Tests
{
    public class ShowHouseEventTests
    {
        [Fact(DisplayName = "Show House: Valid parameters")]
        [Trait("Categoria", "Valid")]
        public void CreateShowHouse_WithValidParameters()
        {
            //Arrange
            Action action = ()=> new ShowHouseEvent(1, "Show house name", "Show house address");
            //Act
            action.
            //Assert 
              Should().NotThrow<ShowHouse.Domain.Validation.DomainExceptionValidation>(); 
        }

        [Fact(DisplayName = "Show House: Invalid Id")]
        [Trait("Categoria", "InvalidId")]
        public void CreateShowHouse_WithInvalidId()
        {
            //Arrange
            Action action = ()=> new ShowHouseEvent(0, "Show house name", "Show house address");
            //Act
            action.Should()
            //Assert 
              .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }

        [Fact(DisplayName = "Show House: Invalid Name")]
        [Trait("Categoria", "InvalidName")]
        public void CreateShowHouse_WithInvalidName()
        {
            //Arrange
            Action action = ()=> new ShowHouseEvent(1, null, "Show house address");
            //Act
            action.Should()
            //Assert 
              .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. The name is required.");
        }

        [Fact(DisplayName = "Show House: Invalid Address")]
        [Trait("Categoria", "Invalid address")]
        public void CreateShowHouse_WithInvalidAddress()
        {
            //Arrange
            Action action = ()=> new ShowHouseEvent(1, "Show house name", null);
            //Act
            action.Should()
            //Assert 
              .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid address. Address is required.");
        }
    }
}