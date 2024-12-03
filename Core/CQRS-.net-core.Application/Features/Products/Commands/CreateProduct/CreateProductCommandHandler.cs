using CQRS_.net_core.Application.Interfaces.UnitOfWorks;
using CQRS_.net_core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateProductCommandHandler(IUnitOfWork unitOfWork) 
        { 
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product=new(request.Title,request.Description,request.BrandId,request.Price,request.Discount);
            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);
            var response=await unitOfWork.SaveAsync();
            if (response > 0)
            {
                foreach (var categoryId in request.CategoryIds) 
                {
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        CategoryId = categoryId,
                        ProductId = product.Id,
                    });
                };
                await unitOfWork.SaveAsync();
             }
            return Unit.Value;
        }
    }
}
