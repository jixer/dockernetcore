# DockerNetCore Overview
Several Docker and .NET Core Samples.

Most of the source code in this repository is documented throughout my blog: [BloggedByChris.com](http://bloggedbychris.com/).

# IDE Usage
Some of these projects were built using Visual Studio 2015 and others were build using Visual Studio Code.  Most of the project created using Visual Studio 2015 can still be opened and compiled using Visual Studio Code, but the documentation will pertain to a different IDE as described in the following list:

**Visual Studio 2015**
1. [StatelessValuesMicroservice](#statelessvaluesmicroservice)
2. [StatefulValuesMicroservice](#statefulvaluesmicroservice)

**VS Code**
1. [HelloWorldConsole](#helloworldconsole)
2. [HelloWebApi](#hellowebapi)
3. [VSCodeDebugging](#vscodedebugging)
4. [VSCodeMvcDebugging](#vscodemvcdebugging)

# Documentation
As mentioned previously, most of the source code in this repository is documented throughout my blog: [BloggedByChris.com](http://bloggedbychris.com/).  This section will mainly be used to reference individual blog posts, but in some cases, full documentation of the project is container herein.

## StatelessValuesMicroservice
> NOTE: Created using Visual Studio 2015

> SOURCE: [samples/StatelessValuesMicroservice](./samples/StatelessValuesMicroservice)

Used the out-of-the box VisualStudio .NET Core WebAPI project template and then added Docker support.

See the following blog post for information: http://www.bloggedbychris.com/2016/05/24/setup-visual-studio-net-docker-windows-hour/

## StatefulValuesMicroservice
> NOTE: Created using Visual Studio 2015

> SOURCE: [samples/StatefulValuesMicroservice](./samples/StatefulValuesMicroservice)

Built on the StatelessValuesMicroservice example and added a linked postgres container in order to make the previous example stateful

See the following blog post for information: http://www.bloggedbychris.com/2016/07/12/stateful-microservice-net-core-docker-postresql/

## HelloWorldConsole
> NOTE: Created using Visual Studio Code

> SOURCE: [samples/HelloWorldConsole](./samples/HelloWorldConsole)

Basic example of a console app that can be ran within a Docker contaner.

**Linux and/or Mac users:** 

Once you're in the root of the "HelloWorldConsole" directory, you can use `./build.sh` to compile, create the container, and execute the image in a temporary container.

## HelloWebApi
> NOTE: Created using Visual Studio Code

> SOURCE: [samples/HelloWebApi](./samples/HelloWebApi)

Basic example of WebAPI value controller implementation.  Created using yeoman (`yeoman aspnet`).

**Linux and/or Mac users:** 

Once you're in the root of the "HelloWebApi" directory, you can use `./build.sh` to compile, create the container, and execute the image in a temporary container.

## VSCodeDebugging
> NOTE: Created using Visual Studio Code

> SOURCE: [samples/VSCodeDebugging](./samples/VSCodeDebugging)*

Full documentation for this example can be found on my blog: [Debug Dockerized .NET Core Apps in VS Code] (http://www.bloggedbychris.com/2016/08/03/debug-dockerized-net-core-apps-code/) 

This example includes debugging support for VS Code.  To run, open the "VSCodeDebugging" folder in VS Code.  Press \[F5\] (Mac: [fn] + [F5]) to initiate debugging.  Try this again, but set a break point somewhere in the `main` method.

> NOTE: After the console app exits, the container is not stopping.  Need to resolve this.

## VSCodeMvcDebugging
> NOTE: Created using Visual Studio Code

> SOURCE: [samples/VSCodeMvcDebugging](./samples/VSCodeMvcDebugging)*

Similar to the VSCodeDebugging, this example includes debugging support for VS Code.  However, this particular example enables debugging support within Docker for a sample MVC application build using .NET Core.

Will soon add more documentation on my blog: http://bloggedbychris.com/

To run, open the "VSCodeMvcDebugging" folder in VS Code.  Press \[F5\] (Mac: [fn] + [F5]) to initiate debugging.  Try this again, but set a break point somewhere in `Controller/HomeController`.