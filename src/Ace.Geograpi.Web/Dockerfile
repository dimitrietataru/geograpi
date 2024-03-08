FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 43000
EXPOSE 42000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG CONFIG=Release
WORKDIR /src
COPY ["Ace.Geograpi.Web/Ace.Geograpi.Web.csproj", "Ace.Geograpi.Web/"]
RUN dotnet restore "Ace.Geograpi.Web/Ace.Geograpi.Web.csproj"
COPY . .
WORKDIR "/src/Ace.Geograpi.Web"
RUN dotnet build "Ace.Geograpi.Web.csproj" -c $CONFIG -o /app/build

FROM build AS publish
RUN dotnet publish "Ace.Geograpi.Web.csproj" -c $CONFIG -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ace.Geograpi.Web.dll"]
