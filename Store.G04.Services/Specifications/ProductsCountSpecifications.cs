namespace Store.G04.Services.Specifications
{
    public class ProductsCountSpecifications : BaseSpecifications<int, Product>
    {
        public ProductsCountSpecifications(ProductQueryParameters parameters) : base(
                P =>
                (!parameters.BrandId.HasValue || P.BrandId == parameters.BrandId)
                &&
                (!parameters.TypeId.HasValue || P.TypeId == parameters.TypeId)
                &&
                (string.IsNullOrEmpty(parameters.Search) || P.Name.ToLower().Contains(parameters.Search.ToLower()))

            )
        {
            
        }
    }
}
