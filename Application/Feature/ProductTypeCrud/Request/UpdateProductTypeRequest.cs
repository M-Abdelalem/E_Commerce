using Application.Dto;
using MediatR;

namespace Application.Feature.ProductCrud.Request
{
    public record UpdateProductTypeRequest(UpdateProductTypeDto updateProductTypeDto) :IRequest<ProductTypeDto>
    {
    }
}
