FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 32769


FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Store.API/Store.API.csproj Store.API/
COPY Store.Core/Store.Core.csproj Store.Core/
RUN dotnet restore Store.API/Store.API.csproj
COPY . .
WORKDIR /src/Store.API
RUN dotnet build Store.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Store.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Store.API.dll"]