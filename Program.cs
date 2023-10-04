using Microsoft.EntityFrameworkCore;
using TodoApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TodoDbContext>(
   options=>{
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")
    );
   } 
);

//I DID THIS FOR YOU COS I KNOW U WILL BE USING SQLSERVER
//UNCOMMENT THE CODE BELOW. ALSO MAKE SURE YOUR CONNECTION STRING 
// IN YOUR APP  SETTINGS .JSON IS CORRECT
///////////////////////////////////////////////////////

// builder.Services.AddDbContext<TodoDbContext>(
//    options=>{
//     options.UseSqlServer(
//         builder.Configuration.GetConnectionString("DefaultConnection")
//     );
//    } 
// );

//////////////////////////////////////////////////////////////////////////



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
