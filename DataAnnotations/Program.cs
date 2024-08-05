using DataAnnotationsStudyProject.Data;
using DataAnnotationsStudyProject.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new DataContext())
        {
            ///// Cria um novo User, Category e Post
            // var user = new User
            // {
            //     Name = "André Baltieri",
            //     Slug = "andrebaltieri",
            //     Email = "andre@balta.io",
            //     Bio = "9x Microsoft MVP",
            //     Image = "https://balta.io",
            //     PasswordHash = "123098457"
            // };
            //
            // var category = new Category {Name = "Backend", Slug = "backend"};
            //
            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };
            //
            // context.Posts.Add(post); // Não adicionei autor nem categoria
            // context.SaveChanges();

            // Realiza um update através de um dado que foi obtido do banco
            // var post = context
            //     .Posts
            //     // .AsNoTracking() PRECISA DO TRACKING 
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderBy(x => x.LastUpdateDate)
            //     .FirstOrDefault(); // Pegando o primeiro item
            //
            // post.Author.Name = "Uncle Bob";
            //
            // context.Posts.Update(post);
            // context.SaveChanges();

            ///// Retorna uma lista de Posts existente no banco e exibe para o usuário
            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderBy(x => x.LastUpdateDate)
            //     .ToList();
            //
            // foreach (var post in posts) 
            //     Console.WriteLine($"{post.Title} por {post.Author.Name} em {post.Category.Name}");


            ///// Exclui um usuário através do Id
            // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

            // context.Remove(tag);
            // context.SaveChanges();

            ///// Realiza o update em uma TAG existente que fora buscada pelo Id
            // var tag = context
            //     .Tags
            //     .AsNoTracking() // REMOVER
            //     .FirstOrDefault(x => x.Id == 3);

            // tag.Name = "Ponto NET";
            // tag.Slug = "dotnet";

            // context.Update(tag);
            // context.SaveChanges();

            ///// Retorna uma Tag
            // var tag = context
            //     .Tags
            //     .AsNoTracking()
            //     .FirstOrDefault(x => x.Id == 3);

            // Console.WriteLine(tag?.Name);
        }
    }
}