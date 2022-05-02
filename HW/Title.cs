using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW.Colors;
namespace HW
{
    public class Title
    {
        public Basket basket;
        
        public Title(Basket basket)
        {
            this.basket = basket;
           
        }
        public void WelcomeTitle()
        {
            Blue.BlueMessage("\n\t\tДобро пожаловать в наш интернет магазин" +
                                "\n\t\tНажмите клавишу и перейдите в соответствующий раздел:" +
                                "\n\n\t\t1. Каталог" +
                                "\n\t\t2. Корзина" +
                                "\n\t\t3. Доставка" +
                                "\n\t\t4. Выход\n\n");
        
        
            int choice = int.Parse(Console.ReadLine());

           

                switch (choice)
                {
                    case 1:
                        ProductDesctiption productDesctiption = new ProductDesctiption(basket);
                        productDesctiption.ShowCatalog();
                        break;
                    case 2:
                        basket.Count(basket);
                        break;
                    case 3:
                        Delivery delivery = new HomeDelivery(basket);
                        Order<Delivery> order = new Order<Delivery>(delivery);
                        order.InfoOrder(delivery);
                        break;
                    case 4:
                        break;
                }

            

            

        }
    
    
      
    
    
    
    }
}
