using Application.Contract.Persistence;
using Application.Dto;
using Application.Dto.Validations;
using Application.ExcptionResult;
using Application.Feature.ProductCrud.Request;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Feature.ProductCrud.Handler.Command
{
    internal class AddProductTypeHandler : IRequestHandler<AddProductTypeRequest, ProductTypeDto>
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;
        public AddProductTypeHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<ProductTypeDto> Handle(AddProductTypeRequest request, CancellationToken cancellationToken)
        {
            AddProductTypeDtoValidation _validationRules = new AddProductTypeDtoValidation();
            var validationresult = _validationRules.Validate(request.addProductTypeDto);
            if (!validationresult.IsValid)
            {
                throw new AppException(validationresult.ToString());
            }

            ProductType productType = _mapper.Map<ProductType>(request.addProductTypeDto);
             _unitOfWork.productTypeRepository.Create(productType);
            await _unitOfWork.SaveChanges();
           return _mapper.Map<ProductTypeDto>(productType);
        }
    }
}
