using FastEndpoints;
using FastEndpoints.Swagger;
using System.Text.Json.Serialization; //add this

WebApplicationBuilder bld = WebApplication.CreateBuilder();
bld.Services
   .AddFastEndpoints()
   .SwaggerDocument(o =>
   {
       o.SerializerSettings = s =>
       {
           s.PropertyNamingPolicy = null;
           s.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
       };
   }); //define a swagger document

WebApplication app = bld.Build();
app.UseFastEndpoints(c => c.Serializer.Options.Converters.Add(new JsonStringEnumConverter()))
   .UseSwaggerGen(); //add this
app.Run();
