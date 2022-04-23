using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record GetProductRequest(int productTypeId) :IRequest<IReadOnlyList<ProductDto>>
    {
    }
}
