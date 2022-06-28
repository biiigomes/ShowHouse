using FluentAssertions;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Tests
{
    public class StyleTests
    {
        [Fact(DisplayName = "Style: Valid Style")]
        [Trait("Categoria", "ValidStyle")]
         public void CreateStyle_WithValidParameters()
        {
            //Arrange
            Action action = ()=> new Style(1, "Sertanejo", "image/sertanejo.jpg", true);
            //Act
            action.
            //Assert 
              Should().NotThrow<ShowHouse.Domain.Validation.DomainExceptionValidation>(); 
        }

        [Fact(DisplayName = "Style: Invalid id")]
        [Trait("Categoria", "InvalidId")]
         public void CreateStyle_InvalidId()
        {
            //Arrange
            Action action = ()=> new Style(0, "Sertanejo", "image/sertanejo.jpg", true);
            //Act
            action.Should()
            //Assert 
              .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
              .WithMessage("Invalid Id value.");
        }

        [Fact(DisplayName = "Style: Invalid style")]
        [Trait("Categoria", "InvalidStyle")]
         public void CreateStyle_InvalidStyle()
        {
            //Arrange
            Action action = ()=> new Style(1, null, "image/sertanejo.jpg", true);
            //Act
            action.Should()
            //Assert 
              .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
              .WithMessage("Invalid Musical Style. The musical style is required.");
        }

        [Fact(DisplayName = "Style: Invalid image")]
        [Trait("Categoria", "InvalidImage")]
         public void CreateStyle_InvalidImage()
        {
            //Arrange
            Action action = ()=> new Style(1, "Sertanejo", null, true);
            //Act
            action.Should()
            //Assert 
              .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
              .WithMessage("Invalid Image. Image is required.");
        }

        [Fact(DisplayName = "Style: Invalid image")]
        [Trait("Categoria", "InvalidStatus")]
         public void CreateStyle_InvalidStatus()
        {
            //Arrange
            Action action = ()=> new Style(1, "Sertanejo", "image/sertanejo.jpg", false);
            //Act
            action.Should()
            //Assert 
              .Throw<ShowHouse.Domain.Validation.DomainExceptionValidation>()
              .WithMessage("Invalid Status. Status is required");
        }
    }
}