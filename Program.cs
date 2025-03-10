using KindergartenArtScoreAPI.Data;  // 請根據您的專案調整命名空間
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;    // 加入這行命名空間宣告

var builder = WebApplication.CreateBuilder(args);

// **步驟 1: 加入 CORS 服務**
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", // 你可以給這個策略命名
        policy =>
        {
            policy.WithOrigins("http://localhost:5173") // 允許來自這個來源的請求
                   .AllowAnyHeader() // 允許任何 HTTP 標頭
                   .AllowAnyMethod(); // 允許任何 HTTP 方法 (GET, POST, PUT, DELETE 等)
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<StudentDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=KindergartenArtScore.db"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 配置 Web 主機
app.Urls.Add("http://localhost:5000");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles(); // 添加這行來啟用靜態檔案服務

// **步驟 2: 使用 CORS 中介軟體 (確保順序正確)**
app.UseCors("AllowSpecificOrigin"); // 應用名為 "AllowSpecificOrigin" 的策略

app.UseAuthorization();

app.MapControllers();

app.Run();
