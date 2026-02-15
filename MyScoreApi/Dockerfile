# 使用 .NET 9 SDK 進行編譯
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# 複製專案檔並還原套件
COPY *.csproj ./
RUN dotnet restore

# 複製所有檔案並編譯出 Release 版本
COPY . ./
RUN dotnet publish -c Release -o out

# 使用 runtime 環境來執行
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out .

# 設定 Render 需要的埠位
ENV ASPNETCORE_URLS=http://0.0.0.0:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "MyScoreApi.dll"]