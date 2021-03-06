using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record AddProductRequest(AddProductTypeDto addProductDto) :IRequest<ProductDto>
    {
    }
}
