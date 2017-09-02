FROM microsoft/dotnet:2-sdk
WORKDIR /integration

COPY integration.csproj .
RUN dotnet restore

COPY . .
ENV TEAMCITY_PROJECT_NAME=fake
ENTRYPOINT ["dotnet", "test"]
