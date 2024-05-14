// please make file to fetch api
// Path: test/home.cs
//Compare this snippet from test/configs/config.cs:
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using test.Models;

namespace fetch.api {
    class getApi {


        public static async Task<List<Forum>> GetApi()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Forum> forum = JsonConvert.DeserializeObject<List<Forum>>(responseBody);
            return forum;
        }
    }  
};


