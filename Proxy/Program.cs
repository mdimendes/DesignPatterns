// See https://aka.ms/new-console-template for more information
using Proxy;
using System;

Console.Title = "Proxy";

//without proxy
Console.WriteLine("Constructing document.");
var myDocument = new Document("MyDocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.DisplayDocument();

Console.WriteLine();

// with proxy
Console.WriteLine("Constructing document proxy.");
var myDocumentProxy = new DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed.");
myDocumentProxy.DisplayDocument();

Console.WriteLine();

// with chained proxy
Console.WriteLine("Constructing protected document proxy.");
var myProtectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
Console.WriteLine("Protected document proxy constructed.");
myProtectedDocumentProxy.DisplayDocument();

Console.WriteLine();

// with chained proxym no access
Console.WriteLine("Constructing protected document proxy.");
myProtectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "AnotherRole");
Console.WriteLine("Protected document proxy constructed.");
myProtectedDocumentProxy.DisplayDocument();

Console.ReadKey();