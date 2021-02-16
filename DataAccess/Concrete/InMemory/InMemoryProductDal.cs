using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() 
            {
                new Product
                {
                    ProductId = 1,
                    CategoryId=1,
                    ProductName = "Bardak",
                    UnitPrice = 15,
                    UnitsInStock = 15
                },
                new Product
                {
                    ProductId = 2,
                    CategoryId=2,
                    ProductName = "Kamera",
                    UnitPrice = 500,
                    UnitsInStock = 3
                },
                new Product
                {
                    ProductId = 3,
                    CategoryId=3,
                    ProductName = "Telefon",
                    UnitPrice = 1500,
                    UnitsInStock = 2
                },
                new Product
                {
                    ProductId = 4,
                    CategoryId=4,
                    ProductName = "Klavye",
                    UnitPrice = 150,
                    UnitsInStock = 65
                },
                new Product
                {
                    ProductId = 5,
                    CategoryId=5,
                    ProductName = "Fare",
                    UnitPrice = 85,
                    UnitsInStock = 1
                }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_products.Remove(product); // bu şekilde listeden silme yapamayız. Çünkü bu bi referanstır. Referansı remove ile silemeyiz..

            #region foreach
            /*Product productToDelete = null;
             
            foreach (var p in _products)
            {
                if(product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }
            _products.Remove(productToDelete); //belirtilen id deki ürünü bulup onun referansını bir objeye atarak o referanstaki ürünü sildik..
            */
            #endregion

            #region LINQ
            //LINQ - Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //eşitliğin sağ tarafı foreach görevi görüyor..
            _products.Remove(productToDelete);
            #endregion
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id sine sahip ürün ü bul güncelle..
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
