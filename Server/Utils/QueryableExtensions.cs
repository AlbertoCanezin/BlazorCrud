using System.Linq;
using BlaCrudWeb.Shared.Resourses;

namespace BlaCrudWeb.Server.Utils
{
  public static class QueryableExtensions
  {
    public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, Paginacao paginacao)
    {
      return queryable.Skip((paginacao.Pagina - 1) * paginacao.QuantidadePorPagina).Take(paginacao.QuantidadePorPagina);
    }
  }
}