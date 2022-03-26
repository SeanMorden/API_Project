#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["300490950(morden)_Project/300490950(morden)_Project.csproj", "300490950(morden)_Project/"]
COPY ["ShippingLibrary/ShippingLibrary.csproj", "ShippingLibrary/"]
RUN dotnet restore "300490950(morden)_Project/300490950(morden)_Project.csproj"
COPY . .
WORKDIR "/src/300490950(morden)_Project"
RUN dotnet build "300490950(morden)_Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "300490950(morden)_Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "300490950(morden)_Project.dll"]