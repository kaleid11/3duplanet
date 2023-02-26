# Software Design Specification

## Introduction
Welcome to the software design specification for the 3duplanet project, an ASP.NET Core 7 application designed to provide a user-friendly experience for managing and presenting content. This application has been developed to include user registration and authentication, allowing for effective administration of site content by the site's administrators.

The application's index page is designed to present users with embedded calendar content from Notion, along with a selection of blog posts from an external personal Wix blog. Users can also sign up for the newsletter via a simple form presented on the index page. In addition, the site will include an About and Contact page to provide users with more information about the project and to allow them to get in touch with the site's administrators.

This software design specification outlines the overall architecture, design, and implementation details of the 3duplanet project, including its various features, modules, and interfaces. It is intended to serve as a comprehensive guide for the development team and other stakeholders involved in the project, providing a clear and concise outline of the application's functionality and capabilities.

## Architecture
The 3duplanet project will be built on top of the ASP.NET Core 7 framework, using Razor Pages for the frontend and C# for the backend. The project will use Entity Framework Core 7 (EFCore 7) as the object-relational mapper to interact with the database. PostgreSQL will be used as the database management system, and the NodaTime extensions will be used for handling date and time-related functionality.

The application will be containerized using Docker, and built into a Docker image. The deployment process will utilize Docker Compose, a tool for defining and running multi-container Docker applications. The Docker Compose file will define the services required for the application, including the database, application server, and any additional services required. By using Docker, the 3duplanet project can be packaged into a portable container that includes all the necessary components, including the application code, runtime, and dependencies. This makes it easy to deploy the application to any environment that supports Docker, without having to worry about the underlying infrastructure.

*ASP.NET Core 7* is a free and open-source web framework that provides a modern, modular, and cross-platform development experience for creating web applications. The framework allows developers to build web applications using a variety of programming languages, including C#, F#, and Visual Basic. Razor Pages is a feature of ASP.NET Core that allows developers to build dynamic web pages using C# and HTML markup.

*Entity Framework Core 7* is a lightweight, extensible, and open-source ORM framework for .NET applications. It provides an easy-to-use API for working with databases, including CRUD operations, and supports a variety of database management systems, including PostgreSQL.

*PostgreSQL* is a powerful, open-source object-relational database management system that supports a wide range of features, including transactional processing, high concurrency, and data integrity. It is an ideal choice for modern web applications that require a robust and scalable database.

*NodaTime* is an open-source library that provides a comprehensive and flexible toolkit for working with dates and times in .NET applications. It is designed to be more accurate and comprehensive than the built-in .NET DateTime API, and provides support for a wide range of calendars, time zones, and durations.

*Docker Compose* is a tool for defining and running multi-container Docker applications. It allows developers to define the services required by the application in a YAML file, and then use a single command to start and stop the entire application stack. This makes it easy to manage the application's infrastructure and services, and simplifies the deployment process.

## Data Design

## User Interface Design

## Functional Design

## Non-functional Design

## Testing Design

### User Stories

## Deployment Design

## Maintenance Design

## References