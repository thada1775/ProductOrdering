FROM utarn/aspnetcore3.1-centos8:latest AS builder 
WORKDIR /src
COPY ProductOrdering/ProductOrdering.csproj ProductOrdering/
RUN dotnet restore ProductOrdering/ProductOrdering.csproj
COPY . .
WORKDIR /src/ProductOrdering
RUN dotnet publish --output /app --configuration Release

FROM utarn/aspnetcore3.1-centos8:latest
WORKDIR /app
COPY --from=builder /app .
ENTRYPOINT ["dotnet", "ProductOrdering.dll"]