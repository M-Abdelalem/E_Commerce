using FluentValidation;

namespace Application.Dto.Validations
{
    public class AddProductTypeDtoValidation: AbstractValidator<AddProductTypeDto>
    {
      public AddProductTypeDtoValidation()
        {
            RuleFor(p => p.Name).NotEmpty()
            .MinimumLength(10).WithMessage("{PropertyName} must not be less than 10 characters.");



        }
    }    
}
