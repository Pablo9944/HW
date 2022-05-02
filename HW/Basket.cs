using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW.Colors;

namespace HW
{
    public class Basket
    {
       public List<Product> products;
        public uint TotalCoast;

        public Product this[int index]
        {
            get { return products[index]; }
            set { products[index] = value; }
        }

        public Basket()
        {
            products = new List<Product>();
            TotalCoast = 0;
        }
    
    
        /// <summary>
        /// Добавляет товар в корзину
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void Count(Basket basket)
        {
            if (basket.products.Count == 0)
            {
                Console.WriteLine($"\n\t\tВаша корзина пуста");
                Title title = new Title(basket);
                title.WelcomeTitle();

            }

            foreach (var item in basket.products)
            {
                Green.GreenMessage($"\n\t\tВы добавили в корзину: {item.Name} цена без доставки: {item.Price}");
            }
            Console.WriteLine();
            Info info = new Info(basket);
            info.InfoDelivery();
            
        }
    
    }
}
