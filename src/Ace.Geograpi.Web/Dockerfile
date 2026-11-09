FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG CONFIG=Release
WORKDIR /src
COPY ["Directory.Build.props", "./"]
COPY ["Ace.Geograpi.Domain/Ace.Geograpi.Domain.csproj", "Ace.Geograpi.Domain/"]
COPY ["Ace.Geograpi.Application/Ace.Geograpi.Application.csproj", "Ace.Geograpi.Application/"]
COPY ["Ace.Geograpi.Infrastructure/Ace.Geograpi.Infrastructure.csproj", "Ace.Geograpi.Infrastructure/"]
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
