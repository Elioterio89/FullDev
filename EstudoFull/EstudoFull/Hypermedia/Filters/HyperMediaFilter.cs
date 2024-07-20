using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EstudoFull.Hypermedia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        private readonly HyperMediaFilterOptions _hyperMediaFiltersOptions;

        public HyperMediaFilter(HyperMediaFilterOptions hyperMediaFiltersOptions)
        {
            _hyperMediaFiltersOptions = hyperMediaFiltersOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
            {
                var enrincher  =_hyperMediaFiltersOptions
                    .ContentResponseEnricherList
                    .FirstOrDefault(x=>x.CanEnrich(context));

                if (enrincher != null)Task.FromResult(enrincher.Enrich(context));
            }
        }
    }
}
