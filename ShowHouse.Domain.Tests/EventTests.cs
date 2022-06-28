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
        Action action = () => new Event(1, "São Paulo", 50, 150.00, true);
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
        Action action = () => new Event(0, "São Paulo", 50, 150.00, true);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid Id value.");
    }

    [Fact(DisplayName = "Event: Invalid place")]
    [Trait("Categoria", "InvalidPlace")]
    public void CreateEvent_InvalidPlace()
    {
        //Arrange
        Action action = () => new Event(1, null, 50, 150.00, true);
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
        Action action = () => new Event(1, "São Paulo", 0, 150.00, true);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid capacity. More capacity is required.");
    }

    [Fact(DisplayName = "Event: Invalid value")]
    [Trait("Categoria", "InvalidValue")]
    public void CreateEvent_InvalidValue()
    {
        //Arrange
        Action action = () => new Event(1, "São Paulo", 50, 0, true);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid value. Value is required.");
    }

    [Fact(DisplayName = "Event: Invalid status")]
    [Trait("Categoria", "InvalidStatus")]
    public void CreateEvent_InvalidStatus()
    {
        //Arrange
        Action action = () => new Event(1, "São Paulo", 50, 150.00, false);
        //Act
        action.Should()
        //Assert
           .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
             .WithMessage("Invalid status. Status is required.");
    }
}