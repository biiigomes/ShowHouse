using ShowHouse.Domain.Validation;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Entities
{
    public sealed class Style : Entity
    {
        public string? MusicalStyle{get; private set;}
        public string? ImagePath {get; private set;}
        public bool? Status{get; private set;}
        public ICollection<Event>? Events {get; set;}
        public Style(string musicalStyle, string imagePath, bool status){
            ValidateDomain(musicalStyle, imagePath, status);
        }
        public Style(int id, string musicalStyle, string imagePath, bool status){
            DomainExceptionValidation.When(id < 1, "Invalid Id value.");
            Id = id;

            ValidateDomain(musicalStyle, imagePath, status);
        }
        public void ValidateDomain(string musicalStyle, string imagePath, bool status){
                DomainExceptionValidation.When(string.IsNullOrEmpty(musicalStyle),
                     "Invalid Musical Style. The musical style is required.");
                    
                MusicalStyle = musicalStyle;
                
                DomainExceptionValidation.When(string.IsNullOrEmpty(imagePath),
                      "Invalid Image. Image is required.");
                ImagePath = imagePath;
                
                DomainExceptionValidation.When(status != true, 
                      "Invalid Status. Status is required");
                Status = status;
        }
    }
}