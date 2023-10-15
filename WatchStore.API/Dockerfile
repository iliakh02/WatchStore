FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WatchStore.WebApi/WatchStore.WebApi.csproj", "WatchStore.WebApi/"]
RUN dotnet restore "WatchStore.WebApi/WatchStore.WebApi.csproj"
COPY . .
WORKDIR "/src/WatchStore.WebApi"
RUN dotnet build "WatchStore.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WatchStore.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WatchStore.WebApi.dll"]
