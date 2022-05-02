using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW.Colors;

namespace HW
{
    public abstract class Product
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Desctiption { get; set; }
        public abstract uint Price { get; set; }
    }

    class MobileTelephone : Product
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Desctiption { get; set; }
        public override uint Price { get; set; }

    }
    class Computer : Product
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Desctiption { get; set; }
        public override uint Price { get; set; }

    }
    class Accessories : Product
    {

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Desctiption { get; set; }
        public override uint Price { get; set; }
    }



    class ProductDesctiption
    {
        public Basket basket;
        public List<Product> catalogue;

        

        public Product this [int index]
        {
            get { return catalogue[index]; }
            set { catalogue[index] = value; }
        }



        public ProductDesctiption(Basket basket)
        {
            this.basket = basket;
            List<Product> catalogue = new List<Product>();
           
        }

     
         public void ShowCatalog()
        {
            bool flag = true;

            catalogue = new List<Product>()
            {
                new MobileTelephone { Id = 1, Name = "Honor 20 PRO", Desctiption = "6,4 IPS Display, 256 Gb", Price = 25000},
                new Computer {Id = 2, Name = "Apple MacBook 16 Pro", Desctiption = "Retina, 512Gb", Price = 125000},
                new Accessories{Id = 3, Name = "Cable USB/Type C", Desctiption = "2,5 м Length", Price = 1000},
            };
            
            foreach (var item in catalogue)
            {
                
                Console.WriteLine($"\t\t{item.Id} {item.Name} {item.Desctiption} {item.Price}");
            }

            do
            {
                Console.WriteLine("\n\t\tВыберите номер и нажмите соответствующую клавишу: " +
                               "\n\t\tДля выхода нажмите клавишу 4");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        basket.AddProduct(catalogue[choice - 1]);
                        Green.GreenMessage($"\n\t\tВы успешно добавили в корзину: {catalogue[choice - 1].Name}");
                        Red.RedMessage($"\n\t\tДля выхода или продолжения оформления заказа нажмите клавишу: 4");
                        break;
                    case 2:
                        basket.AddProduct(catalogue[choice - 1]);
                        Green.GreenMessage($"\n\t\tВы успешно добавили в корзину: {catalogue[choice - 1].Name}");
                        Red.RedMessage($"\n\t\tДля выхода или продолжения продолжения оформления заказа нажмите клавишу: 4");
                        
                        break;
                    case 3:
                        basket.AddProduct(catalogue[choice - 1]);
                        Green.GreenMessage($"\n\t\tВы успешно добавили в корзину: {catalogue[choice - 1].Name}");
                        Red.RedMessage($"\n\t\tДля выхода или продолжения продолжения оформления заказа нажмите клавишу: 4");
                      
                        break;
                    case 4:
                        flag = false;
                        Title title = new Title(basket);
                        Console.Clear();
                        title.WelcomeTitle();
                        break;


                }

            } while (flag);
        }




    }
}
