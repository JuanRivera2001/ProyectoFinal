using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoFinal.Models
{
    public class RestaurantModel
    {
        //Model for Restaurants
        [PrimaryKey, AutoIncrement]
        public int RestaurantId { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        [MaxLength(50)]
        public string RestaurantName { get; set; }
        
        public string Address { get; set; }

    }
}
