FROM microsoft/aspnetcore-build
WORKDIR /app

COPY *.csproj .
RUN dotnet restore

COPY . .

EXPOSE 5000
ENTRYPOINT ["dotnet", "run"]
# RUN dotnet publish -o out -c Debug

