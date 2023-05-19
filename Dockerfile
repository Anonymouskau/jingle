# Start with the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory
WORKDIR /app

# Copy the solution file and restore dependencies
COPY *.sln .
COPY bol/bol.csproj ./bol/
COPY dal/dal.csproj ./dal/

COPY jingle/jingle.csproj ./jingle/
RUN dotnet restore

# Copy the remaining files and build the application
COPY . .
RUN dotnet build

# Publish the project
COPY . .
RUN dotnet build 

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime

# Set the working directory
FROM build AS publish
RUN dotnet publish jingle/jingle.csproj -c Release -o /app/publish
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app

# Copy the published output from the build stage
COPY --from=publish /app/publish .

# Expose the desired port
ENV ASPNETCORE_URLS=http://0.0.0.0:5000
EXPOSE 5000
 

# Start the application
ENTRYPOINT ["dotnet", "jingle.dll"]