using Application.Contract.Persistence;
using Application.Dto;
using Application.Feature.ProductCrud.Request;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Feature.ProductCrud.Handler.Query
{
    internal class GetProductHandler : IRequestHandler<GetProductRequest, IReadOnlyList<ProductDto>>
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;
        public GetProductHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IReadOnlyList<ProductDto>> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Product> products=new List<Product>();
            if (request.productTypeId == 0)
                 products = _unitOfWork.productRepository.GetAll().Result;

            else
                 products = _unitOfWork.productRepository.GetByBrandId(request.productTypeId).Result;
            return  _mapper.Map<IReadOnlyList< ProductDto >>(products);
        }
    }
}
