using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoStore.Models
{
    public class FinalProduct
    {
        public int product_id { get; set; }
        public string product_title { get; set; }
        public string product_description { get; set; }
        public string product_images { get; set; }
        public string product_category { get; set; }
        public string product_gender { get; set; }
        public string product_brand { get; set; }
        public string product_tags { get; set; }
        public double product_profit_price { get; set; }
        public double product_compare_to_price { get; set; }
        public double cost_per_item { get; set; }
        public double profit_margin { get; set; }
        public string product_barcode { get; set; }
        public string product_sku { get; set; }
        public int product_quantity { get; set; }
        public double product_wheight { get; set; }
        public double product_height { get; set; }
        public string product_carrier { get; set; }
        public string product_size { get; set; }
        public string product_colors { get; set; }

        public double profit_calcul(double cost_per_item, double profit_price)
        {
            return 100 - (cost_per_item * 100) / profit_price;

        }

    }
}
