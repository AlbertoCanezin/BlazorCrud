using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlaCrudWeb.Server.Utils
{
  public static class HttpContextExtension
  {
    public async static Task InserirParametroEmPageResponse<T>(this HttpContext context, IQueryable<T> queryable, int quantidadeTotalRegistrosAExibir)
    {
      if (context == null)
      {
        throw new ArgumentNullException(nameof(context));
      }

      double quantidadeRegistroTotal = await queryable.CountAsync();
      double totalPaginas = Math.Ceiling(quantidadeRegistroTotal / quantidadeTotalRegistrosAExibir);

      // Salvando as informações no Header do response
      context.Response.Headers.Add("quantidadeRegistroTotal", quantidadeRegistroTotal.ToString());
      context.Response.Headers.Add("totalPaginas", totalPaginas.ToString());
    }
  }
}