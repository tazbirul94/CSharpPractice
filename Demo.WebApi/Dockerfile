#Build Stage

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build 
# Current working directory
WORKDIR /source  
# copy everything from the current project directory to the current working directory 
COPY . . 
# restore all the preoject dependencies
#ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT=Development 

RUN dotnet restore "Demo.WebApi.csproj"

RUN dotnet build "Demo.WebApi.csproj" -c Debug -o /app
FROM build AS publish
# all the binaries will be publishe dto the app directory
#RUN dotnet publish "Demo.WebApi.csproj" -c Release -o /app --no-restore 
RUN dotnet publish "Demo.WebApi.csproj" -c Debug -o /app --no-restore 

#Serve Stage

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
#copy everything from the build  stage to the app directory to the current working directory
COPY --from=build /app ./ 

EXPOSE 5000
# binaries which will run the dot net api
ENTRYPOINT ["dotnet", "Demo.WebApi.dll"] 

