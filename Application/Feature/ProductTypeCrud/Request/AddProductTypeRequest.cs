using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record AddProductTypeRequest(AddProductTypeDto addProductTypeDto) :IRequest<ProductTypeDto>
    {
    }
}
