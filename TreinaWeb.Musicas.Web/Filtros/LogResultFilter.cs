using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreinaWeb.Musicas.Web.Filtros
{
    public class LogResultFilter : FilterAttributes, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var parametroUm = DateTime.Now.ToString();
            var parametroDois = filterContext.RouteData.Values["Controller"].ToString();
            var parametroTres = filterContext.RouteData.Values["Action"].ToString();
            var parametroQuatro = filterContext.Result.ToString();

            string mensagem = string.Format("[{0}[ Finalizou: {1}/{2} | {3}",
                                            parametroUm, parametroDois, parametroTres, parametroQuatro);
            Debug.WriteLine(mensagem);
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string mensagem = string.Format("[{0}[ Processando resultados: {1}/{2}",
                                               DateTime.Now.ToString(),
                                               filterContext.RouteData.Values["Controller"].ToString(),
                                               filterContext.RouteData.Values["Action"].ToString());
            Debug.WriteLine(mensagem);
        }
    }
}