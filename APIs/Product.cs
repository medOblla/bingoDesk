using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using BingoStore.Models;
using Newtonsoft.Json;

namespace BingoStore.APIs
{
    public class Product
    {
        private static readonly HttpClient client = new HttpClient();
        public static List<FinalProduct> Page_load()
        {
            string strurlTest = String.Format("http://127.0.0.1:8000/api/allproducts");
            WebRequest requestObjGet = WebRequest.Create(strurlTest);
            requestObjGet.Method = "GET";
            HttpWebResponse responsObjGet = null;
            responsObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string strResultTest = null;
            using (Stream stream = responsObjGet.GetResponseStream())
            {
                StreamReader streamReader = new StreamReader(stream);
                strResultTest = streamReader.ReadToEnd();
                streamReader.Close();
            }
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<FinalProduct> objList = (List<FinalProduct>)serializer.Deserialize(strResultTest, typeof(List<FinalProduct>));
            return objList;
        }

        public static async void Add_Product(FinalProduct product)
        {
            var updated_values = new Dictionary<string, string>
            {
                {"product_title", product.product_title },
                {"product_description", product.product_description },
                {"product_images", product.product_images},
                {"product_category", product.product_category },
                {"gender", product.product_gender},
                {"product_brand", product.product_brand},
                {"product_tags", product.product_tags},
                {"product_profit_price", product.product_profit_price.ToString()},
                {"product_compare_to_price", product.product_compare_to_price.ToString()},
                {"cost_per_item", product.cost_per_item.ToString()},
                {"product_profit_margin", product.profit_calcul(product.cost_per_item,product.product_profit_price).ToString()},
                {"product_barcode", product.product_barcode},
                {"product_sku", product.product_sku},
                {"product_quantity", product.product_quantity.ToString()},
                {"product_wheight", product.product_wheight.ToString()},
                {"product_height", product.product_height.ToString()},
                {"product_carrier", product.product_carrier},
                {"product_size", product.product_size},
                {"product_colors", product.product_colors}
            };
            Console.WriteLine(product.product_title);
            Console.WriteLine(product.product_description);
            Console.WriteLine(product.product_images);
            Console.WriteLine(product.product_category);
            Console.WriteLine(product.product_gender);
            Console.WriteLine(product.product_brand);
            Console.WriteLine(product.product_tags);
            Console.WriteLine(product.product_profit_price.ToString());
            Console.WriteLine(product.product_compare_to_price.ToString());
            Console.WriteLine(product.cost_per_item.ToString());
            Console.WriteLine(product.profit_calcul(product.cost_per_item, product.product_profit_price).ToString());
            Console.WriteLine(product.product_barcode);
            Console.WriteLine(product.product_sku);
            Console.WriteLine(product.product_quantity.ToString());
            Console.WriteLine(product.product_wheight.ToString());
            Console.WriteLine(product.product_height.ToString());
            Console.WriteLine(product.product_carrier);
            Console.WriteLine(product.product_size);
            Console.WriteLine(product.product_colors);
            var content = new FormUrlEncodedContent(updated_values);
            var response = await client.PostAsync("http://127.0.0.1:8000/api/addProduct", content);
            Console.WriteLine(JsonConvert.SerializeObject(content));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(response);
            Console.WriteLine("----------------------------------------------");

        }

        public static async void Hide_product(int product_id)
        {
            var response = await client.PostAsync($"http://127.0.0.1:8000/api/hideProduct/{product_id}",null);
        }

        public static async void Delete_product(int product_id)
        {
            var response = await client.PostAsync($"http://127.0.0.1:8000/api/deleteProduct/{product_id}", null);
        }

        public static async void Edit_product(FinalProduct product)
        {
            var updated_values = new Dictionary<string, string>
            {
                {"product_title", product.product_title },
                {"product_description", product.product_description },
                {"product_images", product.product_images },
                {"product_category", product.product_category },
                {"gender", product.product_gender},
                {"product_brand", product.product_brand},
                {"product_tags", product.product_tags},
                {"product_profit_price", product.product_profit_price.ToString()},
                {"product_compare_to_price", product.product_compare_to_price.ToString()},
                {"cost_per_item", product.cost_per_item.ToString()},
                {"product_profit_margin", product.profit_calcul(product.cost_per_item,product.product_profit_price).ToString()},
                {"product_barcode", product.product_barcode},
                {"product_sku", product.product_sku},
                {"product_quantity", product.product_quantity.ToString()},
                {"product_wheight", product.product_wheight.ToString()},
                {"product_height", product.product_height.ToString()},
                {"product_carrier", product.product_carrier},
                {"product_size", product.product_size},
                {"product_colors", product.product_colors}
            };
            var content = new FormUrlEncodedContent(updated_values);
            var response = await client.PostAsync($"http://127.0.0.1:8000/api/editProduct/{product.product_id}", content);
            
        }

    }
}
