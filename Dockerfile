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
RUN mkdir -p /app/wwwroot/wkhtml && cp /usr/local/bin/wkhtmltopdf /app/wwwroot/wkhtml/wkhtmltopdf && chmod +x /app/wwwroot/wkhtml/wkhtmltopdf
ENTRYPOINT ["dotnet", "ProductOrdering.dll"]