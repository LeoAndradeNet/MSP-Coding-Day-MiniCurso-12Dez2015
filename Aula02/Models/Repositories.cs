using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Models
{
    public class Repositories
    {
        public static List<Artigo> articles = new List<Artigo>()
        {
            new Artigo
                {
                    Id = 1,
                    Titulo = "Asp.Net Mvc na prática!",
                    Autor = "Léo Andrade",
                    Descricao = "Texto do artigo"
                },
                new Artigo {
                    Id = 2,
                    Titulo = "Criando uma conta no Azure!",
                    Autor = "Dário Andrade",
                    Descricao = "Texto do artigo"
                },
                new Artigo {
                    Id = 3,
                    Titulo = "Como ser um Hackerzão!",
                    Autor = "Wesley Safadão",
                    Descricao = "Texto do artigo"
                },
                new Artigo {
                    Id = 4,
                    Titulo = "Aprendendo a fotografar!",
                    Autor = "Nando Reis",
                    Descricao = "Texto do artigo"
                } };


        public IEnumerable<Artigo> GetArticles()
        {
            return articles;
        }

        public void CreateArticle(Artigo article)
        {
            article.Id = (articles.LastOrDefault().Id) + 1;

            articles.Add(article);
        }

        public void EditArticle(Artigo articleNew)
        {
            var article = articles.LastOrDefault(c => c.Id == articleNew.Id);

            article.Titulo = articleNew.Titulo;
            article.Descricao = articleNew.Descricao;
            article.Autor = articleNew.Autor;
        }

        public void DeleteArticle(int id)
        {
            articles.Remove(articles.FirstOrDefault(c => c.Id == id));
        }
    }
}
