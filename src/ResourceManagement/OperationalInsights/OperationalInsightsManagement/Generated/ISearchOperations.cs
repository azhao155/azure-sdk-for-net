// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights
{
    /// <summary>
    /// Operations for using Operational Insights search.
    /// </summary>
    public partial interface ISearchOperations
    {
        /// <summary>
        /// Creates or updates a saved search for a given workspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// The id of the saved search.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to save a search.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateOrUpdateSavedSearchAsync(string resourceGroupName, string workspaceName, string savedSearchId, SearchCreateOrUpdateSavedSearchParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the specified saved search in a given workspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// The id of the saved search.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteSavedSearchAsync(string resourceGroupName, string workspaceName, string savedSearchId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the specified saved search for a given workspace.
        /// </summary>
        /// <param name='savedSearchId'>
        /// The id of the saved search.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Value object for saved search results.
        /// </returns>
        Task<SearchGetSavedSearchResponse> GetSavedSearchAsync(string savedSearchId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the results from a saved search for a given workspace.
        /// </summary>
        /// <param name='savedSearchId'>
        /// The id of the saved search.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        Task<SearchGetSearchResultsResponse> GetSavedSearchResultsAsync(string savedSearchId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the schema for a given workspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// A unique workspace instance name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get schema operation response.
        /// </returns>
        Task<SearchGetSchemaResponse> GetSchemaAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the search results for a given workspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// A unique workspace instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to execute a search query.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        Task<SearchGetSearchResultsResponse> GetSearchResultsAsync(string resourceGroupName, string workspaceName, SearchGetSearchResultsParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the saved searches for a given workspace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// A unique workspace instance name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The saved search operation response.
        /// </returns>
        Task<SearchListSavedSearchResponse> ListSavedSearchesAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets updated search results for a given search query.
        /// </summary>
        /// <param name='id'>
        /// The id of the search that will have results updated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        Task<SearchGetSearchResultsResponse> UpdateSearchResultsAsync(string id, CancellationToken cancellationToken);
    }
}
