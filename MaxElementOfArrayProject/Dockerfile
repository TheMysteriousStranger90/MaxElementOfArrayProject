FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MaxElementOfArrayProject/MaxElementOfArrayProject.csproj", "MaxElementOfArrayProject/"]
RUN dotnet restore "MaxElementOfArrayProject/MaxElementOfArrayProject.csproj"
COPY . .
WORKDIR "/src/MaxElementOfArrayProject"
RUN dotnet build "MaxElementOfArrayProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MaxElementOfArrayProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MaxElementOfArrayProject.dll"]
