using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record GetProductRequest(int brandId):IRequest<IReadOnlyList<ProductDto>>
    {
    }
}
