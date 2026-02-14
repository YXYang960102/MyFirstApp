// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// using System;

// // var name = "jeremy";
// // int age = 19;
// // Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
// // Console.WriteLine($"I'm a student!");

// // Console.WriteLine("What is your name?");
// // var userName = Console.ReadLine();
// // Console.WriteLine($"Hello, {userName}! Nice to meet you.");

// // Console.WriteLine("What is your age?");
// // var userAgeInput = Console.ReadLine();
// // int userAge = int.Parse(userAgeInput);
// // Console.WriteLine($"You are {userAge} years old.");
// Console.WriteLine("--- BMI Calculator ---");

// Console.Write("Enter your weight in kilograms: ");
// double weightInput = double.Parse(Console.ReadLine());

// Console.Write("Enter your height in centimeters: ");
// double heightCm = double.Parse(Console.ReadLine());
// double heightInput = heightCm / 100; // Convert cm to meters
// double bmi = weightInput / (heightInput * heightInput);
// Console.WriteLine($"Your BMI is: {bmi:F2}");
// if (bmi < 18.5)
// {
//     Console.WriteLine("You are underweight.");
// }
// else if (bmi >= 18.5 && bmi < 24.9)
// {
//     Console.WriteLine("You have a normal weight.");
// }
// else if (bmi >= 25 && bmi < 29.9)
// {
//     Console.WriteLine("You are overweight.");
// }
// else
// {
//     Console.WriteLine("You are obese.");
// }
using System;

// 1. 產生隨機數
Random random = new Random();
int targetNumber = random.Next(1, 101); // 產生 1 到 100 的隨機整數
int guess = 0; // 儲存玩家猜的數字
int count = 0; // 計算猜了幾次

Console.WriteLine("=== 歡迎來到猜數字遊戲 (1-100) ===");

// 2. 使用迴圈讓玩家反覆猜測，直到猜中為止
while (guess != targetNumber)
{
    Console.Write("請輸入你猜的數字：");
    string input = Console.ReadLine();

    // 簡單防呆：確保輸入的是數字
    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("❌ 請輸入有效的整數數字！");
        continue;
    }

    count++; // 每猜一次就加 1

    // 3. 判斷邏輯
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
