// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using Microsoft.Framework.Runtime;

namespace Microsoft.AspNet.Http.Interfaces
{
    [AssemblyNeutral]
    public interface IHttpApplicationFeature
    {
        string AppName { get; set; }
        string AppMode { get; set; }
        CancellationToken OnAppDisposing { get; set; }
    }
}
