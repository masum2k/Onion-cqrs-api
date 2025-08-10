using Api.Application.Interfaces.UnitOfWorks;
using Api.Domain.Entitites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync();

            //var response = products.Select(p => new GetAllProductsQueryResponse
            //{
            //    Title = p.Title,
            //    Description = p.Description,
            //    Price = p.Price,
            //    Discount = p.Discount
            //}).ToList();
            //return response;

            List<GetAllProductsQueryResponse> response = new List<GetAllProductsQueryResponse>();

            foreach (var product in products) {
                response.Add(new GetAllProductsQueryResponse
                {
                    Title = product.Title,
                    Description = product.Description,
                    Price = product.Price,
                    Discount = product.Price - (product.Price * product.Discount / 100)
                });
            }
            return response;
        }
    }
}
