using MyFirstApp; // 引用你的 Calculator 類別

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

// 讓 API 支援讀取 index.html 檔案
app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// 當網頁按下「停止並計算」按鈕時，會呼叫這個 API
app.MapPost("/calculate", (List<int> scores) =>
{
    if (scores == null || scores.Count == 0)
        return Results.BadRequest("No scores provided.");

    // 呼叫你原本寫好的大腦
    double average = Calculator.GetAverage(scores);
    int max = Calculator.GetMax(scores);

    // 把結果打包成 JSON 回傳給網頁
    return Results.Ok(new { 
        avgScore = average, 
        highestScore = max, 
        totalCount = scores.Count 
    });
});

app.Run();