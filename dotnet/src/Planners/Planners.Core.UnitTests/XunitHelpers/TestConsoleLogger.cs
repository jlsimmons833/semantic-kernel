﻿// Copyright (c) Microsoft. All rights reserved.

using Microsoft.Extensions.Logging;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.SemanticKernel.Planning.UnitTests.XunitHelpers;
#pragma warning restore IDE0130

/// <summary>
/// Basic logger printing to console
/// </summary>
internal static class TestConsoleLogger
{
    internal static ILogger Log => LoggerFactory.CreateLogger<object>();

    internal static ILoggerFactory LoggerFactory => s_loggerFactory.Value;
    private static readonly Lazy<ILoggerFactory> s_loggerFactory = new(LogBuilder);

    private static ILoggerFactory LogBuilder()
    {
        return Microsoft.Extensions.Logging.LoggerFactory.Create(builder =>
        {
            builder.SetMinimumLevel(LogLevel.Trace);
            // builder.AddFilter("Microsoft", LogLevel.Trace);
            // builder.AddFilter("Microsoft", LogLevel.Debug);
            // builder.AddFilter("Microsoft", LogLevel.Information);
            // builder.AddFilter("Microsoft", LogLevel.Warning);
            // builder.AddFilter("Microsoft", LogLevel.Error);
            builder.AddConsole();
        });
    }
}