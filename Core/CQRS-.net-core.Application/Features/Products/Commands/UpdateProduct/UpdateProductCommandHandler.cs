using CQRS_.net_core.Application.Interfaces.AutoMapper;
using CQRS_.net_core.Application.Interfaces.UnitOfWorks;
using CQRS_.net_core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler:IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) { 
            this.unitOfWork = unitOfWork; 
            this.mapper = mapper; 
        }
        public async Task Handle(UpdateProductCommandRequest request,CancellationToken cancellationToken) 
        { 
            var product =await unitOfWork.GetReadRepository<Product>().GetAsync(x=> x.Id==request.Id&&!x.isDeleted);

            var map=mapper.Map<Product,UpdateProductCommandRequest>(request);

            var productCategories=await unitOfWork.GetReadRepository<ProductCategory>().GetAllAsync(x=>x.ProductId==product.Id);

            await unitOfWork.GetWriteRepository<ProductCategory>().HardDeleteRangeAsync(productCategories);
            foreach (var categoryId in request.CategoryIds)
            { 
            await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new() { CategoryId=categoryId,ProductId=product.Id});
            }
            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(map);
            await unitOfWork.SaveAsync();
        }
    }
}
