using IdentityServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
.AddInMemoryApiScopes(Config.ApiScopes)
.AddInMemoryIdentityResources(Config.IdentityResources)
.AddInMemoryApiResources(Config.ApiResources)
.AddInMemoryClients(Config.Clients)
.AddTestUsers(Config.TestUsers)
.AddDeveloperSigningCredential();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseIdentityServer();

app.Run();
