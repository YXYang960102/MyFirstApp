using System;


Random random = new Random();
int targetNumber = random.Next(1, 201);
int guess = 0; 
int count = 0; 

Console.WriteLine("=== 歡迎來到猜數字遊戲 (1-200) ===");


while (guess != targetNumber)
{
    Console.Write("請輸入你猜的數字：");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("❌ 請輸入有效的整數數字！");
        continue;
    }

    count++;

 
    if (guess > targetNumber)
    {
        Console.WriteLine("📉 太大了！再小一點。");
    }
    else if (guess < targetNumber)
    {
        Console.WriteLine("📈 太小了！再大一點。");
    }
    else
    {
        Console.WriteLine($"🎉 恭喜答對！答案就是 {targetNumber}。");
        Console.WriteLine($"你總共猜了 {count} 次。");
    }
}
