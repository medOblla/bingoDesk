using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using BingoStore.Models;

namespace BingoStore.APIs
{
    public class Product
    {
        public static List<Comments> Page_load()
        {
            string strurlTest = String.Format("https://jsonplaceholder.typicode.com/posts/1/comments");
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
            List<Comments> objList = (List<Comments>)serializer.Deserialize(strResultTest, typeof(List<Comments>));
            return objList;
          
        }

    }
}
