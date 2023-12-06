using MuhasebeNET.App;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: MyAllowSpecificOrigins,
					  policy =>
					  {
						  policy.WithOrigins("http://caliskandent.com", "http://api.caliskandent.com",
											  "http://www.caliskandent.com", "https://localhost:7042")
													.AllowAnyHeader()
												  .AllowAnyMethod();
					  });
});



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserService,UserService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();
app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
	endpoints.MapPost("/api/Login/GetAllUser",async context =>
	{
		var username = context.Request.Form["usernameInput"];
		var password = context.Request.Form["passwordInput"];
	}); 
});

app.Run();
