using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    enum Categories
    {
        Dairy, 
        Fruit, 
        Beverages, 
        Bread
    }

    class Product
    {
        private double weight;
        private string name;
        DateTime productionDate;
        private string producer;
        public Categories categories;


        public Product(double weight, string name, DateTime productionDate, string producer, Categories categories)
        {
            this.weight = weight;
            this.name = name;
            this.productionDate = productionDate;
            this.producer = producer;
            this.categories = categories;
            
        }

        

        public DateTime ExpirationDate(Product product)
        {
            if(product.categories == Categories.Dairy)
            {
                return productionDate.AddDays(7);
            }

            else if(product.categories == Categories.Fruit)
            {
                return productionDate.AddDays(2);
            }

            else if (product.categories == Categories.Beverages)
            {
                return productionDate.AddYears(3);
            }
            else
            {
                return productionDate.AddDays(4);
            }
            
        }
    }
}
