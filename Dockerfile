#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BookShare.Api/BookShare.Api.csproj", "BookShare.Api/"]
COPY ["BookShare.Application/BookShare.Application.csproj", "BookShare.Application/"]
COPY ["BookShare.Infrastructure/BookShare.Infrastructure.csproj", "BookShare.Infrastructure/"]
COPY ["BookShare.Common/BookShare.Common.csproj", "BookShare.Common/"]
COPY ["BookShare.Domain/BookShare.Domain.csproj", "BookShare.Domain/"]
RUN dotnet restore "BookShare.Api/BookShare.Api.csproj"
COPY . .
WORKDIR "/src/BookShare.Api"
RUN dotnet build "BookShare.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BookShare.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BookShare.Api.dll"]