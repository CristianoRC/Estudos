#Gera a imagem de build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

#Copia os arquivos da pasta atual para a pasta /app do container
COPY . . 
RUN dotnet restore
RUN dotnet publish -c Release -o release

# Gerando a imagem de produção
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app

#Cipia os arquivos do container de build para a pasta do release do container de produção
COPY --from=build /app/release/ ./
ENTRYPOINT ["dotnet", "GerarImagem.dll"]

LABEL manteiner="Cristiano Raffi Cunha <contato@cristianoprogramador.com>"