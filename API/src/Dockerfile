#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API/src/DigiVisio2030.API.csproj", "API/src/"]
COPY ["BL/src/DigiVisio2030.BL.csproj", "BL/src/"]
COPY ["DA/src/DigiVisio2030.DA.csproj", "DA/src/"]
RUN dotnet restore "API/src/DigiVisio2030.API.csproj"
COPY . .
WORKDIR "/src/API/src"
RUN dotnet build "DigiVisio2030.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigiVisio2030.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY API/src/DigiVisio2030.API.https.pfx .
ENTRYPOINT ["dotnet", "DigiVisio2030.API.dll"]
