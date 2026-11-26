namespace CourtSide.Infrastructure.Extensions
{
    using System.Reflection;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts.Common;
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
                            (bit.GetGenericTypeDefinition() == typeof(IRepository<>) ||                                       bit.GetGenericTypeDefinition() == typeof(ISoftDeleteableRepository<>)))));
                if (interfaceType != null)
                {
                    serviceCollection.AddScoped(interfaceType, repositoryImplType);
                }
            }

            return serviceCollection;
        }

        public static void ConfigureIdentityOptions(IConfiguration configuration, IdentityOptions options)
        {
            options.SignIn.RequireConfirmedAccount = configuration
                .GetValue<bool>("IdentitySettings:SignIn:RequireConfirmedAccount");

            options.Password.RequireDigit = configuration
                .GetValue<bool>("IdentitySettings:Password:RequireDigit");
            options.Password.RequireLowercase = configuration
                .GetValue<bool>("IdentitySettings:Password:RequireLowercase");
            options.Password.RequireUppercase = configuration
                .GetValue<bool>("IdentitySettings:Password:RequireUppercase");
            options.Password.RequireNonAlphanumeric = configuration
                .GetValue<bool>("IdentitySettings:Password:RequireNonAlphanumeric");
            options.Password.RequiredLength = configuration
                .GetValue<int>("IdentitySettings:Password:RequiredLength");
            options.Password.RequiredUniqueChars = configuration
                .GetValue<int>("IdentitySettings:Password:RequiredUniqueChars");

            options.User.RequireUniqueEmail = configuration
                .GetValue<bool>("IdentitySettings:User:RequireUniqueEmail");
        }
    }
}
