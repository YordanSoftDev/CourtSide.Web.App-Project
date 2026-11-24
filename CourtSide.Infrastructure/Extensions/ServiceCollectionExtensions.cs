namespace CourtSide.Infrastructure.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;

    using CourtSide.Data.Repository.Common;
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterRepositoriesFromAssembly(this IServiceCollection serviceCollection, Assembly repositoryAssembly)
        {
            IEnumerable<Type> repositoryImplTypes = repositoryAssembly
                .GetTypes()
                .Where(t => t.BaseType != null &&
                            t.BaseType.IsGenericType &&
                            t.IsAbstract == false &&
                            (t.BaseType.GetGenericTypeDefinition() == typeof(BaseRepository<>) ||
                             t.BaseType.GetGenericTypeDefinition() == typeof(BaseSoftDeleteableRepository<>)))
                .ToArray();

            foreach (Type repositoryImplType in repositoryImplTypes)
            {
                Type? interfaceType = repositoryImplType
                    .GetInterfaces()
                    .SingleOrDefault(it => !it.IsGenericType &&
                                           (it.GetInterfaces().Any(bit => bit.IsGenericType &&
                                                                          (bit.GetGenericTypeDefinition() == typeof(IRepository<>) ||
                                                                           bit.GetGenericTypeDefinition() == typeof(ISoftDeleteableRepository<>)))));
                if (interfaceType != null)
                {
                    serviceCollection.AddScoped(interfaceType, repositoryImplType);
                }
            }

            return serviceCollection;
        }
    }
}
