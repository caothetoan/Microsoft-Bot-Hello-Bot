using System;
using System.Collections.Generic;

namespace HelloBot.Models
{
    [Serializable]
    public class OrderModel
    {
        public MultimediaEquipment Multimedia;
        public String Name;
        public String Email;
        public String Phone;
        public int Quantity;
        public TableChoice TableChoice;
        public TableModel Model;
        public RestaurantModel Restaurant;

        public List<MenuModel> Menus;
    }

    public enum TableChoice
    {
        Inside,
        Outdoor,
        VIP
    }
    
    public enum TableModel
    {
        Ten = 10,
        Elevent = 11,
        Twelve = 12
    }
    
    [Serializable]
    public class MenuModel
    {
        public String Name;
        
    }
    [Serializable]
    public class RestaurantModel
    {
        public String RestaurantName;
        
    }
}