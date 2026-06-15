FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ConsoleApp7/ConsoleApp7.csproj", "ConsoleApp7/"]
RUN dotnet restore "ConsoleApp7/ConsoleApp7.csproj"
COPY . .
WORKDIR "/src/ConsoleApp7"
RUN dotnet build "./ConsoleApp7.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ConsoleApp7.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp7.dll"]
