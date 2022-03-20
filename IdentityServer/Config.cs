using System.Security.Claims;
using System.Text.Json;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResources.Address(),
            new IdentityResource
            {
                Name = "roles",
                DisplayName = "Role(s)",
                Description = "User-owned role(s)",
                UserClaims = { JwtClaimTypes.Role }
            }
        };

        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new("movies.api", "Movie API")
        };

        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>
        {

        };


        public static IEnumerable<Client> Clients => new List<Client>
        {
            new()
            {
                ClientId = "movies.mvc.client",
                ClientSecrets = { new("secret".Sha256()) },
                ClientName = "Movies MVC Web App",
                AllowedGrantTypes = GrantTypes.Hybrid,
                RequirePkce = false,
                AllowRememberConsent = false,
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    IdentityServerConstants.StandardScopes.Address,
                    "movies.api",
                    "roles"
                },
                RedirectUris = { "https://localhost:7002/signin-oidc" },
                PostLogoutRedirectUris = { "https://localhost:7002/signout-callback-oidc" },
            }
        };

        public static List<TestUser> TestUsers => new List<TestUser>
        {
             new TestUser
            {
                SubjectId = "818727",
                Username = "alice",
                Password = "alice",
                Claims =
                {
                    new(JwtClaimTypes.Name, "Alice Smith"),
                    new(JwtClaimTypes.GivenName, "Alice"),
                    new(JwtClaimTypes.FamilyName, "Smith"),
                    new(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new(JwtClaimTypes.WebSite, "http://alice.com"),
                    new(JwtClaimTypes.Address, JsonSerializer.Serialize(new
                    {
                        street_address = "One Hacker Way",
                        locality = "Heidelberg",
                        postal_code = 69118,
                        country = "Germany"
                    }), IdentityServerConstants.ClaimValueTypes.Json),
                    new(JwtClaimTypes.Role, "user")
                }
            },
            new TestUser
            {
                SubjectId = "88421113",
                Username = "bob",
                Password = "bob",
                Claims =
                {
                    new(JwtClaimTypes.Name, "Bob Smith"),
                    new(JwtClaimTypes.GivenName, "Bob"),
                    new(JwtClaimTypes.FamilyName, "Smith"),
                    new(JwtClaimTypes.Email, "BobSmith@email.com"),
                    new(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new(JwtClaimTypes.WebSite, "http://bob.com"),
                    new(JwtClaimTypes.Address, JsonSerializer.Serialize(new
                    {
                        street_address = "One Hacker Way",
                        locality = "Heidelberg",
                        postal_code = 69118,
                        country = "Germany"
                    }), IdentityServerConstants.ClaimValueTypes.Json),
                    new(JwtClaimTypes.Role, "admin")
                }
            }
        };
    }
}