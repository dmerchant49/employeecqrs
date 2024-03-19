FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
COPY . /src
WORKDIR /src
RUN ls
RUN dotnet build "EmployeeApi/EmployeeApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeeApi/EmployeeApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "EmployeeApi.dll","--environment=Development"]