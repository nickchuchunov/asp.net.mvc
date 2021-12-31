using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.mvc_lesson4.Adapter
{
    internal class AdapterWebservices
    {
        
        /// <summary>
        /// функция адаптера сервиса shop1 к контракту приложения
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        ContractAdapterWebservices AdapterShop1(shop1 shop) 
        {


            ContractAdapterWebservices adapterWebservices = new ContractAdapterWebservices();

            adapterWebservices.ServiceName = shop.GetType().ToString();
            adapterWebservices.Name = shop.Name;
            adapterWebservices.Dimension = shop.Dimension;
            adapterWebservices.Price = shop.Price;
            adapterWebservices.Discount = shop.Discount;

            return adapterWebservices;
        }

        /// <summary>
        /// функция адаптера сервиса shop2 к контракту приложения
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        ContractAdapterWebservices AdapterShop2(shop2 shop)
        {

            ContractAdapterWebservices adapterWebservices = new ContractAdapterWebservices();

            adapterWebservices.ServiceName = shop.GetType().ToString();
            adapterWebservices.Name = shop.name;
            adapterWebservices.Dimension = shop.dimension;
            adapterWebservices.Price = shop.price;
            adapterWebservices.Discount = shop.discount;
            return adapterWebservices;
        }


        /// <summary>
        /// функция адаптера сервиса shop3 к контракту приложения
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        ContractAdapterWebservices AdapterShop3(shop3 shop)
        {

            ContractAdapterWebservices adapterWebservices = new ContractAdapterWebservices();

            adapterWebservices.ServiceName = shop.GetType().ToString();
            adapterWebservices.Name = shop.name;
            adapterWebservices.Dimension = shop.dimension;
            adapterWebservices.Price = shop.price;
            adapterWebservices.Discount = shop.discount;
            return adapterWebservices;
        }






    }
}
