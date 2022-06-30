using FluentAssertions;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Tests;

public class EventTests
{
    [Fact(DisplayName = "Event: Valid values")]
    [Trait("Categoria", "ValidValues")]
    public void CreateEvent_ValidValues()
    {
        //Arrange
        Action action = () => new Event(1, "São Paulo", 50, "21/10/2022", 150.00, 1, 1);
        //Act
        action.Should()
        //Assert
           .NotThrow<ShowHouse.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Event: Invalid id")]
    [Trait("Categoria", "InvalidId")]
    public void CreateEvent_InvalidId()
    {
        //Arrange
        Action action = () => new Event(0, "São Paulo", 50, "21/10/2022", 150.00, 1, 1);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid Id value.");
    }

    [Fact(DisplayName = "Event: Invalid name")]
    [Trait("Categoria", "InvalidName")]
    public void CreateEvent_Invalidname()
    {
        //Arrange
        Action action = () => new Event(1, null, 50, "21/10/2022",150.00, 1, 1);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid event. Place is required.");
    }

    [Fact(DisplayName = "Event: Invalid capacity")]
    [Trait("Categoria", "InvalidCapacity")]
    public void CreateEvent_InvalidCapacity()
    {
        //Arrange
        Action action = () => new Event(1, "São Paulo", 0, "21/10/2022", 150.00, 1, 1);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid capacity. More capacity is required.");
    }

    [Fact(DisplayName = "Event: Invalid date")]
    [Trait("Categoria", "InvalidDate")]
    public void CreateEvent_InvalidDate()
    {
        //Arrange
        Action action = () => new Event(1, "São Paulo", 0, null, 150.00, 1, 1);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid date. Date is required");
    }

    [Fact(DisplayName = "Event: Invalid value")]
    [Trait("Categoria", "InvalidValue")]
    public void CreateEvent_InvalidValue()
    {
        //Arrange
        Action action = () => new Event(1, "São Paulo", 50, "21/10/2022", 0, 1, 1);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid value. Value is required.");
    }
}