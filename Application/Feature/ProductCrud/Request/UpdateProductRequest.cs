using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record UpdateProductRequest(UpdateProductDto updateProductDto) :IRequest<ProductDto>
    {
    }
}
