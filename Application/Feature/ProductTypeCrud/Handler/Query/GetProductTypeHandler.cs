using Application.Contract.Persistence;
using Application.Dto;
using Application.Feature.ProductCrud.Request;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Feature.ProductCrud.Handler.Query
{
    internal class GetProductTypeHandler : IRequestHandler<GetProductTypeRequest, IReadOnlyList<ProductTypeDto>>
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;
        public GetProductTypeHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IReadOnlyList<ProductTypeDto>> Handle(GetProductTypeRequest request, CancellationToken cancellationToken)
        {
            var productsType = _unitOfWork.productTypeRepository.GetAll().Result;
            return  _mapper.Map<IReadOnlyList< ProductTypeDto >>(productsType);
        }
    }
}
