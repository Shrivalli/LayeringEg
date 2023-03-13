using LayeringEg.FPModels;
namespace LayeringEg.Service
{
    public interface IProdService<Product>
    {
        List<Product> getallproducts();
        Product getproduct(int id);
        void AddProduct(Product p);
        void UpdateProduct(int id, Product p);
        void DeleteProduct(int id);

        float CalculateTotal(int id, int qty);
    }
}
