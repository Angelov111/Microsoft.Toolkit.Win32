// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using windows = Windows;

namespace Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT
{
    /// <summary>
    /// <see cref="windows.UI.Xaml.Controls.Maps.MapCameraChangeReason"/>
    /// </summary>
    public enum MapCameraChangeReason
    {
        System = 0,
        UserInteraction = 1,
        Programmatic = 2,
    }
}