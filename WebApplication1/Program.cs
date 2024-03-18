var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/owais", () => "hello Owais");

app.Use(async(Context, next) =>
{
    await Context.Response.WriteAsync("I am finally # 1\n");
    await next(Context);
}
);
app.Use(async (Context, next) =>
{
    await Context.Response.WriteAsync("I am finally # 2.0\n");
    await next(Context);
}
);
app.Run(async (context) => await context.Response.WriteAsync("I Am Middle Ware # 3\n"));
app.Run();

