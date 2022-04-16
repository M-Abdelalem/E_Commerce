using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record GetProductTypeRequest : IRequest<IReadOnlyList<ProductTypeDto>>
    {
    }
}
