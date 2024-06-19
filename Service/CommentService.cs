
using Newtonsoft.Json;
using Src.Entities;

namespace Src.Service
{
    public class CommentService
    {
        public async Task<Comments> Integration(int commentId)
        {

            ///Pegando a url que desejo consumir
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://jsonplaceholder.typicode.com/comments/{commentId}");

            ///Transformando a requisicao em string
            var jsonString = await response.Content.ReadAsStringAsync();

            ///Transformar o json em objeto (JsonConvert e um package)
            var jsonObject = JsonConvert.DeserializeObject<Comments>(jsonString);

            if (jsonObject != null) {
                return jsonObject;
            } else
            {
                return new Comments()
                {
                    Validation = true
                };
            }
        }

    }
}
