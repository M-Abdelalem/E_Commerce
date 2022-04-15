using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record AddProductRequest(AddProductDto addProductDto) :IRequest<ProductDto>
    {
    }
}
