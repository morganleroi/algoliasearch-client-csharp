﻿/*
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

using Algolia.Search.Clients;
using System;

namespace Algolia.Search.Test
{
    public class BaseTest
    {
        protected SearchClient<Actor> _client;
        protected Index<Actor> _index;

        public BaseTest()
        {
            CheckEnvironmentVariable();
            _client = new SearchClient<Actor>(Environment.GetEnvironmentVariable("ALGOLIA_APPLICATION_ID"), Environment.GetEnvironmentVariable("ALGOLIA_ADMIN_API_KEY"));
            _index = _client.InitIndex(GetSafeName("Actors"));
        }

        public static string GetSafeName(string name)
        {
            return Environment.GetEnvironmentVariable("APPVEYOR") == null
                ? name
                : $"{name}appveyor-{Environment.GetEnvironmentVariable("APPVEYOR_BUILD_NUMBER")}";
        }

        /// <summary>
        /// Check env variable before starting tests suite
        /// </summary>
        private void CheckEnvironmentVariable()
        {
            if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("APPVEYOR")))
            {
                if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ALGOLIA_APPLICATION_ID")))
                {
                    throw new ArgumentNullException("Please set the following environment variable : ALGOLIA_ADMIN_API_KEY");
                }

                if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ALGOLIA_ADMIN_API_KEY")))
                {
                    throw new ArgumentNullException("Please set the following environment variable : ALGOLIA_ADMIN_API_KEY");
                }
            }
        }
    }
}
