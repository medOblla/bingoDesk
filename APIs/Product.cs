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
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(strResultTest);
            Console.WriteLine("------------------------------------------");
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<FinalProduct> objList = (List<FinalProduct>)serializer.Deserialize(strResultTest, typeof(List<FinalProduct>));
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach(FinalProduct prod in objList)
            {
                Console.WriteLine("////////////////////////////////////////");
                Console.WriteLine(prod.title);
                Console.WriteLine(prod.description);
                Console.WriteLine(prod.product_images);
                Console.WriteLine(prod.category_id);
                Console.WriteLine(prod.product_gender);
                Console.WriteLine(prod.product_brand);
                Console.WriteLine(prod.product_tags);
                Console.WriteLine(prod.price);
                Console.WriteLine(prod.old_price);
                Console.WriteLine(prod.cost_per_item);
                Console.WriteLine(prod.profit_margin);
                Console.WriteLine(prod.product_barcode);
                Console.WriteLine(prod.product_sku);
                Console.WriteLine(prod.product_quantity);
                Console.WriteLine(prod.product_weight);
                Console.WriteLine(prod.product_height);
                Console.WriteLine(prod.product_carrier);
                Console.WriteLine(prod.product_size);
                Console.WriteLine(prod.product_colors);
      

            }
            Console.WriteLine("------------------------------------------");
            //List<FinalProduct> ObjOrderList = new List<FinalProduct>();
            //ObjOrderList = JsonConvert.DeserializeObject<List<FinalProduct>>(strResultTest);
            return objList;
        }

        public static Statistics Get_Stats()
        {
            string strurlTest = String.Format("http://127.0.0.1:8000/api/nbproducts");
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
            Statistics stats = (Statistics)serializer.Deserialize(strResultTest, typeof(Statistics));
           
            return stats;
        }
        public static List<Category> Categories()
        {
            string strurlTest = String.Format("http://127.0.0.1:8000/api/allcategories");
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
            Console.WriteLine(strResultTest);
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Category> cates = (List<Category>)serializer.Deserialize(strResultTest, typeof(List<Category>));
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(cates.Count());
            return cates;
        }
        public static async void Add_Product(FinalProduct product)
        {
            var updated_values = new Dictionary<string, string>
            {
                {"product_title", product.title },
                {"product_description", product.description },
                {"product_images", product.product_images},
                {"product_category", product.category_id.ToString() },
                {"product_gender", product.product_gender},
                {"product_brand", product.product_brand},
                {"product_tags", product.product_tags},
                {"product_profit_price", product.price.ToString()},
                {"product_compare_to_price", product.old_price.ToString()},
                {"cost_per_item", product.cost_per_item.ToString()},
                {"product_profit_margin", product.profit_calcul(product.cost_per_item,product.price).ToString()},
                {"product_barcode", product.product_barcode},
                {"product_sku", product.product_sku},
                {"product_quantity", product.product_quantity.ToString()},
                {"product_wheight", product.product_weight.ToString()},
                {"product_height", product.product_height.ToString()},
                {"product_carrier", product.product_carrier},
                {"product_size", product.product_size},
                {"product_colors", product.product_colors}
            };
            Console.WriteLine(product.title);
            Console.WriteLine(product.description);
            Console.WriteLine(product.product_images);
            Console.WriteLine(product.category_id);
            Console.WriteLine(product.product_gender);
            Console.WriteLine(product.product_brand);
            Console.WriteLine(product.product_tags);
            Console.WriteLine(product.price.ToString());
            Console.WriteLine(product.old_price.ToString());
            Console.WriteLine(product.cost_per_item.ToString());
            Console.WriteLine(product.profit_calcul(product.cost_per_item, product.price).ToString());
            Console.WriteLine(product.product_barcode);
            Console.WriteLine(product.product_sku);
            Console.WriteLine(product.product_quantity.ToString());
            Console.WriteLine(product.product_weight.ToString());
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
            Console.WriteLine(response);
        }

        public static async void Edit_product(FinalProduct product)
        {
            var updated_values = new Dictionary<string, string>
            {
                {"product_title", product.title },
                {"product_description", product.description },
                {"product_images", product.product_images },
                {"product_category", product.category_id.ToString() },
                {"gender", product.product_gender},
                {"product_brand", product.product_brand},
                {"product_tags", product.product_tags},
                {"product_profit_price", product.price.ToString()},
                {"product_compare_to_price", product.old_price.ToString()},
                {"cost_per_item", product.cost_per_item.ToString()},
                {"product_profit_margin", product.profit_calcul(product.cost_per_item,product.price).ToString()},
                {"product_barcode", product.product_barcode},
                {"product_sku", product.product_sku},
                {"product_quantity", product.product_quantity.ToString()},
                {"product_wheight", product.product_weight.ToString()},
                {"product_height", product.product_height.ToString()},
                {"product_carrier", product.product_carrier},
                {"product_size", product.product_size},
                {"product_colors", product.product_colors}
            };
            var content = new FormUrlEncodedContent(updated_values);
            var response = await client.PostAsync($"http://127.0.0.1:8000/api/editProduct/{product.id}", content);
            
        }

    }
}
