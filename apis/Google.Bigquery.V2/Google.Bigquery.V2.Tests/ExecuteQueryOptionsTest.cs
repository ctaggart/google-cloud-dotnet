﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using Xunit;

namespace Google.Bigquery.V2.Tests
{
    public class ExecuteQueryOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new ExecuteQueryOptions
            {
                DefaultDataset = new DatasetReference { ProjectId = "a", DatasetId = "b" },
                PageSize = 25,
                UseQueryCache = false,
                UseLegacySql = true
            };
            var request = new QueryRequest();
            options.ModifyRequest(request);
            Assert.Equal(25, request.MaxResults);
            Assert.Equal("a", request.DefaultDataset.ProjectId);
            Assert.Equal(false, request.UseQueryCache);
            Assert.Equal(true, request.UseLegacySql);
        }

        [Fact]
        public void ToGetQueryResultsOptions()
        {
            var options = new ExecuteQueryOptions
            {
                DefaultDataset = new DatasetReference { ProjectId = "a", DatasetId = "b" },
                PageSize = 25,
                UseQueryCache = false,
                UseLegacySql = true
            };
            var getQueryResultsOptions = options.ToGetQueryResultsOptions();
            Assert.Equal(25, getQueryResultsOptions.PageSize);
        }
    }
}
