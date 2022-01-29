using EFCache;

namespace Leaderboard.Databases
{
    public class Configuration : System.Data.Entity.DbConfiguration
    {
        public Configuration()
        {
            var transactionHandler = new CacheTransactionHandler(new InMemoryCache());

            AddInterceptor(transactionHandler);

            var cachingPolicy = new CachingPolicy();

            Loaded +=
              (sender, args) => args.ReplaceService<System.Data.Entity.Core.Common.DbProviderServices>(
                (s, _) => new CachingProviderServices(s, transactionHandler, cachingPolicy));
        }
    }
}
