using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ClassDish
{
    public enum KitchenName
    {
        Русская,
        Кавказская,
        Итальянская,
        Французская,
        Среднеазиатская,
        Восточная
    }
    public class Dish
    {
        public string NameOfDish { get; }
        public KitchenName Kitchen { get; set; }
        public string AboutTheDish { get; set; }

        public int Price { get; set; }
        public bool DishExistence { get; }
        public int CookingTime { get; set; }

        public Dish(string name, KitchenName kitchen, string aboutTheDish, int price, bool dishExistence, int cookingtime)
        {
            NameOfDish = name;
            Kitchen = kitchen;
            AboutTheDish = aboutTheDish;
            Price = price;
            DishExistence = dishExistence;
            CookingTime = cookingtime;


        }

        public virtual string[] GetInfo()
        {
            var info = new string[6];

            info[0] = $"Название: {NameOfDish}";
            info[1] = $"Кухня: {Kitchen}";
            info[2] = $"Описание: {AboutTheDish}";
            info[3] = $"Цена: {Price} руб.";
            info[4] = $"Наличие: {(DishExistence ? "в наличии" : "нет в наличии")}";
            info[5] = $"Время приготовления: {CookingTime} минут";

            return info;
        }
    }
 }
