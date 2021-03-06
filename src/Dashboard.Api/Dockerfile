#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Dashboard.Api/Dashboard.Api.csproj", "src/Dashboard.Api/"]
COPY ["src/Dashboard.Data/Dashboard.Data.csproj", "src/Dashboard.Data/"]
COPY ["src/Dashboard.Business/Dashboard.Business.csproj", "src/Dashboard.Business/"]
RUN dotnet restore "src/Dashboard.Api/Dashboard.Api.csproj"
COPY . .
WORKDIR "/src/src/Dashboard.Api"
RUN dotnet build "Dashboard.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dashboard.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dashboard.Api.dll"]