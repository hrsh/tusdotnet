﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tusdotnet.Helpers
{
    public static class CorsHelper
    {
        /// <summary>
        /// Returns the headers needed for the tus protocol to work over CORS.
        /// </summary>
        /// <returns>The headers needed for the tus protocol to work over CORS</returns>
        public static string[] GetExposedHeaders()
        {
            return new[]
            {
                "Location",
                "Tus-Resumable",
                "Tus-Version",
                "Tus-Extension",
                "Tus-Max-Size",
                "Tus-Checksum-Algorithm",
                "Upload-Length",
                "Upload-Offset",
                "Upload-Metadata",
                "Upload-Checksum",
                "Upload-Concat",
                "Upload-Expires"
            };
        }
    }
}