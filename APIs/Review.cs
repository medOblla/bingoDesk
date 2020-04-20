using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using BingoStore.Models;
using Newtonsoft.Json;
namespace BingoStore.APIs
{
    class Review
    {
        private static readonly HttpClient client = new HttpClient();
        public static List<ReviewClass> Page_load()
        {
            string strurlTest = String.Format("http://127.0.0.1:8000/api/review");
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
            List<ReviewClass> objList = (List<ReviewClass>)serializer.Deserialize(strResultTest, typeof(List<ReviewClass>));
            return objList;
        }
        public static async void Reply_review(int review_id)
        {
            var response = await client.PostAsync($"http://127.0.0.1:8000/api/replayed/{review_id}", null);
            Console.WriteLine(response);
        }
        public static async void Delete_review(int review_id)
        {
            var response = await client.PostAsync($"http://127.0.0.1:8000/api/deleteReview/{review_id}", null);
            Console.WriteLine(response);
        }
    }
}
