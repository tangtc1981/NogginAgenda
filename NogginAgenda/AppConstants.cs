﻿using System;
using Xamarin.Forms;

namespace NogginAgenda
{
    /// <summary>
    /// Style constants for the app
    /// </summary>
    public static class AppConstants
    {
        // Image caching bug so disable for now (http://forums.xamarin.com/discussion/22044/exception-with-long-image-uris)
        public static readonly bool CacheImagesEnabled =
            Device.OnPlatform(true, false, false);


    }
}