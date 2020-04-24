using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoStore.Models
{
    public class FinalProduct
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string product_images { get; set; }
        public string category_id { get; set; }
        public int nb_sales { get; set; }
        public string product_gender { get; set; }
        public string product_brand { get; set; }
        public string product_tags { get; set; }
        public double price { get; set; }
        public double old_price { get; set; }
        public double cost_per_item { get; set; }
        public double profit_margin { get; set; }
        public string product_barcode { get; set; }
        public string product_sku { get; set; }
        public int product_quantity { get; set; }
        public double product_weight { get; set; }
        public double product_height { get; set; }
        public string product_carrier { get; set; }
        public double product_size { get; set; }
        public string product_colors { get; set; }
        public string local { get; set; }

        public static double profit_calcul(double cost_per_item, double profit_price)
        {
            return 100 - (cost_per_item * 100) / profit_price;

        }

    }
}
