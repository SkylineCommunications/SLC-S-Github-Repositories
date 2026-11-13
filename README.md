# Skyline.DataMiner.ConnectorAPI.Github.Repositories

## Table of Content

- [About](#about)
- [Getting Started](#getting-started)
- [Installation](#installation)

## About

A Connector API (InterApp calls/messages) for DataMiner elements running the 'GitHub Repositories' connector.

This nuget contains base classes that are used in the Github Repositories Connector, that could also be usefull in Automation scripts. 

It has the classes to make request to the connector to for example add/remove a repository or create a new workflow.

### About DataMiner

DataMiner is a transformational platform that provides vendor-independent control and monitoring of devices and services. Out of the box and by design, it addresses key challenges such as security, complexity, multi-cloud, and much more. It has a pronounced open architecture and powerful capabilities enabling users to evolve easily and continuously.

The foundation of DataMiner is its powerful and versatile data acquisition and control layer. With DataMiner, there are no restrictions to what data users can access. Data sources may reside on premises, in the cloud, or in a hybrid setup.

A unique catalog of 7000+ connectors already exist. In addition, you can leverage DataMiner Development Packages to build you own connectors (also known as "protocols" or "drivers").

> **Note**
> See also: [About DataMiner](https://aka.dataminer.services/about-dataminer).

### About Skyline Communications

At Skyline Communications, we deal in world-class solutions that are deployed by leading companies around the globe. Check out [our proven track record](https://aka.dataminer.services/about-skyline) and see how we make our customers' lives easier by empowering them to take their operations to the next level.

## Getting Started

Install the package, then connect to an element running the 'GitHub Repositories' connector:

```csharp
var github = new GithubRepositories(engine.GetUserConnection(), "My GitHub Element");

var response = github.SendSingleResponseMessage<CreateRepositoryResponse>(
    new CreateRepositoryRequest
    {
        Data = new CreateRepositoryData
        {
            OrganizationId = "SkylineCommunications",
            Name = "my-new-repo",
            Description = "Created from DataMiner",
            Public = false,
        },
    });

if (!response.Success)
{
    engine.GenerateInformation($"Create failed ({response.Status}): {response.Description}");
}
```

### Requirements

- An element running the 'GitHub Repositories' connector, version 1.0.0.9 or higher.
- DataMiner 10.1.11 or higher.

## Installation

Add the nuget package to your project with the "Manage Nuget Packges..." and search for "Skyline.DataMiner.ConnectorAPI.Github.Repositories".
