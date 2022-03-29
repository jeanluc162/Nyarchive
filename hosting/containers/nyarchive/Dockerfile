FROM ubuntu:18.04

ADD https://dot.net/v1/dotnet-install.sh ./

RUN apt-get update \
    && apt-get install -y git curl libc6 libgcc1 libgssapi-krb5-2 libicu60 libssl1.1 libstdc++6 zlib1g

RUN chmod +x ./dotnet-install.sh \
    && ./dotnet-install.sh -c 6.0 --install-dir /opt/dotnet

RUN git clone --recurse-submodules https://github.com/jeanluc162/Nyarchive /opt/nyarchive \
    && cd /opt/nyarchive/src/Nyarchive.Server \
    && /opt/dotnet/dotnet publish -c Release

ENTRYPOINT ["/opt/dotnet/dotnet", "/opt/nyarchive/src/Nyarchive.Server/bin/Release/net6.0/publish/Nyarchive.Server.dll"]