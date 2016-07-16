#!/bin/bash
dotnet restore;
dotnet build -c "Release";

DTFORMAT=`date +"gsxr/helloworldconsole:%m%d%Y_%H%M%S.%N"`;
docker build -t $DTFORMAT . && \
docker tag $DTFORMAT gsxr/helloworldconsole:latest;

docker run --rm gsxr/helloworldconsole;