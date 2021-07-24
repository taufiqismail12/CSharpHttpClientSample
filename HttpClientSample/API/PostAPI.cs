using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using HttpClientSample.DataModel;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace HttpClientSample.API
{

    public class PostAPI
    {
        static string URL = "https://jsonplaceholder.typicode.com/posts";
        private static readonly HttpClient client = new HttpClient();
        public static async Task<Post> GetSinglePost(string ID)
        {
            Post post = new Post();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Http Client App Sample");

            var response = await client.GetStreamAsync($"{URL}/{ID}");
            var serializer = new DataContractJsonSerializer(typeof(Post));
            post = (Post)serializer.ReadObject(response);

            return post;
        }


        public static async Task<List<Post>> GetAllPost()
        {
            List<Post> post = new List<Post>();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Http Client App Sample");

            var response = await client.GetStreamAsync($"{URL}");
            var serializer = new DataContractJsonSerializer(typeof(List<Post>));
            post = (List<Post>)serializer.ReadObject(response);

            return post;
        }

    }


}
