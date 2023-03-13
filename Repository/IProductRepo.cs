using LayeringEg.FPModels;

namespace LayeringEg.Repository
{
    public interface IProductRepo<Product>
    {
        List<Product> getallproducts();
        Product getproduct(int id);
        void AddProduct(Product p);
        void UpdateProduct(int id,Product p);
        void DeleteProduct(int id);

    }
}
