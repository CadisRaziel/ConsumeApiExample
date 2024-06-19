using Src.Entities;
using Src.Service;

namespace Src
{
    class Program
    {
       public static async Task Main(string[] args)
        {
            Console.WriteLine("Informe o id: ");
            int commnetId = int.Parse(Console.ReadLine());

            CommentService commentService = new CommentService();

            Comments comments = await commentService.Integration(commnetId);

            if(!comments.Validation)
            {
                Console.WriteLine("Comentario Id: " + comments.id);
                Console.WriteLine("Comentario Name: " + comments.name);
                Console.WriteLine("Comentario Email: " + comments.email);
                Console.WriteLine("Comentario Body: " + comments.body);                
            } else
            {
                Console.WriteLine("Comentario nao encontrado");
            }
        }
    }
}