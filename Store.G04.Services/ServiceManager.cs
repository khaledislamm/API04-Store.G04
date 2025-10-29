using AutoMapper;
using Store.G04.Services.Products;

namespace Store.G04.Services
{
    public class ServiceManager(IUnitOfWork _unitOfWork, IMapper _mapper) : IServiceManager
    {
        public IProductService ProductService { get; } = new ProductService(_unitOfWork, _mapper);
    }
}
