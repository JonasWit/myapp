using System;

namespace DotnetService.ServiceLoaders;

[AttributeUsage(AttributeTargets.Class)]
public class ApplicationSingletonViewModel : Attribute
{
}

[AttributeUsage(AttributeTargets.Class)]
public class ApplicationTransientViewModel : Attribute
{
}