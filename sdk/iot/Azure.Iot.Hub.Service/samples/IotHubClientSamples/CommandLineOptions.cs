﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using CommandLine;

namespace Azure.Iot.Hub.Service.Samples
{
    public class CommandLineOptions
    {
        [Option('p', "sharedAccessPolicy", Required = true, HelpText = "Iot Hub instance shared access policy")]
        public string IotHubSharedAccessPolicy { get; set; }

        [Option('k', "sharedAccessKey", Required = true, HelpText = "Iot Hub instance shared access key")]
        public string IotHubSharedAccessKey { get; set; }

        [Option('e', "endpoint", Required = true, HelpText = "Iot Hub endpoint")]
        public Uri Endpoint { get; set; }
    }
}
