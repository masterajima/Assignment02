using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;





namespace GroceryStore.GroceryStoreList{
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
        public Product Product 
        { 
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
    
    public class Cart 
    {
        public List<CartProduct> Items { get; set; } = new List<CartProduct>();

        public Decimal Total
        {
            get
            {
                decimal total = (decimal)0.0;
                foreach (var item in Items)
                {
                    total += item.Total;
                }
                return total;
            }
        }
        public DateTime LastAccessed { get; set; }
        public int TimeToLiveInSeconds { get; set; } = 30; // default
    }    

}
    /*public class GroceryStore{
        public string Title{
            get{
                return this.Title;

        }
        
        set{
             this.Title="vegetable";
             if(Title.Length<3 && quantity<=20){

             }
        }
        }
        
        public int quantity{
            get{
                return this.quantity;

            }
        set{
this.quantity=20;
        }
    }
    }
}*/
        

        
        
            
        
            
        



        
        


    
