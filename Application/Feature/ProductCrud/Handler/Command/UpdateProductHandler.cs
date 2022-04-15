using Application.Contract.Persistence;
using Application.Dto;
using Application.Feature.ProductCrud.Request;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Feature.ProductCrud.Handler.Command
{
    internal class UpdateProductHandler : IRequestHandler<UpdateProductRequest, ProductDto>
    {
        readonly IMapper _mapper;   
        readonly IUnitOfWork _unitOfWork;
        public UpdateProductHandler(IMapper mapper,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork= unitOfWork;
        }
        public async Task<ProductDto> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request.updateProductDto);
            return _mapper.Map<ProductDto>(_unitOfWork.productRepository.Update(product));
        }
    }
}
