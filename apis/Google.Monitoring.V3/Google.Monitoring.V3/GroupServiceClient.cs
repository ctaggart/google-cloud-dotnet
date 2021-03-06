// Copyright 2016, Google Inc. All rights reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="GroupServiceClient"/>.
    /// </summary>
    public sealed partial class GroupServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GroupServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GroupServiceSettings"/>.
        /// </returns>
        public static GroupServiceSettings GetDefault() => new GroupServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GroupServiceSettings"/> object with default settings.
        /// </summary>
        public GroupServiceSettings() { }

        private GroupServiceSettings(GroupServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGroupsSettings = existing.ListGroupsSettings;
            GetGroupSettings = existing.GetGroupSettings;
            CreateGroupSettings = existing.CreateGroupSettings;
            UpdateGroupSettings = existing.UpdateGroupSettings;
            DeleteGroupSettings = existing.DeleteGroupSettings;
            ListGroupMembersSettings = existing.ListGroupMembersSettings;
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.ListGroups</c> and <c>GroupServiceClient.ListGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.ListGroups</c> and
        /// <c>GroupServiceClient.ListGroupsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListGroupsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.GetGroup</c> and <c>GroupServiceClient.GetGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.GetGroup</c> and
        /// <c>GroupServiceClient.GetGroupAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetGroupSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.CreateGroup</c> and <c>GroupServiceClient.CreateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.CreateGroup</c> and
        /// <c>GroupServiceClient.CreateGroupAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateGroupSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.UpdateGroup</c> and <c>GroupServiceClient.UpdateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.UpdateGroup</c> and
        /// <c>GroupServiceClient.UpdateGroupAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateGroupSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.DeleteGroup</c> and <c>GroupServiceClient.DeleteGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.DeleteGroup</c> and
        /// <c>GroupServiceClient.DeleteGroupAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteGroupSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.ListGroupMembers</c> and <c>GroupServiceClient.ListGroupMembersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.ListGroupMembers</c> and
        /// <c>GroupServiceClient.ListGroupMembersAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListGroupMembersSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="GroupServiceSettings"/> object.</returns>
        public GroupServiceSettings Clone() => new GroupServiceSettings(this);
    }

    /// <summary>
    /// GroupService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the GroupService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default GroupService scopes.
        /// </summary>
        /// <remarks>
        /// The default GroupService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.write"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>
        /// The full project resource name.
        /// </returns>
        public static string FormatProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a group resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>group</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate GroupTemplate { get; } = new PathTemplate("projects/{project}/groups/{group}");

        /// <summary>
        /// Creates a group resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <returns>
        /// The full group resource name.
        /// </returns>
        public static string FormatGroupName(string projectId, string groupId) => GroupTemplate.Expand(projectId, groupId);

        /// <summary>
        /// Path template for a metric_descriptor resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>metricDescriptor</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate MetricDescriptorTemplate { get; } = new PathTemplate("projects/{project}/metricDescriptors/{metric_descriptor=**}");

        /// <summary>
        /// Creates a metric_descriptor resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="metricDescriptorId">The metricDescriptor ID.</param>
        /// <returns>
        /// The full metric_descriptor resource name.
        /// </returns>
        public static string FormatMetricDescriptorName(string projectId, string metricDescriptorId) => MetricDescriptorTemplate.Expand(projectId, metricDescriptorId);

        /// <summary>
        /// Path template for a monitored_resource_descriptor resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>monitoredResourceDescriptor</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate MonitoredResourceDescriptorTemplate { get; } = new PathTemplate("projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}");

        /// <summary>
        /// Creates a monitored_resource_descriptor resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="monitoredResourceDescriptorId">The monitoredResourceDescriptor ID.</param>
        /// <returns>
        /// The full monitored_resource_descriptor resource name.
        /// </returns>
        public static string FormatMonitoredResourceDescriptorName(string projectId, string monitoredResourceDescriptorId) => MonitoredResourceDescriptorTemplate.Expand(projectId, monitoredResourceDescriptorId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="GroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="GroupServiceClient"/>.</returns>
        public static async Task<GroupServiceClient> CreateAsync(ServiceEndpoint endpoint = null, GroupServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create(ServiceEndpoint endpoint = null, GroupServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GroupServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create(Channel channel, GroupServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            GroupService.GroupServiceClient grpcClient = new GroupService.GroupServiceClient(channel);
            return new GroupServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, GroupServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, GroupServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, GroupServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, GroupServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC GroupService client.
        /// </summary>
        public virtual GroupService.GroupServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Group> GetGroupAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Group> GetGroupAsync(
            string name,
            CancellationToken cancellationToken) => GetGroupAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group GetGroup(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Group> CreateGroupAsync(
            string name,
            Group group,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Group> CreateGroupAsync(
            string name,
            Group group,
            CancellationToken cancellationToken) => CreateGroupAsync(
                name,
                group,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group CreateGroup(
            string name,
            Group group,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Group> UpdateGroupAsync(
            Group group,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Group> UpdateGroupAsync(
            Group group,
            CancellationToken cancellationToken) => UpdateGroupAsync(
                group,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group UpdateGroup(
            Group group,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteGroupAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteGroupAsync(
            string name,
            CancellationToken cancellationToken) => DeleteGroupAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteGroup(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MonitoredResource"/> resources.
        /// </returns>
        public virtual IPagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembersAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="MonitoredResource"/> resources.
        /// </returns>
        public virtual IPagedEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembers(
            string name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// GroupService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GroupServiceClientImpl : GroupServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ListGroupsRequest, ListGroupsResponse> _callListGroups;
        private readonly ApiCall<GetGroupRequest, Group> _callGetGroup;
        private readonly ApiCall<CreateGroupRequest, Group> _callCreateGroup;
        private readonly ApiCall<UpdateGroupRequest, Group> _callUpdateGroup;
        private readonly ApiCall<DeleteGroupRequest, Empty> _callDeleteGroup;
        private readonly ApiCall<ListGroupMembersRequest, ListGroupMembersResponse> _callListGroupMembers;

        /// <summary>
        /// Constructs a client wrapper for the GroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GroupServiceSettings"/> used within this client </param>
        public GroupServiceClientImpl(GroupService.GroupServiceClient grpcClient, GroupServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            GroupServiceSettings effectiveSettings = settings ?? GroupServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callListGroups = _clientHelper.BuildApiCall<ListGroupsRequest, ListGroupsResponse>(
                GrpcClient.ListGroupsAsync, GrpcClient.ListGroups, effectiveSettings.ListGroupsSettings);
            _callGetGroup = _clientHelper.BuildApiCall<GetGroupRequest, Group>(
                GrpcClient.GetGroupAsync, GrpcClient.GetGroup, effectiveSettings.GetGroupSettings);
            _callCreateGroup = _clientHelper.BuildApiCall<CreateGroupRequest, Group>(
                GrpcClient.CreateGroupAsync, GrpcClient.CreateGroup, effectiveSettings.CreateGroupSettings);
            _callUpdateGroup = _clientHelper.BuildApiCall<UpdateGroupRequest, Group>(
                GrpcClient.UpdateGroupAsync, GrpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings);
            _callDeleteGroup = _clientHelper.BuildApiCall<DeleteGroupRequest, Empty>(
                GrpcClient.DeleteGroupAsync, GrpcClient.DeleteGroup, effectiveSettings.DeleteGroupSettings);
            _callListGroupMembers = _clientHelper.BuildApiCall<ListGroupMembersRequest, ListGroupMembersResponse>(
                GrpcClient.ListGroupMembersAsync, GrpcClient.ListGroupMembers, effectiveSettings.ListGroupMembersSettings);
        }

        /// <summary>
        /// The underlying gRPC GroupService client.
        /// </summary>
        public override GroupService.GroupServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListGroupsRequest(ref ListGroupsRequest request, ref CallSettings settings);
        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref CallSettings settings);
        partial void Modify_CreateGroupRequest(ref CreateGroupRequest request, ref CallSettings settings);
        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref CallSettings settings);
        partial void Modify_DeleteGroupRequest(ref DeleteGroupRequest request, ref CallSettings settings);
        partial void Modify_ListGroupMembersRequest(ref ListGroupMembersRequest request, ref CallSettings settings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Group> GetGroupAsync(
            string name,
            CallSettings callSettings = null)
        {
            GetGroupRequest request = new GetGroupRequest
            {
                Name = name,
            };
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Group GetGroup(
            string name,
            CallSettings callSettings = null)
        {
            GetGroupRequest request = new GetGroupRequest
            {
                Name = name,
            };
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Group> CreateGroupAsync(
            string name,
            Group group,
            CallSettings callSettings = null)
        {
            CreateGroupRequest request = new CreateGroupRequest
            {
                Name = name,
                Group = group,
            };
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return _callCreateGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Group CreateGroup(
            string name,
            Group group,
            CallSettings callSettings = null)
        {
            CreateGroupRequest request = new CreateGroupRequest
            {
                Name = name,
                Group = group,
            };
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return _callCreateGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Group> UpdateGroupAsync(
            Group group,
            CallSettings callSettings = null)
        {
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = group,
            };
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Group UpdateGroup(
            Group group,
            CallSettings callSettings = null)
        {
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = group,
            };
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteGroupAsync(
            string name,
            CallSettings callSettings = null)
        {
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                Name = name,
            };
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            return _callDeleteGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteGroup(
            string name,
            CallSettings callSettings = null)
        {
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                Name = name,
            };
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            _callDeleteGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MonitoredResource"/> resources.
        /// </returns>
        public override IPagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembersAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                Name = name,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            };
            Modify_ListGroupMembersRequest(ref request, ref callSettings);
            return new PagedAsyncEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, MonitoredResource>(_callListGroupMembers, request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="MonitoredResource"/> resources.
        /// </returns>
        public override IPagedEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembers(
            string name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                Name = name,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            };
            Modify_ListGroupMembersRequest(ref request, ref callSettings);
            return new PagedEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, MonitoredResource>(_callListGroupMembers, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListGroupMembersRequest : IPageRequest { }
    public partial class ListGroupMembersResponse : IPageResponse<MonitoredResource>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<MonitoredResource> GetEnumerator() => Members.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
