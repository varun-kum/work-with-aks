FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["SampleAKSApp.csproj", ""]
RUN dotnet restore "./SampleAKSApp.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "SampleAKSApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleAKSApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleAKSApp.dll"]