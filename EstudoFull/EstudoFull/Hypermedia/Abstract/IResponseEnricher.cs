using Microsoft.AspNetCore.Mvc.Filters;

namespace EstudoFull.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext pContext);
        Task Enrich(ResultExecutingContext pContext);
    }
}
