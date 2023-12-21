FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /src
COPY . .
WORKDIR /src/DarkShop.Ecommerce.Services.WebApi
Run dotnet restore
Run dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build-env /src/DarkShop.Ecommerce.Services.WebApi/out ./

ENTRYPOINT ["dotnet","DarkShop.Ecommerce.Services.WebApi.dll"]