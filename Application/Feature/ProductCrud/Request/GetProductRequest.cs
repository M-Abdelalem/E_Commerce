using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record GetProductRequest:IRequest<IReadOnlyList<ProductDto>>
    {
    }
}
