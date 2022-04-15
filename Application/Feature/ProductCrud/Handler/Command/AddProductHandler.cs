using Application.Contract.Persistence;
using Application.Dto;
using Application.Feature.ProductCrud.Request;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Feature.ProductCrud.Handler.Command
{
    internal class AddProductHandler : IRequestHandler<AddProductRequest, ProductDto>
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;
        public AddProductHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<ProductDto> Handle(AddProductRequest request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request.addProductDto);
           return  _mapper.Map<ProductDto>( _unitOfWork.productRepository.Create(product));
        }
    }
}
