using MyFirstApp; // 引用你的 Calculator 類別

var builder = WebApplication.CreateBuilder(args);

// --- 加入這段：允許所有人存取 API ---
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
// --------------------------------

// builder.Services.AddOpenApi();
var app = builder.Build();

app.UseCors(); // 啟用 CORS
app.UseDefaultFiles();
app.UseStaticFiles();

// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

app.UseHttpsRedirection();

// --- API 定義開始 ---

app.MapPost("/calculate", (List<ScoreEntry> entries) =>
{
    if (entries == null || entries.Count == 0)
        return Results.BadRequest("No data provided.");

    // 將物件清單轉為純分數清單
    var scores = entries.Select(e => e.Score).ToList();
    
    double average = Calculator.GetAverage(scores);
    int max = Calculator.GetMax(scores);
    
    // 計算及格率
    int passCount = scores.Count(s => s >= 60);
    double passRate = (double)passCount / scores.Count * 100;

    return Results.Ok(new { 
        avgScore = average, 
        highestScore = max, 
        totalCount = scores.Count,
        passRate = passRate 
    });
});

// --- API 定義結束 ---

app.Run();

// --- 關鍵修正：將 Record 定義放在檔案最後面，避免 CS8803 錯誤 ---
public record ScoreEntry(string Subject, int Score);