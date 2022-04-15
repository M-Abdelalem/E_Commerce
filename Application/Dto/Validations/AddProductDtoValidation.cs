using FluentValidation;

namespace Application.Dto.Validations
{
    public class AddProductDtoValidation: AbstractValidator<AddProductDto>
    {
      public AddProductDtoValidation()
        {
            RuleFor(p => p.Name).NotEmpty(); 
            RuleFor(p => p.Description).NotEmpty(); 
            RuleFor(p=>p.Price).NotEmpty();        
        }         
    }    
}
