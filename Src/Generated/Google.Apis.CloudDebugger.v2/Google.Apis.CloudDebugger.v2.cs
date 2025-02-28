// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudDebugger.v2
{
    /// <summary>The CloudDebugger Service.</summary>
    public class CloudDebuggerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudDebuggerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudDebuggerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Controller = new ControllerResource(this);
            Debugger = new DebuggerResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "clouddebugger";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://clouddebugger.googleapis.com/";
        #else
            "https://clouddebugger.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://clouddebugger.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Debugger API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Use Stackdriver Debugger</summary>
            public static string CloudDebugger = "https://www.googleapis.com/auth/cloud_debugger";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Debugger API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Use Stackdriver Debugger</summary>
            public const string CloudDebugger = "https://www.googleapis.com/auth/cloud_debugger";
        }

        /// <summary>Gets the Controller resource.</summary>
        public virtual ControllerResource Controller { get; }

        /// <summary>Gets the Debugger resource.</summary>
        public virtual DebuggerResource Debugger { get; }
    }

    /// <summary>A base abstract class for CloudDebugger requests.</summary>
    public abstract class CloudDebuggerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudDebuggerBaseServiceRequest instance.</summary>
        protected CloudDebuggerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes CloudDebugger parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "controller" collection of methods.</summary>
    public class ControllerResource
    {
        private const string Resource = "controller";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ControllerResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Debuggees = new DebuggeesResource(service);
        }

        /// <summary>Gets the Debuggees resource.</summary>
        public virtual DebuggeesResource Debuggees { get; }

        /// <summary>The "debuggees" collection of methods.</summary>
        public class DebuggeesResource
        {
            private const string Resource = "debuggees";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DebuggeesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Breakpoints = new BreakpointsResource(service);
            }

            /// <summary>Gets the Breakpoints resource.</summary>
            public virtual BreakpointsResource Breakpoints { get; }

            /// <summary>The "breakpoints" collection of methods.</summary>
            public class BreakpointsResource
            {
                private const string Resource = "breakpoints";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BreakpointsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Returns the list of all active breakpoints for the debuggee. The breakpoint specification
                /// (`location`, `condition`, and `expressions` fields) is semantically immutable, although the field
                /// values may change. For example, an agent may update the location line number to reflect the actual
                /// line where the breakpoint was set, but this doesn't change the breakpoint semantics. This means that
                /// an agent does not need to check if a breakpoint has changed when it encounters the same breakpoint
                /// on a successive call. Moreover, an agent should remember the breakpoints that are completed until
                /// the controller removes them from the active list to avoid setting those breakpoints again.
                /// </summary>
                /// <param name="debuggeeId">Required. Identifies the debuggee.</param>
                public virtual ListRequest List(string debuggeeId)
                {
                    return new ListRequest(service, debuggeeId);
                }

                /// <summary>
                /// Returns the list of all active breakpoints for the debuggee. The breakpoint specification
                /// (`location`, `condition`, and `expressions` fields) is semantically immutable, although the field
                /// values may change. For example, an agent may update the location line number to reflect the actual
                /// line where the breakpoint was set, but this doesn't change the breakpoint semantics. This means that
                /// an agent does not need to check if a breakpoint has changed when it encounters the same breakpoint
                /// on a successive call. Moreover, an agent should remember the breakpoints that are completed until
                /// the controller removes them from the active list to avoid setting those breakpoints again.
                /// </summary>
                public class ListRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.ListActiveBreakpointsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string debuggeeId) : base(service)
                    {
                        DebuggeeId = debuggeeId;
                        InitParameters();
                    }

                    /// <summary>Required. Identifies the debuggee.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("debuggeeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DebuggeeId { get; private set; }

                    /// <summary>
                    /// Identifies the agent. This is the ID returned in the RegisterDebuggee response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("agentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AgentId { get; set; }

                    /// <summary>
                    /// If set to `true` (recommended), returns `google.rpc.Code.OK` status and sets the `wait_expired`
                    /// response field to `true` when the server-selected timeout has expired. If set to `false`
                    /// (deprecated), returns `google.rpc.Code.ABORTED` status when the server-selected timeout has
                    /// expired.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("successOnTimeout", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> SuccessOnTimeout { get; set; }

                    /// <summary>
                    /// A token that, if specified, blocks the method call until the list of active breakpoints has
                    /// changed, or a server-selected timeout has expired. The value should be set from the
                    /// `next_wait_token` field in the last response. The initial value should be set to `"init"`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("waitToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WaitToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/controller/debuggees/{debuggeeId}/breakpoints";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("debuggeeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debuggeeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("agentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "agentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("successOnTimeout", new Google.Apis.Discovery.Parameter
                        {
                            Name = "successOnTimeout",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("waitToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "waitToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates the breakpoint state or mutable fields. The entire Breakpoint message must be sent back to
                /// the controller service. Updates to active breakpoint fields are only allowed if the new value does
                /// not change the breakpoint specification. Updates to the `location`, `condition` and `expressions`
                /// fields should not alter the breakpoint semantics. These may only make changes such as canonicalizing
                /// a value or snapping the location to the correct line of code.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="debuggeeId">Required. Identifies the debuggee being debugged.</param>
                /// <param name="id">Breakpoint identifier, unique in the scope of the debuggee.</param>
                public virtual UpdateRequest Update(Google.Apis.CloudDebugger.v2.Data.UpdateActiveBreakpointRequest body, string debuggeeId, string id)
                {
                    return new UpdateRequest(service, body, debuggeeId, id);
                }

                /// <summary>
                /// Updates the breakpoint state or mutable fields. The entire Breakpoint message must be sent back to
                /// the controller service. Updates to active breakpoint fields are only allowed if the new value does
                /// not change the breakpoint specification. Updates to the `location`, `condition` and `expressions`
                /// fields should not alter the breakpoint semantics. These may only make changes such as canonicalizing
                /// a value or snapping the location to the correct line of code.
                /// </summary>
                public class UpdateRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.UpdateActiveBreakpointResponse>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDebugger.v2.Data.UpdateActiveBreakpointRequest body, string debuggeeId, string id) : base(service)
                    {
                        DebuggeeId = debuggeeId;
                        Id = id;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Identifies the debuggee being debugged.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("debuggeeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DebuggeeId { get; private set; }

                    /// <summary>Breakpoint identifier, unique in the scope of the debuggee.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDebugger.v2.Data.UpdateActiveBreakpointRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/controller/debuggees/{debuggeeId}/breakpoints/{id}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("debuggeeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debuggeeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Registers the debuggee with the controller service. All agents attached to the same application must
            /// call this method with exactly the same request content to get back the same stable `debuggee_id`. Agents
            /// should call this method again whenever `google.rpc.Code.NOT_FOUND` is returned from any controller
            /// method. This protocol allows the controller service to disable debuggees, recover from data loss, or
            /// change the `debuggee_id` format. Agents must handle `debuggee_id` value changing upon re-registration.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            public virtual RegisterRequest Register(Google.Apis.CloudDebugger.v2.Data.RegisterDebuggeeRequest body)
            {
                return new RegisterRequest(service, body);
            }

            /// <summary>
            /// Registers the debuggee with the controller service. All agents attached to the same application must
            /// call this method with exactly the same request content to get back the same stable `debuggee_id`. Agents
            /// should call this method again whenever `google.rpc.Code.NOT_FOUND` is returned from any controller
            /// method. This protocol allows the controller service to disable debuggees, recover from data loss, or
            /// change the `debuggee_id` format. Agents must handle `debuggee_id` value changing upon re-registration.
            /// </summary>
            public class RegisterRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.RegisterDebuggeeResponse>
            {
                /// <summary>Constructs a new Register request.</summary>
                public RegisterRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDebugger.v2.Data.RegisterDebuggeeRequest body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudDebugger.v2.Data.RegisterDebuggeeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "register";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/controller/debuggees/register";

                /// <summary>Initializes Register parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                }
            }
        }
    }

    /// <summary>The "debugger" collection of methods.</summary>
    public class DebuggerResource
    {
        private const string Resource = "debugger";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DebuggerResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Debuggees = new DebuggeesResource(service);
        }

        /// <summary>Gets the Debuggees resource.</summary>
        public virtual DebuggeesResource Debuggees { get; }

        /// <summary>The "debuggees" collection of methods.</summary>
        public class DebuggeesResource
        {
            private const string Resource = "debuggees";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DebuggeesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Breakpoints = new BreakpointsResource(service);
            }

            /// <summary>Gets the Breakpoints resource.</summary>
            public virtual BreakpointsResource Breakpoints { get; }

            /// <summary>The "breakpoints" collection of methods.</summary>
            public class BreakpointsResource
            {
                private const string Resource = "breakpoints";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BreakpointsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Deletes the breakpoint from the debuggee.</summary>
                /// <param name="debuggeeId">Required. ID of the debuggee whose breakpoint to delete.</param>
                /// <param name="breakpointId">Required. ID of the breakpoint to delete.</param>
                public virtual DeleteRequest Delete(string debuggeeId, string breakpointId)
                {
                    return new DeleteRequest(service, debuggeeId, breakpointId);
                }

                /// <summary>Deletes the breakpoint from the debuggee.</summary>
                public class DeleteRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string debuggeeId, string breakpointId) : base(service)
                    {
                        DebuggeeId = debuggeeId;
                        BreakpointId = breakpointId;
                        InitParameters();
                    }

                    /// <summary>Required. ID of the debuggee whose breakpoint to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("debuggeeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DebuggeeId { get; private set; }

                    /// <summary>Required. ID of the breakpoint to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("breakpointId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string BreakpointId { get; private set; }

                    /// <summary>
                    /// Required. The client version making the call. Schema: `domain/type/version` (e.g.,
                    /// `google.com/intellij/v1`).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/debugger/debuggees/{debuggeeId}/breakpoints/{breakpointId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("debuggeeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debuggeeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("breakpointId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "breakpointId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets breakpoint information.</summary>
                /// <param name="debuggeeId">Required. ID of the debuggee whose breakpoint to get.</param>
                /// <param name="breakpointId">Required. ID of the breakpoint to get.</param>
                public virtual GetRequest Get(string debuggeeId, string breakpointId)
                {
                    return new GetRequest(service, debuggeeId, breakpointId);
                }

                /// <summary>Gets breakpoint information.</summary>
                public class GetRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.GetBreakpointResponse>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string debuggeeId, string breakpointId) : base(service)
                    {
                        DebuggeeId = debuggeeId;
                        BreakpointId = breakpointId;
                        InitParameters();
                    }

                    /// <summary>Required. ID of the debuggee whose breakpoint to get.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("debuggeeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DebuggeeId { get; private set; }

                    /// <summary>Required. ID of the breakpoint to get.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("breakpointId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string BreakpointId { get; private set; }

                    /// <summary>
                    /// Required. The client version making the call. Schema: `domain/type/version` (e.g.,
                    /// `google.com/intellij/v1`).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/debugger/debuggees/{debuggeeId}/breakpoints/{breakpointId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("debuggeeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debuggeeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("breakpointId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "breakpointId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all breakpoints for the debuggee.</summary>
                /// <param name="debuggeeId">Required. ID of the debuggee whose breakpoints to list.</param>
                public virtual ListRequest List(string debuggeeId)
                {
                    return new ListRequest(service, debuggeeId);
                }

                /// <summary>Lists all breakpoints for the debuggee.</summary>
                public class ListRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.ListBreakpointsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string debuggeeId) : base(service)
                    {
                        DebuggeeId = debuggeeId;
                        InitParameters();
                    }

                    /// <summary>Required. ID of the debuggee whose breakpoints to list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("debuggeeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DebuggeeId { get; private set; }

                    /// <summary>Only breakpoints with the specified action will pass the filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("action.value", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ActionValueEnum> ActionValue { get; set; }

                    /// <summary>Only breakpoints with the specified action will pass the filter.</summary>
                    public enum ActionValueEnum
                    {
                        /// <summary>
                        /// Capture stack frame and variables and update the breakpoint. The data is only captured once.
                        /// After that the breakpoint is set in a final state.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CAPTURE")]
                        CAPTURE = 0,

                        /// <summary>
                        /// Log each breakpoint hit. The breakpoint remains active until deleted or expired.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("LOG")]
                        LOG = 1,
                    }

                    /// <summary>
                    /// Required. The client version making the call. Schema: `domain/type/version` (e.g.,
                    /// `google.com/intellij/v1`).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientVersion { get; set; }

                    /// <summary>
                    /// When set to `true`, the response includes the list of breakpoints set by any user. Otherwise, it
                    /// includes only breakpoints set by the caller.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeAllUsers", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeAllUsers { get; set; }

                    /// <summary>
                    /// When set to `true`, the response includes active and inactive breakpoints. Otherwise, it
                    /// includes only active breakpoints.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeInactive", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeInactive { get; set; }

                    /// <summary>
                    /// This field is deprecated. The following fields are always stripped out of the result:
                    /// `stack_frames`, `evaluated_expressions` and `variable_table`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("stripResults", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> StripResults { get; set; }

                    /// <summary>
                    /// A wait token that, if specified, blocks the call until the breakpoints list has changed, or a
                    /// server selected timeout has expired. The value should be set from the last response. The error
                    /// code `google.rpc.Code.ABORTED` (RPC) is returned on wait timeout, which should be called again
                    /// with the same `wait_token`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("waitToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WaitToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/debugger/debuggees/{debuggeeId}/breakpoints";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("debuggeeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debuggeeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("action.value", new Google.Apis.Discovery.Parameter
                        {
                            Name = "action.value",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeAllUsers", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeAllUsers",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeInactive", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeInactive",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("stripResults", new Google.Apis.Discovery.Parameter
                        {
                            Name = "stripResults",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("waitToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "waitToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Sets the breakpoint to the debuggee.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="debuggeeId">Required. ID of the debuggee where the breakpoint is to be set.</param>
                public virtual SetRequest Set(Google.Apis.CloudDebugger.v2.Data.Breakpoint body, string debuggeeId)
                {
                    return new SetRequest(service, body, debuggeeId);
                }

                /// <summary>Sets the breakpoint to the debuggee.</summary>
                public class SetRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.SetBreakpointResponse>
                {
                    /// <summary>Constructs a new Set request.</summary>
                    public SetRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDebugger.v2.Data.Breakpoint body, string debuggeeId) : base(service)
                    {
                        DebuggeeId = debuggeeId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. ID of the debuggee where the breakpoint is to be set.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("debuggeeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DebuggeeId { get; private set; }

                    /// <summary>The canary option set by the user upon setting breakpoint.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("canaryOption", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<CanaryOptionEnum> CanaryOption { get; set; }

                    /// <summary>The canary option set by the user upon setting breakpoint.</summary>
                    public enum CanaryOptionEnum
                    {
                        /// <summary>Depends on the canary_mode of the debuggee.</summary>
                        [Google.Apis.Util.StringValueAttribute("CANARY_OPTION_UNSPECIFIED")]
                        CANARYOPTIONUNSPECIFIED = 0,

                        /// <summary>
                        /// Enable the canary for this breakpoint if the canary_mode of the debuggee is not
                        /// CANARY_MODE_ALWAYS_ENABLED or CANARY_MODE_ALWAYS_DISABLED.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CANARY_OPTION_TRY_ENABLE")]
                        CANARYOPTIONTRYENABLE = 1,

                        /// <summary>
                        /// Disable the canary for this breakpoint if the canary_mode of the debuggee is not
                        /// CANARY_MODE_ALWAYS_ENABLED or CANARY_MODE_ALWAYS_DISABLED.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CANARY_OPTION_TRY_DISABLE")]
                        CANARYOPTIONTRYDISABLE = 2,
                    }

                    /// <summary>
                    /// Required. The client version making the call. Schema: `domain/type/version` (e.g.,
                    /// `google.com/intellij/v1`).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientVersion { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDebugger.v2.Data.Breakpoint Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "set";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/debugger/debuggees/{debuggeeId}/breakpoints/set";

                    /// <summary>Initializes Set parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("debuggeeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debuggeeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("canaryOption", new Google.Apis.Discovery.Parameter
                        {
                            Name = "canaryOption",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Lists all the debuggees that the user has access to.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(service);
            }

            /// <summary>Lists all the debuggees that the user has access to.</summary>
            public class ListRequest : CloudDebuggerBaseServiceRequest<Google.Apis.CloudDebugger.v2.Data.ListDebuggeesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>
                /// Required. The client version making the call. Schema: `domain/type/version` (e.g.,
                /// `google.com/intellij/v1`).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("clientVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ClientVersion { get; set; }

                /// <summary>
                /// When set to `true`, the result includes all debuggees. Otherwise, the result includes only debuggees
                /// that are active.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("includeInactive", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeInactive { get; set; }

                /// <summary>Required. Project number of a Google Cloud project whose debuggees to list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Project { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/debugger/debuggees";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("clientVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "clientVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeInactive", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeInactive",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.CloudDebugger.v2.Data
{
    /// <summary>An alias to a repo revision.</summary>
    public class AliasContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alias kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The alias name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ------------------------------------------------------------------------------ ## Breakpoint (the resource)
    /// Represents the breakpoint specification, status and results.
    /// </summary>
    public class Breakpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action that the agent should perform when the code at the breakpoint location is hit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// The deadline for the breakpoint to stay in CANARY_ACTIVE state. The value is meaningless when the breakpoint
        /// is not in CANARY_ACTIVE state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canaryExpireTime")]
        public virtual object CanaryExpireTime { get; set; }

        /// <summary>
        /// Condition that triggers the breakpoint. The condition is a compound boolean expression composed using
        /// expressions in a programming language at the source location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>Time this breakpoint was created by the server in seconds resolution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Values of evaluated expressions at breakpoint time. The evaluated expressions appear in exactly the same
        /// order they are listed in the `expressions` field. The `name` field holds the original expression text, the
        /// `value` or `members` field holds the result of the evaluated expression. If the expression cannot be
        /// evaluated, the `status` inside the `Variable` will indicate an error and contain the error text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedExpressions")]
        public virtual System.Collections.Generic.IList<Variable> EvaluatedExpressions { get; set; }

        /// <summary>
        /// List of read-only expressions to evaluate at the breakpoint location. The expressions are composed using
        /// expressions in the programming language at the source location. If the breakpoint action is `LOG`, the
        /// evaluated expressions are included in log statements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressions")]
        public virtual System.Collections.Generic.IList<string> Expressions { get; set; }

        /// <summary>Time this breakpoint was finalized as seen by the server in seconds resolution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalTime")]
        public virtual object FinalTime { get; set; }

        /// <summary>Breakpoint identifier, unique in the scope of the debuggee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// When true, indicates that this is a final result and the breakpoint state will not change from here on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFinalState")]
        public virtual System.Nullable<bool> IsFinalState { get; set; }

        /// <summary>
        /// A set of custom breakpoint properties, populated by the agent, to be displayed to the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Breakpoint source location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual SourceLocation Location { get; set; }

        /// <summary>Indicates the severity of the log. Only relevant when action is `LOG`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLevel")]
        public virtual string LogLevel { get; set; }

        /// <summary>
        /// Only relevant when action is `LOG`. Defines the message to log when the breakpoint hits. The message may
        /// include parameter placeholders `$0`, `$1`, etc. These placeholders are replaced with the evaluated value of
        /// the appropriate expression. Expressions not referenced in `log_message_format` are not logged. Example:
        /// `Message received, id = $0, count = $1` with `expressions` = `[ message.id, message.count ]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logMessageFormat")]
        public virtual string LogMessageFormat { get; set; }

        /// <summary>
        /// The stack at breakpoint time, where stack_frames[0] represents the most recently entered function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackFrames")]
        public virtual System.Collections.Generic.IList<StackFrame> StackFrames { get; set; }

        /// <summary>The current state of the breakpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Breakpoint status. The status includes an error flag and a human readable message. This field is usually
        /// unset. The message can be either informational or an error message. Regardless, clients should always
        /// display the text message back to the user. Error status indicates complete failure of the breakpoint.
        /// Example (non-final state): `Still loading symbols...` Examples (final state): * `Invalid line number`
        /// referring to location * `Field f not found in class C` referring to condition
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual StatusMessage Status { get; set; }

        /// <summary>E-mail address of the user that created this breakpoint</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>
        /// The `variable_table` exists to aid with computation, memory and network traffic optimization. It enables
        /// storing a variable once and reference it from multiple variables, including variables stored in the
        /// `variable_table` itself. For example, the same `this` object, which may appear at many levels of the stack,
        /// can have all of its data stored once in this table. The stack frame variables then would hold only a
        /// reference to it. The variable `var_table_index` field is an index into this repeated field. The stored
        /// objects are nameless and get their name from the referencing variable. The effective variable is a merge of
        /// the referencing variable and the referenced variable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variableTable")]
        public virtual System.Collections.Generic.IList<Variable> VariableTable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CloudRepoSourceContext denotes a particular revision in a cloud repo (a repo hosted by the Google Cloud
    /// Platform).
    /// </summary>
    public class CloudRepoSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>The name of an alias (branch, tag, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasName")]
        public virtual string AliasName { get; set; }

        /// <summary>The ID of the repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoId")]
        public virtual RepoId RepoId { get; set; }

        /// <summary>A revision ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CloudWorkspaceId is a unique identifier for a cloud workspace. A cloud workspace is a place associated with a
    /// repo where modified files can be stored before they are committed.
    /// </summary>
    public class CloudWorkspaceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique name of the workspace within the repo. This is the name chosen by the client in the Source API's
        /// CreateWorkspace method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID of the repo containing the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoId")]
        public virtual RepoId RepoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A CloudWorkspaceSourceContext denotes a workspace at a particular snapshot.</summary>
    public class CloudWorkspaceSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the snapshot. An empty snapshot_id refers to the most recent snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotId")]
        public virtual string SnapshotId { get; set; }

        /// <summary>The ID of the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual CloudWorkspaceId WorkspaceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the debugged application. The application may include one or more replicated processes executing the
    /// same code. Each of these processes is attached with a debugger agent, carrying out the debugging commands.
    /// Agents attached to the same debuggee identify themselves as such by using exactly the same Debuggee message
    /// value when registering.
    /// </summary>
    public class Debuggee : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Version ID of the agent. Schema: `domain/language-platform/vmajor.minor` (for example
        /// `google.com/java-gcp/v1.1`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentVersion")]
        public virtual string AgentVersion { get; set; }

        /// <summary>Used when setting breakpoint canary for this debuggee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canaryMode")]
        public virtual string CanaryMode { get; set; }

        /// <summary>
        /// Human readable description of the debuggee. Including a human-readable project name, environment name and
        /// version information is recommended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// References to the locations and revisions of the source code used in the deployed application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extSourceContexts")]
        public virtual System.Collections.Generic.IList<ExtendedSourceContext> ExtSourceContexts { get; set; }

        /// <summary>Unique identifier for the debuggee generated by the controller service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// If set to `true`, indicates that the agent should disable itself and detach from the debuggee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDisabled")]
        public virtual System.Nullable<bool> IsDisabled { get; set; }

        /// <summary>
        /// If set to `true`, indicates that Controller service does not detect any activity from the debuggee agents
        /// and the application is possibly stopped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInactive")]
        public virtual System.Nullable<bool> IsInactive { get; set; }

        /// <summary>A set of custom debuggee properties, populated by the agent, to be displayed to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Project the debuggee is associated with. Use project number or id when registering a Google Cloud Platform
        /// project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>
        /// References to the locations and revisions of the source code used in the deployed application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceContexts")]
        public virtual System.Collections.Generic.IList<SourceContext> SourceContexts { get; set; }

        /// <summary>
        /// Human readable message to be displayed to the user about this debuggee. Absence of this field indicates no
        /// status. The message can be either informational or an error status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual StatusMessage Status { get; set; }

        /// <summary>
        /// Uniquifier to further distinguish the application. It is possible that different applications might have
        /// identical values in the debuggee message, thus, incorrectly identified as a single application by the
        /// Controller service. This field adds salt to further distinguish the application. Agents should consider
        /// seeding this field with value that identifies the code, binary, configuration and environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniquifier")]
        public virtual string Uniquifier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ExtendedSourceContext is a SourceContext combined with additional details describing the context.
    /// </summary>
    public class ExtendedSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any source context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual SourceContext Context { get; set; }

        /// <summary>Labels with user defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a message with parameters.</summary>
    public class FormatMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Format template for the message. The `format` uses placeholders `$0`, `$1`, etc. to reference parameters.
        /// `$$` can be used to denote the `$` character. Examples: * `Failed to load '$0' which helps debug $1 the
        /// first time it is loaded. Again, $0 is very important.` * `Please pay $$10 to use $0 instead of $1.`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Optional parameters to be embedded into the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<string> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SourceContext referring to a Gerrit project.</summary>
    public class GerritSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>The name of an alias (branch, tag, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasName")]
        public virtual string AliasName { get; set; }

        /// <summary>
        /// The full project name within the host. Projects may be nested, so "project/subproject" is a valid project
        /// name. The "repo name" is hostURI/project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerritProject")]
        public virtual string GerritProject { get; set; }

        /// <summary>The URI of a running Gerrit instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>A revision (commit) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for getting breakpoint information.</summary>
    public class GetBreakpointResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Complete breakpoint state. The fields `id` and `location` are guaranteed to be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakpoint")]
        public virtual Breakpoint Breakpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A GitSourceContext denotes a particular revision in a third party Git repository (e.g. GitHub).
    /// </summary>
    public class GitSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Git commit hash. required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Git repository URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing active breakpoints.</summary>
    public class ListActiveBreakpointsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of all active breakpoints. The fields `id` and `location` are guaranteed to be set on each breakpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakpoints")]
        public virtual System.Collections.Generic.IList<Breakpoint> Breakpoints { get; set; }

        /// <summary>
        /// A token that can be used in the next method call to block until the list of breakpoints changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextWaitToken")]
        public virtual string NextWaitToken { get; set; }

        /// <summary>
        /// If set to `true`, indicates that there is no change to the list of active breakpoints and the
        /// server-selected timeout has expired. The `breakpoints` field would be empty and should be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitExpired")]
        public virtual System.Nullable<bool> WaitExpired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing breakpoints.</summary>
    public class ListBreakpointsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of breakpoints matching the request. The fields `id` and `location` are guaranteed to be set on each
        /// breakpoint. The fields: `stack_frames`, `evaluated_expressions` and `variable_table` are cleared on each
        /// breakpoint regardless of its status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakpoints")]
        public virtual System.Collections.Generic.IList<Breakpoint> Breakpoints { get; set; }

        /// <summary>
        /// A wait token that can be used in the next call to `list` (REST) or `ListBreakpoints` (RPC) to block until
        /// the list of breakpoints has changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextWaitToken")]
        public virtual string NextWaitToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing debuggees.</summary>
    public class ListDebuggeesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of debuggees accessible to the calling user. The fields `debuggee.id` and `description` are guaranteed
        /// to be set. The `description` field is a human readable field provided by agents and can be displayed to
        /// users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debuggees")]
        public virtual System.Collections.Generic.IList<Debuggee> Debuggees { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Selects a repo using a Google Cloud Platform project ID (e.g. winged-cargo-31) and a repo name within that
    /// project.
    /// </summary>
    public class ProjectRepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The name of the repo. Leave empty for the default repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to register a debuggee.</summary>
    public class RegisterDebuggeeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Debuggee information to register. The fields `project`, `uniquifier`, `description` and
        /// `agent_version` of the debuggee must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debuggee")]
        public virtual Debuggee Debuggee { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for registering a debuggee.</summary>
    public class RegisterDebuggeeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique ID generated for the agent. Each RegisterDebuggee request will generate a new agent ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentId")]
        public virtual string AgentId { get; set; }

        /// <summary>
        /// Debuggee resource. The field `id` is guaranteed to be set (in addition to the echoed fields). If the field
        /// `is_disabled` is set to `true`, the agent should disable itself by removing all breakpoints and detaching
        /// from the application. It should however continue to poll `RegisterDebuggee` until reenabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debuggee")]
        public virtual Debuggee Debuggee { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unique identifier for a cloud repo.</summary>
    public class RepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A combination of a project ID and a repo name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectRepoId")]
        public virtual ProjectRepoId ProjectRepoId { get; set; }

        /// <summary>A server-assigned, globally unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for setting a breakpoint.</summary>
    public class SetBreakpointResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Breakpoint resource. The field `id` is guaranteed to be set (in addition to the echoed fields).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakpoint")]
        public virtual Breakpoint Breakpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A SourceContext is a reference to a tree of files. A SourceContext together with a path point to a unique
    /// revision of a single file or directory.
    /// </summary>
    public class SourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A SourceContext referring to a revision in a cloud repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRepo")]
        public virtual CloudRepoSourceContext CloudRepo { get; set; }

        /// <summary>A SourceContext referring to a snapshot in a cloud workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudWorkspace")]
        public virtual CloudWorkspaceSourceContext CloudWorkspace { get; set; }

        /// <summary>A SourceContext referring to a Gerrit project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerrit")]
        public virtual GerritSourceContext Gerrit { get; set; }

        /// <summary>A SourceContext referring to any third party Git repo (e.g. GitHub).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("git")]
        public virtual GitSourceContext Git { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a location in the source code.</summary>
    public class SourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Column within a line. The first column in a line as the value `1`. Agents that do not support setting
        /// breakpoints on specific columns ignore this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual System.Nullable<int> Column { get; set; }

        /// <summary>Line inside the file. The first line in the file has the value `1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<int> Line { get; set; }

        /// <summary>Path to the source file within the source context of the target binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a stack frame context.</summary>
    public class StackFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set of arguments passed to this function. Note that this might not be populated for all stack frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Collections.Generic.IList<Variable> Arguments { get; set; }

        /// <summary>Demangled function name at the call site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>
        /// Set of local variables at the stack frame location. Note that this might not be populated for all stack
        /// frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locals")]
        public virtual System.Collections.Generic.IList<Variable> Locals { get; set; }

        /// <summary>Source location of the call site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual SourceLocation Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a contextual status message. The message can indicate an error or informational status, and refer to
    /// specific parts of the containing object. For example, the `Breakpoint.status` field can indicate an error
    /// referring to the `BREAKPOINT_SOURCE_LOCATION` with the message `Location not found`.
    /// </summary>
    public class StatusMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status message text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual FormatMessage Description { get; set; }

        /// <summary>Distinguishes errors from informational messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isError")]
        public virtual System.Nullable<bool> IsError { get; set; }

        /// <summary>Reference to which the message applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refersTo")]
        public virtual string RefersTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update an active breakpoint.</summary>
    public class UpdateActiveBreakpointRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Updated breakpoint information. The field `id` must be set. The agent must echo all Breakpoint
        /// specification fields in the update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakpoint")]
        public virtual Breakpoint Breakpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response for updating an active breakpoint. The message is defined to allow future extensions.
    /// </summary>
    public class UpdateActiveBreakpointResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a variable or an argument possibly of a compound object type. Note how the following variables are
    /// represented: 1) A simple variable: int x = 5 { name: "x", value: "5", type: "int" } // Captured variable 2) A
    /// compound object: struct T { int m1; int m2; }; T x = { 3, 7 }; { // Captured variable name: "x", type: "T",
    /// members { name: "m1", value: "3", type: "int" }, members { name: "m2", value: "7", type: "int" } } 3) A pointer
    /// where the pointee was captured: T x = { 3, 7 }; T* p = &amp;amp;x; { // Captured variable name: "p", type: "T*",
    /// value: "0x00500500", members { name: "m1", value: "3", type: "int" }, members { name: "m2", value: "7", type:
    /// "int" } } 4) A pointer where the pointee was not captured: T* p = new T; { // Captured variable name: "p", type:
    /// "T*", value: "0x00400400" status { is_error: true, description { format: "unavailable" } } } The status should
    /// describe the reason for the missing value, such as ``, ``, ``. Note that a null pointer should not have members.
    /// 5) An unnamed value: int* p = new int(7); { // Captured variable name: "p", value: "0x00500500", type: "int*",
    /// members { value: "7", type: "int" } } 6) An unnamed pointer where the pointee was not captured: int* p = new
    /// int(7); int** pp = &amp;amp;p; { // Captured variable name: "pp", value: "0x00500500", type: "int**", members {
    /// value: "0x00400400", type: "int*" status { is_error: true, description: { format: "unavailable" } } } } } To
    /// optimize computation, memory and network traffic, variables that repeat in the output multiple times can be
    /// stored once in a shared variable table and be referenced using the `var_table_index` field. The variables stored
    /// in the shared table are nameless and are essentially a partition of the complete variable. To reconstruct the
    /// complete variable, merge the referencing variable with the referenced variable. When using the shared variable
    /// table, the following variables: T x = { 3, 7 }; T* p = &amp;amp;x; T&amp;amp; r = x; { name: "x",
    /// var_table_index: 3, type: "T" } // Captured variables { name: "p", value "0x00500500", type="T*",
    /// var_table_index: 3 } { name: "r", type="T&amp;amp;", var_table_index: 3 } { // Shared variable table entry #3:
    /// members { name: "m1", value: "3", type: "int" }, members { name: "m2", value: "7", type: "int" } } Note that the
    /// pointer address is stored with the referencing variable and not with the referenced variable. This allows the
    /// referenced variable to be shared between pointers and references. The type field is optional. The debugger agent
    /// may or may not support it.
    /// </summary>
    public class Variable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Members contained or pointed to by the variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<Variable> Members { get; set; }

        /// <summary>Name of the variable, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Status associated with the variable. This field will usually stay unset. A status of a single variable only
        /// applies to that variable or expression. The rest of breakpoint data still remains valid. Variables might be
        /// reported in error state even when breakpoint is not in final state. The message may refer to variable name
        /// with `refers_to` set to `VARIABLE_NAME`. Alternatively `refers_to` will be set to `VARIABLE_VALUE`. In
        /// either case variable value and members will be unset. Example of error message applied to name: `Invalid
        /// expression syntax`. Example of information message applied to value: `Not captured`. Examples of error
        /// message applied to value: * `Malformed string`, * `Field f not found in class C` * `Null pointer
        /// dereference`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual StatusMessage Status { get; set; }

        /// <summary>
        /// Variable type (e.g. `MyClass`). If the variable is split with `var_table_index`, `type` goes next to
        /// `value`. The interpretation of a type is agent specific. It is recommended to include the dynamic type
        /// rather than a static type of an object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Simple value of the variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// Reference to a variable in the shared variable table. More than one variable can reference the same variable
        /// in the table. The `var_table_index` field is an index into `variable_table` in Breakpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("varTableIndex")]
        public virtual System.Nullable<int> VarTableIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
