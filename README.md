## What is it?
This is one part of the educational project, the purpose of which was the creation of 3D Videoconferencing System ([based on a such pyramid](https://i.ytimg.com/vi/LbGvM5THvzA/maxresdefault.jpg)). This is a server application that receives processed images by capturer and sends it to listeners.

## Stack
.NET Framework 4.5.2, C#

## NuGet Dependencies
websocket-sharp by sta ([GitHub](https://github.com/sta/websocket-sharp))

## Repository Content
- VideoConfServer: Exactly server project.
- TestListener: The project of the console program that connects to the server and writes received bytes as jpg-images (used to test the server).
- TestSender: The project of the console program that sends files to the server as an array of bytes (the path to the file is entered into the console), was used to test the server

## Configuration
- ServerEndpoint: Base domain and server port, e.g. ws://localhost:8888
- MainPath: The path that joins ServerEndpoint. A clients are connected to this combination of ServerEndpoint and MainPath.