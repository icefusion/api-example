FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /

COPY ["/src/Ecommerce.Application/Ecommerce.Application.csproj", "./src/Ecommerce.Application/Ecommerce.Application.csproj"]
# RUN dotnet restore "./src/Ecommerce.Application/Ecommerce.Application.csproj"

COPY ["/src/Ecommerce.Domain/Ecommerce.Domain.csproj", "./src/Ecommerce.Domain/Ecommerce.Domain.csproj"]
# RUN dotnet restore "./src/Ecommerce.Domain/Ecommerce.Domain.csproj"

COPY ["/src/Ecommerce.Infra/Ecommerce.Infra.csproj", "./src/Ecommerce.Infra/Ecommerce.Infra.csproj"]
# RUN dotnet restore "./src/Ecommerce.Infra/Ecommerce.Infra.csproj"

COPY ["/src/Ecommerce.Web/Ecommerce.Web.csproj", "./src/Ecommerce.Web/Ecommerce.Web.csproj"]
# RUN dotnet restore "./src/Ecommerce.Web/Ecommerce.Web.csproj"

COPY ["/Ecommerce.sln", "./"]
RUN dotnet restore "./Ecommerce.sln"

COPY . .
RUN dotnet build "Ecommerce.sln" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Ecommerce.sln" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ecommerce.Web.dll"]