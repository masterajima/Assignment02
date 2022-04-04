using System;
namespace groceryFood{
     public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public decimal Price { get; set; }
    }
    public class CartProduct
    {
        public int Quantity { get; set; }
        public Product Product { 
            get{

return this.Product;
            }
            set{
this.Product=this.Product;
            }
        }
        

        public decimal Total
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
    }
}