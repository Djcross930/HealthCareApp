FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FakeHealthcareApp.csproj", "./"]
RUN dotnet restore "FakeHealthcareApp.csproj"
COPY . .
RUN dotnet build "FakeHealthcareApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FakeHealthcareApp.csproj" -c Release -o /app/publish

FROM runtime AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FakeHealthcareApp.dll"]
