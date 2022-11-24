using SignalRChat.hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
//inject the signalR service
builder.Services.AddSignalR();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
//maping the chathub class 
app.MapHub<ChatHub>("/chatHub");

app.Run();
