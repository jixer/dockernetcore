#!/bin/bash
DTFORMAT=`date +"gsxr/hellowebapi:%m%d%Y_%H%M%S.%N"`;
docker build -t $DTFORMAT . && \
docker tag $DTFORMAT gsxr/hellowebapi:latest;

docker run -p 5000:5000 gsxr/hellowebapi;