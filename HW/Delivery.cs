using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW.Colors;

namespace HW
{
    public abstract class Delivery
    {
        public Basket basket;
        public abstract string adress { get; set; }
        public abstract uint coast { get; set; }

        public  Delivery (Basket basket)
        {
            this.basket = basket;   
        }


        

    }

    class HomeDelivery : Delivery   
    {
        public override string adress { get; set; }
        public override uint coast { get; set; }
        public HomeDelivery(Basket basket): base (basket)
        {
            if (basket.products.Count != 0)
            {
                this.basket = basket;
                adress = "г.Москва, ул Пушкина, д 15 , кв 6";
                coast = 350;
            }
           
        }
    }
    class PickPointDelivery : Delivery  
    {
        public override string adress { get; set; }
        public override uint coast { get; set; }
        public PickPointDelivery(Basket basket) : base (basket) 
        {
            if (basket.products.Count != 0)
            {
                this.basket = basket;
                adress = "г.Москва, ул Тверская - Ямская, д 2 , стр 1, напротив кафе \"Алла\"";
                coast = 200;
            }
        }
    }
    class ShopDelivery : Delivery   
    {
        public override string adress { get; set; }
        public override uint coast { get; set; }
        public ShopDelivery(Basket basket) : base(basket)
        {
            if (basket.products.Count != 0)
            {
                this.basket = basket;
                adress = "г.Москва, Смольная, д 3 ";
                coast = 50;
            }
        }
    }

    class Info
    {
        public Basket basket;
        public Info(Basket basket)
        {
            this.basket=basket; 
        }
        bool flag = true;
        public void InfoDelivery()
        {
            Blue.BlueMessage("\n\t\tВыберите тип доставки:" +
                             "\n\t\t1.Доставка курьером" +
                             "\n\t\t2.Доставка в пункт выдачи" +
                             "\n\t\t3.Самовывоз из магазина" +
                             "\n\t\t4. Выйти\n");

            do
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Delivery deliveryHome = new HomeDelivery(basket);
                        Order<Delivery> orderHome = new Order<Delivery>(deliveryHome);
                        orderHome.InfoOrder(deliveryHome);
                       
                        break;
                    case 2:
                        Delivery deliveryPick = new PickPointDelivery(basket);
                        Order<Delivery> orderPick = new Order<Delivery>(deliveryPick);
                        orderPick.InfoOrder(deliveryPick);
                      
                        break;
                    case 3:
                        Delivery deliveryShop = new ShopDelivery(basket);
                        Order<Delivery> orderShop = new Order<Delivery>(deliveryShop);
                        orderShop.InfoOrder(deliveryShop);

                        break;
                    case 4: 
                        Title title = new Title(basket);
                        title.WelcomeTitle();
                        break;
                }
            }
            while (flag);
        }
    }

}
