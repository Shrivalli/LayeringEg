using LayeringEg.FPModels;
namespace LayeringEg.Repository
{
    public class ProdRepo : IProductRepo<Product>
    {
        private readonly FareportalContext db;
        public ProdRepo(FareportalContext _db)
        {
            db = _db;
        }
            
        public void AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
           Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public List<Product> getallproducts()
        {
            return db.Products.ToList();
        }

        public Product getproduct(int id)
        {
            return db.Products.Find(id);
        }

        public void UpdateProduct(int id, Product p)
        {
            
            db.Products.Update(p);
            db.SaveChanges();
        }
    }
}
