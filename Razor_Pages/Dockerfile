#  docker build -t cgfootman/razor_pages -f Razor_Pages/Dockerfile .
#  docker run -d -p 80:80 --name razor_pages cgfootman/razor_pages
#  docker push cgfootman/razor_pages


FROM microsoft/aspnetcore:2.0 AS base
MAINTAINER Chris Gibson "cgfootman@hotmail.com" 

WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY Razor_Pages/Razor_Pages.csproj Razor_Pages/
RUN dotnet restore
COPY . .
WORKDIR /src/Razor_Pages
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Razor_Pages.dll"]
