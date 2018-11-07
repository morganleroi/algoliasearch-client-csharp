/*
* Copyright (c) 2018 Algolia
* http://www.algolia.com/
* Based on the first version developed by Christopher Maneu under the same license:
*  https://github.com/cmaneu/algoliasearch-client-csharp
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

using System;
using System.Globalization;

namespace Algolia.Search.Test.Helpers
{
    internal static class TestHelper
    {
        internal static string ApplicationId = Environment.GetEnvironmentVariable("ALGOLIA_APPLICATION_ID");

        internal static string TestApiKey = Environment.GetEnvironmentVariable("APPVEYOR") == null
              ? Environment.GetEnvironmentVariable("ALGOLIA_ADMIN_API_KEY")
              : Environment.GetEnvironmentVariable("ALGOLIA_API_KEY");

        /// <summary>
        /// Check env variable before starting tests suite
        /// </summary>
        internal static void CheckEnvironmentVariable()
        {
            if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("APPVEYOR")))
            {
                if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("ALGOLIA_APPLICATION_ID")))
                {
                    throw new ArgumentNullException("Please set the following environment variable : ALGOLIA_ADMIN_API_KEY");
                }

                if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("ALGOLIA_ADMIN_API_KEY")))
                {
                    throw new ArgumentNullException("Please set the following environment variable : ALGOLIA_ADMIN_API_KEY");
                }
            }
        }

        internal static string GetTestIndexName(string testName)
        {
            string appVeyor = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("APPVEYOR"))
                ? null
                : $"-appveyor-{Environment.GetEnvironmentVariable("APPVEYOR_BUILD_NUMBER")}";

            var date = DateTime.UtcNow.ToString("yyyy-MM-dd_HH:mm:ss", CultureInfo.InvariantCulture);

            return string.IsNullOrEmpty(appVeyor)
                ? $"csharp_{date}_{Environment.UserName}_{testName}"
                : $"csharp_{date}_{appVeyor}_{testName}";
        }
    }
}