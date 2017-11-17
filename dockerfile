FROM microsoft/dotnet:2.0-runtime

EXPOSE 5000

WORKDIR /app

COPY bin/Debug/netcoreapp2.0/publish/ .

ENTRYPOINT [ "dotnet", "nancy-test-server.dll" ]