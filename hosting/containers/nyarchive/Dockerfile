FROM ubuntu:18.04

RUN apt-get update \
    && apt-get install -y snapd git \
    && snap install dotnet-sdk --classic --channel=6.0 \
    && snap alias dotnet-sdk.dotnet dotnet

RUN git clone --recurse-submodules https://github.com/jeanluc162/Nyarchive \
    && cd ./Nyarchive/src/Nyarchive.Server \
    && dotnet publish

ENTRYPOINT ["dotnet", "./nyarchive/src/Nyarchive.Server/bin/publish/Nyarchive.Server.dll"]