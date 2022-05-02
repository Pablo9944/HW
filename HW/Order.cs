using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW.Colors;

namespace HW
{
    public class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public Basket basket;

        public Order(TDelivery delivery)
        {
            Delivery = delivery;
        }
        public void InfoOrder(Delivery delivery)
        {
            if (delivery == null)
            {
                Red.RedMessage("Ваша корзина пуста");
                Title title = new Title(basket);
                title.WelcomeTitle();
            }
            if (delivery.basket.products.Count == 0)
            {
                Red.RedMessage($"\n\t\tВаша корзина пуста,доставлять нечего");
                Console.Clear();
                Title title = new Title(basket);
                title.WelcomeTitle();
            }
        
            foreach (var item in delivery.basket.products)
            {
                Green.GreenMessage($"\n\t\tВы заказали: {item.Name}  цена: {item.Price}");
            }

             Console.WriteLine($"\n\t\tВам доставят: {delivery.adress} стоимость доставки: {delivery.coast}");
            
            

        }
    }
}
