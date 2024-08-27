#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Ilse song/Ilse song.csproj", "Ilse song/"]
RUN dotnet restore "Ilse song/Ilse song.csproj"
COPY . .
WORKDIR "/src/Ilse song"
RUN dotnet build "Ilse song.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ilse song.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ilse song.dll"]