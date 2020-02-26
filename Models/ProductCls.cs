using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoStore.Models
{
    public class ProductCls
    {
        public int product_id { get; set; }
        public string product_title { get; set; }
        public string product_description { get; set; }
        public string product_price { get; set; }
        public string product_total { get; set; }
        public string product_discount { get; set; }
        public string product_category { get; set; }
        public string[] product_tags { get; set; }
        public string[] product_images { get; set; }
        public int product_reviews_count { get; set; }
        public string[] product_reviews { get; set; }
        public string product_options { get; set; }
        public int product_nb_sales { get; set; }
        public int product_quantity { get; set; }

    


    }
}
