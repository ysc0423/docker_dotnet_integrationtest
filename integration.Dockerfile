FROM microsoft/aspnetcore-build:2.0 AS build-env

# Copy csproj and restore as distinct layers
COPY . /app
WORKDIR /app/integration_test
RUN dotnet restore

ENTRYPOINT ["dotnet", "test"]


#docker run --net=host -it integrationtest
