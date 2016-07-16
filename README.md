# DockerNetCore Overview
Several Docker and .NET Core Samples.

Most of the source code in this repository is documented throughout my blog: [BloggedByChris.com](http://bloggedbychris.com/).

# IDE Usage
Some of these projects were built using Visual Studio 2015 and others were build using Visual Studio Code.  Most of the project created using Visual Studio 2015 can still be opened and compiled using Visual Studio Code, but the documentation will pertain to a different IDE as described in the following list:

**Visual Studio 2015**
1. StatelessValuesMicroservice
2. StatefulValuesMicroservice

**Visual Studio Code**
1. HelloWorldConsole

# Documentation
As mentioned previously, most of the source code in this repository is documented throughout my blog: [BloggedByChris.com](http://bloggedbychris.com/).  This section will mainly be used to reference individual blog posts, but in some cases, full documentation of the project is container herein.

## StatelessValuesMicroservice
*(NOTE: Created using Visual Studio 2015)*

Used the out-of-the box VisualStudio .NET Core WebAPI project template and then added Docker support.

See the following blog post for information: http://www.bloggedbychris.com/2016/05/24/setup-visual-studio-net-docker-windows-hour/

## StatefulValuesMicroservice
*(NOTE: Created using Visual Studio 2015)*

Built on the StatelessValuesMicroservice example and added a linked postgres container in order to make the previous example stateful

See the following blog post for information: http://www.bloggedbychris.com/2016/07/12/stateful-microservice-net-core-docker-postresql/

## HelloWorldConsole
*(NOTE: Created using Visual Studio Code)*

Basic example of a console app that can be ran within a Docker contaner.

**Linux and/or Mac users:** 

Once you're in the root of the "HelloWorldConsole" directory, you can use `./build.sh` to compile, create the container, and execute the image in a temporary container.