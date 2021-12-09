using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoFinal.Models
{
    public class RestaurantModel
    {
        [PrimaryKey, AutoIncrement]
        public int RestaurantId { get; set; }

        [MaxLength(50)]
        public string RestaurantName { get; set; }
        
        public string Address { get; set; }

        public int ReserverCount { get; set; }
    }
}
