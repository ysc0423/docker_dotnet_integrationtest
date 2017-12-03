FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o publish

# Build runtime image
FROM microsoft/aspnetcore:2.0
Expose 80
WORKDIR /app
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "jenkin_test.dll"]
