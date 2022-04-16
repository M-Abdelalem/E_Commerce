using Application.Contract.Persistence;
using Application.Dto;
using Application.Feature.ProductCrud.Request;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Feature.ProductCrud.Handler.Command
{
    internal class UpdateProductTypeHandler : IRequestHandler<UpdateProductTypeRequest, ProductTypeDto>
    {
        readonly IMapper _mapper;   
        readonly IUnitOfWork _unitOfWork;
        public UpdateProductTypeHandler(IMapper mapper,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork= unitOfWork;
        }
        public async Task<ProductTypeDto> Handle(UpdateProductTypeRequest request, CancellationToken cancellationToken)
        {
            ProductType product = _mapper.Map<ProductType>(request.updateProductTypeDto);
            return _mapper.Map<ProductTypeDto>(_unitOfWork.productTypeRepository.Update(product));
        }
    }
}
