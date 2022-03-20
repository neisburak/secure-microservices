using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
        {

        };

        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new("movie.api", "Movie API")
        };

        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>
        {

        };


        public static IEnumerable<Client> Clients => new List<Client>
        {
            new()
            {
                ClientId = "movie.client",
                ClientSecrets = { new("secret".Sha256())},
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AllowedScopes = { "movie.api" }
            }
        };

        public static List<TestUser> TestUsers => new List<TestUser>
        {

        };
    }
}