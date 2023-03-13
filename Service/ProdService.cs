
using LayeringEg.Repository;
using LayeringEg.FPModels;

namespace LayeringEg.Service
{
    public class ProdService : IProdService<Product>
    {
        private readonly IProductRepo<Product> repoobj;
        public ProdService(IProductRepo<Product> robj)
        {
            repoobj = robj;
        }
        public void AddProduct(Product p)
        {
            repoobj.AddProduct(p);
        }

        public void DeleteProduct(int id)
        {
            repoobj.DeleteProduct(id);
        }

        public List<Product> getallproducts()
        {
           return repoobj.getallproducts();
        }

        public Product getproduct(int id)
        {
            return repoobj.getproduct(id);
        }

        public void UpdateProduct(int id, Product p)
        {
            repoobj.UpdateProduct(id, p);
        }

        public float CalculateTotal(int id, int qty)
        {
            float total = 0;
            Product p=repoobj.getproduct(id);
            if(p.Qty>qty)
            {
                 total = float.Parse((p.Qty * p.Price).ToString());
            }
            return total;
        }
    }
}
