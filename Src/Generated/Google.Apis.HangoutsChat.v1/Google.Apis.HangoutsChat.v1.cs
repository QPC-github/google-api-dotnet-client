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

namespace Google.Apis.HangoutsChat.v1
{
    /// <summary>The HangoutsChat Service.</summary>
    public class HangoutsChatService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public HangoutsChatService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public HangoutsChatService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Dms = new DmsResource(this);
            Media = new MediaResource(this);
            Rooms = new RoomsResource(this);
            Spaces = new SpacesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "chat";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://chat.googleapis.com/";
        #else
            "https://chat.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://chat.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Dms resource.</summary>
        public virtual DmsResource Dms { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Rooms resource.</summary>
        public virtual RoomsResource Rooms { get; }

        /// <summary>Gets the Spaces resource.</summary>
        public virtual SpacesResource Spaces { get; }
    }

    /// <summary>A base abstract class for HangoutsChat requests.</summary>
    public abstract class HangoutsChatBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new HangoutsChatBaseServiceRequest instance.</summary>
        protected HangoutsChatBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes HangoutsChat parameter list.</summary>
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

    /// <summary>The "dms" collection of methods.</summary>
    public class DmsResource
    {
        private const string Resource = "dms";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DmsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Conversations = new ConversationsResource(service);
        }

        /// <summary>Gets the Conversations resource.</summary>
        public virtual ConversationsResource Conversations { get; }

        /// <summary>The "conversations" collection of methods.</summary>
        public class ConversationsResource
        {
            private const string Resource = "conversations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConversationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
            /// </param>
            public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
            {
                return new MessagesRequest(service, body, parent);
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Messages request.</summary>
                public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A unique request ID for this message. Specifying an existing request ID returns the
                /// message created with that ID instead of creating a new message.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>
                /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
                /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a
                /// given `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the
                /// same thread.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ThreadKey { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "messages";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes Messages parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^dms/[^/]+/conversations/[^/]+$",
                    });
                    RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "threadKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
        /// </param>
        public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new MessagesRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Messages request.</summary>
            public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. A unique request ID for this message. Specifying an existing request ID returns the message
            /// created with that ID instead of creating a new message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>
            /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
            /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a given
            /// `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the same
            /// thread.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "messages";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/messages";

            /// <summary>Initializes Messages parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^dms/[^/]+$",
                });
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
        /// </param>
        public virtual WebhooksRequest Webhooks(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new WebhooksRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class WebhooksRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Webhooks request.</summary>
            public WebhooksRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. A unique request ID for this message. Specifying an existing request ID returns the message
            /// created with that ID instead of creating a new message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>
            /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
            /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a given
            /// `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the same
            /// thread.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "webhooks";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/webhooks";

            /// <summary>Initializes Webhooks parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^dms/[^/]+$",
                });
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        public virtual DownloadRequest Download(string resourceName)
        {
            return new DownloadRequest(service, resourceName);
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        public class DownloadRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Media>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/media/{+resourceName}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            #if !NET40
            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
            #endif
        }
    }

    /// <summary>The "rooms" collection of methods.</summary>
    public class RoomsResource
    {
        private const string Resource = "rooms";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RoomsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Conversations = new ConversationsResource(service);
        }

        /// <summary>Gets the Conversations resource.</summary>
        public virtual ConversationsResource Conversations { get; }

        /// <summary>The "conversations" collection of methods.</summary>
        public class ConversationsResource
        {
            private const string Resource = "conversations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConversationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
            /// </param>
            public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
            {
                return new MessagesRequest(service, body, parent);
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Messages request.</summary>
                public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A unique request ID for this message. Specifying an existing request ID returns the
                /// message created with that ID instead of creating a new message.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>
                /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
                /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a
                /// given `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the
                /// same thread.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ThreadKey { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "messages";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes Messages parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^rooms/[^/]+/conversations/[^/]+$",
                    });
                    RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "threadKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
        /// </param>
        public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new MessagesRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Messages request.</summary>
            public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. A unique request ID for this message. Specifying an existing request ID returns the message
            /// created with that ID instead of creating a new message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>
            /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
            /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a given
            /// `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the same
            /// thread.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "messages";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/messages";

            /// <summary>Initializes Messages parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^rooms/[^/]+$",
                });
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
        /// </param>
        public virtual WebhooksRequest Webhooks(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new WebhooksRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class WebhooksRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Webhooks request.</summary>
            public WebhooksRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. A unique request ID for this message. Specifying an existing request ID returns the message
            /// created with that ID instead of creating a new message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>
            /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
            /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a given
            /// `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the same
            /// thread.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "webhooks";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/webhooks";

            /// <summary>Initializes Webhooks parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^rooms/[^/]+$",
                });
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "spaces" collection of methods.</summary>
    public class SpacesResource
    {
        private const string Resource = "spaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SpacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Members = new MembersResource(service);
            Messages = new MessagesResource(service);
        }

        /// <summary>Gets the Members resource.</summary>
        public virtual MembersResource Members { get; }

        /// <summary>The "members" collection of methods.</summary>
        public class MembersResource
        {
            private const string Resource = "members";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MembersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns a membership. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the membership to retrieve. Format: spaces/{space}/members/{member}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns a membership. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Membership>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the membership to retrieve. Format: spaces/{space}/members/{member}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/members/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists human memberships in a space. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the space for which to fetch a membership list. Format: spaces/{space}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists human memberships in a space. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListMembershipsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the space for which to fetch a membership list. Format:
                /// spaces/{space}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Requested page size. The value is capped at 1000. Server may return fewer results than requested. If
                /// unspecified, server will default to 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/members";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Messages resource.</summary>
        public virtual MessagesResource Messages { get; }

        /// <summary>The "messages" collection of methods.</summary>
        public class MessagesResource
        {
            private const string Resource = "messages";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MessagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Attachments = new AttachmentsResource(service);
            }

            /// <summary>Gets the Attachments resource.</summary>
            public virtual AttachmentsResource Attachments { get; }

            /// <summary>The "attachments" collection of methods.</summary>
            public class AttachmentsResource
            {
                private const string Resource = "attachments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AttachmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the metadata of a message attachment. The attachment data is fetched using the media API.
                /// Requires [service account
                /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the attachment, in the form "spaces/*/messages/*/attachments/*".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the metadata of a message attachment. The attachment data is fetched using the media API.
                /// Requires [service account
                /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
                /// </summary>
                public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Attachment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the attachment, in the form "spaces/*/messages/*/attachments/*".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^spaces/[^/]+/messages/[^/]+/attachments/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
            /// </param>
            public virtual CreateRequest Create(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            public class CreateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A unique request ID for this message. Specifying an existing request ID returns the
                /// message created with that ID instead of creating a new message.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>
                /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
                /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a
                /// given `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the
                /// same thread.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ThreadKey { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                    RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "threadKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the message to be deleted, in the form "spaces/*/messages/*" Example:
            /// spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            public class DeleteRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the message to be deleted, in the form "spaces/*/messages/*" Example:
                /// spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the message to be retrieved, in the form "spaces/*/messages/*". Example:
            /// spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the message to be retrieved, in the form "spaces/*/messages/*". Example:
                /// spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Updates a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Resource name in the form `spaces/*/messages/*`. Example:
            /// `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.HangoutsChat.v1.Data.Message body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>
            /// Updates a message. Requires [service account
            /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
            /// </summary>
            public class UpdateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name in the form `spaces/*/messages/*`. Example:
                /// `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The field paths to be updated, comma separated if there are multiple. Currently supported
                /// field paths: * text * cards * attachment
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Returns a space. Requires [service account
        /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form "spaces/*". Format: spaces/{space}
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Returns a space. Requires [service account
        /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
        /// </summary>
        public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Space>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Resource name of the space, in the form "spaces/*". Format: spaces/{space}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists spaces the caller is a member of. Requires [service account
        /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists spaces the caller is a member of. Requires [service account
        /// authentication](https://developers.google.com/chat/api/guides/auth/service-accounts).
        /// </summary>
        public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListSpacesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Requested page size. The value is capped at 1000. Server may return fewer results than requested. If
            /// unspecified, server will default to 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/spaces";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA
        /// </param>
        public virtual WebhooksRequest Webhooks(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new WebhooksRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class WebhooksRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Webhooks request.</summary>
            public WebhooksRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAAAAAAAA</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. A unique request ID for this message. Specifying an existing request ID returns the message
            /// created with that ID instead of creating a new message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>
            /// Optional. Opaque thread identifier. To start or add to a thread, create a message and specify a
            /// `threadKey` instead of thread.name. (Setting thread.name has no effect.) The first message with a given
            /// `threadKey` starts a new thread. Subsequent messages with the same `threadKey` post into the same
            /// thread.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "webhooks";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/webhooks";

            /// <summary>Initializes Webhooks parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.HangoutsChat.v1.Data
{
    /// <summary>
    /// List of string parameters to supply when the action method is invoked. For example, consider three snooze
    /// buttons: snooze now, snooze 1 day, snooze next week. You might use action method = snooze(), passing the snooze
    /// type and snooze time in the list of string parameters.
    /// </summary>
    public class ActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parameter for the action script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters that a Chat app can use to configure how it's response is posted.</summary>
    public class ActionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. A response to an event related to a
        /// [dialog](https://developers.google.com/chat/how-tos/dialogs). Must be accompanied by `ResponseType.Dialog`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogAction")]
        public virtual DialogAction DialogAction { get; set; }

        /// <summary>Input only. The type of Chat app response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Input only. URL for users to auth or config. (Only for REQUEST_CONFIG response types.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the status for a request to either invoke or submit a
    /// [dialog](https://developers.google.com/chat/how-tos/dialogs).
    /// </summary>
    public class ActionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusCode")]
        public virtual string StatusCode { get; set; }

        /// <summary>
        /// The message to send users about the status of their request. If unset, a generic message based on the
        /// `status_code` is sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userFacingMessage")]
        public virtual string UserFacingMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotations associated with the plain-text body of the message. Example plain-text message body: ``` Hello
    /// @FooBot how are you!" ``` The corresponding annotations metadata: ``` "annotations":[{ "type":"USER_MENTION",
    /// "startIndex":6, "length":7, "userMention": { "user": { "name":"users/107946847022116401880",
    /// "displayName":"FooBot", "avatarUrl":"https://goo.gl/aeDtrS", "type":"BOT" }, "type":"MENTION" } }] ```
    /// </summary>
    public class Annotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Length of the substring in the plain-text message body this annotation corresponds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>The metadata for a slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slashCommand")]
        public virtual SlashCommandMetadata SlashCommand { get; set; }

        /// <summary>
        /// Start index (0-based, inclusive) in the plain-text message body this annotation corresponds to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The type of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The metadata of user mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userMention")]
        public virtual UserMentionMetadata UserMention { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An attachment in Google Chat.</summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A reference to the attachment data. This is used with the media API to download the attachment data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentDataRef")]
        public virtual AttachmentDataRef AttachmentDataRef { get; set; }

        /// <summary>The original file name for the content, not the full path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentName")]
        public virtual string ContentName { get; set; }

        /// <summary>The content type (MIME type) of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// Output only. The download URL which should be used to allow a human user to download the attachment. Chat
        /// apps should not use this URL to download attachment content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUri")]
        public virtual string DownloadUri { get; set; }

        /// <summary>A reference to the drive attachment. This is used with the Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveDataRef")]
        public virtual DriveDataRef DriveDataRef { get; set; }

        /// <summary>Resource name of the attachment, in the form "spaces/*/messages/*/attachments/*".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The source of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Output only. The thumbnail URL which should be used to preview the attachment to a human user. Chat apps
        /// should not use this URL to download attachment content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUri")]
        public virtual string ThumbnailUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to the data of an attachment.</summary>
    public class AttachmentDataRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the attachment data. This is used with the media API to download the attachment data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button. Can be a text button or an image button.</summary>
    public class Button : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A button with image and onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageButton")]
        public virtual ImageButton ImageButton { get; set; }

        /// <summary>A button with text and onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textButton")]
        public virtual TextButton TextButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A card is a UI element that can contain UI widgets such as texts, images.</summary>
    public class Card : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actions of this card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<CardAction> CardActions { get; set; }

        /// <summary>The header of the card. A header usually contains a title and an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual CardHeader Header { get; set; }

        /// <summary>Name of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Sections are separated by a line divider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<Section> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card action is the action associated with the card. For an invoice card, a typical action would be: delete
    /// invoice, email invoice or open the invoice in browser.
    /// </summary>
    public class CardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label used to be displayed in the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        /// <summary>The onclick action for this action item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The image's type (e.g. square border or circular border).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageStyle")]
        public virtual string ImageStyle { get; set; }

        /// <summary>The URL of the image in the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The subtitle of the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// The title must be specified. The header has a fixed height: if both a title and subtitle is specified, each
        /// will take up 1 line. If only the title is specified, it will take up both lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON payload of error messages. If the Cloud Logging API is enabled, these error messages are logged to [Google
    /// Cloud Logging](https://cloud.google.com/logging/docs).
    /// </summary>
    public class ChatAppLogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The deployment that caused the error. For Chat apps built in Apps Script, this is the deployment ID defined
        /// by Apps Script.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>The unencrypted `callback_method` name that was running when the error was encountered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentFunction")]
        public virtual string DeploymentFunction { get; set; }

        /// <summary>The error code and message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to/from
    /// color representations in various languages over compactness. For example, the fields of this representation can
    /// be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't carry information about the
    /// absolute color space that should be used to interpret the RGB value (e.g. sRGB, Adobe RGB, DCI-P3, BT.2020,
    /// etc.). By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most 1e-5. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents information about the user's client, such as locale, host app, and platform. For Chat apps,
    /// `CommonEventObject` includes data submitted by users interacting with cards, like data entered in
    /// [dialogs](https://developers.google.com/chat/how-tos/dialogs).
    /// </summary>
    public class CommonEventObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map containing the current values of the widgets in a card. The map keys are the string IDs assigned to
        /// each widget, and the values represent inputs to the widget. Depending on the input data type, a different
        /// object represents each input: For single-value widgets, `StringInput`. For multi-value widgets, an array of
        /// `StringInput` objects. For a date-time picker, a `DateTimeInput`. For a date-only picker, a `DateInput`. For
        /// a time-only picker, a `TimeInput`. Corresponds with the data entered by a user on a card in a
        /// [dialog](https://developers.google.com/chat/how-tos/dialogs).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formInputs")]
        public virtual System.Collections.Generic.IDictionary<string, Inputs> FormInputs { get; set; }

        /// <summary>
        /// The hostApp enum which indicates the app the add-on is invoked from. Always `CHAT` for Chat apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostApp")]
        public virtual string HostApp { get; set; }

        /// <summary>Name of the invoked function associated with the widget. Only set for Chat apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invokedFunction")]
        public virtual string InvokedFunction { get; set; }

        /// <summary>
        /// Custom [parameters](/chat/api/reference/rest/v1/cards#ActionParameter) passed to the invoked function. Both
        /// keys and values must be strings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// The platform enum which indicates the platform where the event originates (`WEB`, `IOS`, or `ANDROID`). Not
        /// supported by Chat apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The timezone ID and offset from Coordinated Universal Time (UTC).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>
        /// The full `locale.displayName` in the format of [ISO 639 language code]-[ISO 3166 country/region code] such
        /// as "en-US". Not supported by Chat apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLocale")]
        public virtual string UserLocale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Date input values. Not supported by Chat apps.</summary>
    public class DateInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time since epoch time, in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msSinceEpoch")]
        public virtual System.Nullable<long> MsSinceEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Date and time input values. Not supported by Chat apps.</summary>
    public class DateTimeInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the `datetime` input includes a calendar date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDate")]
        public virtual System.Nullable<bool> HasDate { get; set; }

        /// <summary>Whether the `datetime` input includes a timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasTime")]
        public virtual System.Nullable<bool> HasTime { get; set; }

        /// <summary>Time since epoch time, in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msSinceEpoch")]
        public virtual System.Nullable<long> MsSinceEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Chat events.</summary>
    public class DeprecatedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The form action data associated with an interactive card that was clicked. Only populated for CARD_CLICKED
        /// events. See the [Interactive Cards guide](/chat/how-tos/cards-onclick) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FormAction Action { get; set; }

        /// <summary>
        /// Represents information about the user's client, such as locale, host app, and platform. For Chat apps,
        /// `CommonEventObject` includes information submitted by users interacting with
        /// [dialogs](https://developers.google.com/chat/how-tos/dialogs), like data entered on a card.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual CommonEventObject Common { get; set; }

        /// <summary>
        /// The URL the Chat app should redirect the user to after they have completed an authorization or configuration
        /// flow outside of Google Chat. See the [Authorizing access to 3p services guide](/chat/how-tos/auth-3p) for
        /// more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configCompleteRedirectUrl")]
        public virtual string ConfigCompleteRedirectUrl { get; set; }

        /// <summary>The type of [dialog](https://developers.google.com/chat/how-tos/dialogs) event received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogEventType")]
        public virtual string DialogEventType { get; set; }

        /// <summary>The timestamp indicating when the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// True when the event is related to [dialogs](https://developers.google.com/chat/how-tos/dialogs).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDialogEvent")]
        public virtual System.Nullable<bool> IsDialogEvent { get; set; }

        /// <summary>The message that triggered the event, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The space in which the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>
        /// The Chat app-defined key for the thread related to the event. See the thread_key field of the
        /// `spaces.message.create` request for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadKey")]
        public virtual string ThreadKey { get; set; }

        /// <summary>
        /// A secret value that legacy Chat apps can use to verify if a request is from Google. Google randomly
        /// generates the token, and its value remains static. You can obtain, revoke, or regenerate the token from the
        /// [Chat API configuration page](https://console.cloud.google.com/apis/api/chat.googleapis.com/hangouts-chat)
        /// in the Google Cloud Console. Modern Chat apps don't use this field. It is absent from API responses and the
        /// [Chat API configuration page](https://console.cloud.google.com/apis/api/chat.googleapis.com/hangouts-chat).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The type of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The user that triggered the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper around the card body of the dialog.</summary>
    public class Dialog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. Body of the dialog, which is rendered in a modal. Google Chat apps do not support the following
        /// card entities: `DateTimePicker`, `OnChangeAction`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual GoogleAppsCardV1Card Body { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains a [dialog](https://developers.google.com/chat/how-tos/dialogs) and request status code.
    /// </summary>
    public class DialogAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. Status for a request to either invoke or submit a
        /// [dialog](https://developers.google.com/chat/how-tos/dialogs). Displays a status and message to users, if
        /// necessary. For example, in case of an error or success.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionStatus")]
        public virtual ActionStatus ActionStatus { get; set; }

        /// <summary>Input only. [Dialog](https://developers.google.com/chat/how-tos/dialogs) for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialog")]
        public virtual Dialog Dialog { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to the data of a drive attachment.</summary>
    public class DriveDataRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id for the drive file, for use with the Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFileId")]
        public virtual string DriveFileId { get; set; }

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
    /// A form action describes the behavior when the form is submitted. For example, an Apps Script can be invoked to
    /// handle the form.
    /// </summary>
    public class FormAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The method name is used to identify which part of the form triggered the form submission. This information
        /// is echoed back to the Chat app as part of the card click event. The same method name can be used for several
        /// elements that trigger a common behavior if desired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMethodName")]
        public virtual string ActionMethodName { get; set; }

        /// <summary>List of action parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<ActionParameter> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An action that describes the behavior when the form is submitted. For example, an Apps Script can be invoked to
    /// handle the form.
    /// </summary>
    public class GoogleAppsCardV1Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apps Script function to invoke when the containing element is clicked/activated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>
        /// Specifies the loading indicator that the action displays while making the call to the action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadIndicator")]
        public virtual string LoadIndicator { get; set; }

        /// <summary>List of action parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1ActionParameter> Parameters { get; set; }

        /// <summary>
        /// Indicates whether form values persist after the action. The default value is `false`. If `true`, form values
        /// remain after the action is triggered. When using
        /// [LoadIndicator.NONE](workspace/add-ons/reference/rpc/google.apps.card.v1#loadindicator) for actions,
        /// `persist_values` = `true`is recommended, as it ensures that any changes made by the user after form or on
        /// change actions are sent to the server are not overwritten by the response. If `false`, the form values are
        /// cleared when the action is triggered. When `persist_values` is set to `false`, it is strongly recommended
        /// that the card use [LoadIndicator.SPINNER](workspace/add-ons/reference/rpc/google.apps.card.v1#loadindicator)
        /// for all actions, as this locks the UI to ensure no changes are made by the user while the action is being
        /// processed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistValues")]
        public virtual System.Nullable<bool> PersistValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// List of string parameters to supply when the action method is invoked. For example, consider three snooze
    /// buttons: snooze now, snooze 1 day, snooze next week. You might use action method = snooze(), passing the snooze
    /// type and snooze time in the list of string parameters.
    /// </summary>
    public class GoogleAppsCardV1ActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parameter for the action script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the complete border style applied to widgets.</summary>
    public class GoogleAppsCardV1BorderStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The corner radius for the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cornerRadius")]
        public virtual System.Nullable<int> CornerRadius { get; set; }

        /// <summary>The colors to use when the type is `BORDER_TYPE_STROKE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strokeColor")]
        public virtual Color StrokeColor { get; set; }

        /// <summary>The border type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button. Can be a text button or an image button.</summary>
    public class GoogleAppsCardV1Button : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The alternative text used for accessibility. Has no effect when an icon is set; use `icon.alt_text` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>If set, the button is filled with a solid background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>
        /// If `true`, the button is displayed in a disabled state and doesn't respond to user actions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The icon image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual GoogleAppsCardV1Icon Icon { get; set; }

        /// <summary>The action to perform when the button is clicked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The text of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of buttons layed out horizontally.</summary>
    public class GoogleAppsCardV1ButtonList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of buttons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Button> Buttons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card is a UI element that can contain UI widgets such as text and images. For more information, see Cards .
    /// For example, the following JSON creates a card that has a header with the name, position, icons, and link for a
    /// contact, followed by a section with contact information like email and phone number. ``` { "header": { "title":
    /// "Sasha", "subtitle": "Software Engineer", "imageStyle": "ImageStyle.AVATAR", "imageUrl":
    /// "https://example.com/sasha.png", "imageAltText": "Avatar for Sasha" }, "sections" : [ { "header": "Contact
    /// Info", "widgets": [ { "decorated_text": { "icon": { "knownIcon": "EMAIL" }, "content": "sasha@example.com" } },
    /// { "decoratedText": { "icon": { "knownIcon": "PERSON" }, "content": "Online" } }, { "decoratedText": { "icon": {
    /// "knownIcon": "PHONE" }, "content": "+1 (555) 555-1234" } }, { "buttons": [ { "textButton": { "text": "Share", },
    /// "onClick": { "openLink": { "url": "https://example.com/share" } } }, { "textButton": { "text": "Edit", },
    /// "onClick": { "action": { "function": "goToView", "parameters": [ { "key": "viewType", "value": "EDIT" } ],
    /// "loadIndicator": "LoadIndicator.SPINNER" } } } ] } ], "collapsible": true, "uncollapsibleWidgetsCount": 3 } ],
    /// "cardActions": [ { "actionLabel": "Send Feedback", "onClick": { "openLink": { "url":
    /// "https://example.com/feedback" } } } ], "name": "contact-card-K3wB6arF2H9L" } ```
    /// </summary>
    public class GoogleAppsCardV1Card : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The card's actions. Actions are added to the card's generated toolbar menu. For example, the following JSON
        /// constructs a card action menu with Settings and Send Feedback options: ``` "card_actions": [ {
        /// "actionLabel": "Settings", "onClick": { "action": { "functionName": "goToView", "parameters": [ { "key":
        /// "viewType", "value": "SETTING" } ], "loadIndicator": "LoadIndicator.SPINNER" } } }, { "actionLabel": "Send
        /// Feedback", "onClick": { "openLink": { "url": "https://example.com/feedback" } } } ] ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1CardAction> CardActions { get; set; }

        /// <summary>The display style for `peekCardHeader`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayStyle")]
        public virtual string DisplayStyle { get; set; }

        /// <summary>The fixed footer shown at the bottom of this card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedFooter")]
        public virtual GoogleAppsCardV1CardFixedFooter FixedFooter { get; set; }

        /// <summary>The header of the card. A header usually contains a title and an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual GoogleAppsCardV1CardHeader Header { get; set; }

        /// <summary>Name of the card. Used as a card identifier in card navigation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// When displaying contextual content, the peek card header acts as a placeholder so that the user can navigate
        /// forward between the homepage cards and the contextual cards.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peekCardHeader")]
        public virtual GoogleAppsCardV1CardHeader PeekCardHeader { get; set; }

        /// <summary>Sections are separated by a line divider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Section> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card action is the action associated with the card. For example, an invoice card might include actions such as
    /// delete invoice, email invoice, or open the invoice in a browser.
    /// </summary>
    public class GoogleAppsCardV1CardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label that displays as the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        /// <summary>The `onClick` action for this action item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A persistent (sticky) footer that is added to the bottom of the card.</summary>
    public class GoogleAppsCardV1CardFixedFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The primary button of the fixed footer. The button must be a text button with text and color set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryButton")]
        public virtual GoogleAppsCardV1Button PrimaryButton { get; set; }

        /// <summary>
        /// The secondary button of the fixed footer. The button must be a text button with text and color set.
        /// `primaryButton` must be set if `secondaryButton` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryButton")]
        public virtual GoogleAppsCardV1Button SecondaryButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a card header.</summary>
    public class GoogleAppsCardV1CardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image which is used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAltText")]
        public virtual string ImageAltText { get; set; }

        /// <summary>The image's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>The URL of the image in the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The subtitle of the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// Required. The title of the card header. The header has a fixed height: if both a title and subtitle are
        /// specified, each takes up one line. If only the title is specified, it takes up both lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The widget that lets users to specify a date and time. Not supported by Google Chat apps.</summary>
    public class GoogleAppsCardV1DateTimePicker : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label for the field that displays to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The name of the text input that's used in `formInput`, and uniquely identifies this input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Triggered when the user clicks Save or Clear from the date/time picker dialog. This is only triggered if the
        /// value changed as a result of the Save/Clear operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>
        /// The number representing the time zone offset from UTC, in minutes. If set, the `value_ms_epoch` is displayed
        /// in the specified time zone. If not set, it uses the user's time zone setting on the client side.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezoneOffsetDate")]
        public virtual System.Nullable<int> TimezoneOffsetDate { get; set; }

        /// <summary>The type of the date/time picker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The value to display as the default value before user input or previous user input. It is represented in
        /// milliseconds (Epoch time). For `DATE_AND_TIME` type, the full epoch value is used. For `DATE_ONLY` type,
        /// only date of the epoch time is used. For `TIME_ONLY` type, only time of the epoch time is used. For example,
        /// you can set epoch time to `3 * 60 * 60 * 1000` to represent 3am.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMsEpoch")]
        public virtual System.Nullable<long> ValueMsEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A widget that displays text with optional decorations such as a label above or below the text, an icon in front
    /// of the text, a selection widget or a button after the text.
    /// </summary>
    public class GoogleAppsCardV1DecoratedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The formatted text label that shows below the main text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        /// <summary>A button that can be clicked to trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual GoogleAppsCardV1Button Button { get; set; }

        /// <summary>An icon displayed after the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIcon")]
        public virtual GoogleAppsCardV1Icon EndIcon { get; set; }

        /// <summary>Deprecated in favor of start_icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual GoogleAppsCardV1Icon Icon { get; set; }

        /// <summary>Only the top and bottom label and content region are clickable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The icon displayed in front of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIcon")]
        public virtual GoogleAppsCardV1Icon StartIcon { get; set; }

        /// <summary>A switch widget can be clicked to change its state or trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("switchControl")]
        public virtual GoogleAppsCardV1SwitchControl SwitchControl { get; set; }

        /// <summary>Required. The main widget formatted text. See Text formatting for details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The formatted text label that shows above the main text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>
        /// The wrap text setting. If `true`, the text is wrapped and displayed in multiline. Otherwise, the text is
        /// truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrapText")]
        public virtual System.Nullable<bool> WrapText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A divider that appears in between widgets.</summary>
    public class GoogleAppsCardV1Divider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Grid widget that displays items in a configurable grid layout.</summary>
    public class GoogleAppsCardV1Grid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The border style to apply to each grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual GoogleAppsCardV1BorderStyle BorderStyle { get; set; }

        /// <summary>
        /// The number of columns to display in the grid. A default value is used if this field isn't specified, and
        /// that default value is different depending on where the grid is shown (dialog versus companion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnCount")]
        public virtual System.Nullable<int> ColumnCount { get; set; }

        /// <summary>The items to display in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1GridItem> Items { get; set; }

        /// <summary>
        /// This callback is reused by each individual grid item, but with the item's identifier and index in the items
        /// list added to the callback's parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The text that displays in the grid header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single item in the grid layout.</summary>
    public class GoogleAppsCardV1GridItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A user-specified identifier for this grid item. This identifier is returned in the parent Grid's onClick
        /// callback parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The image that displays in the grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleAppsCardV1ImageComponent Image { get; set; }

        /// <summary>The layout to use for the grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual string Layout { get; set; }

        /// <summary>The grid item's subtitle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>The horizontal alignment of the grid item's text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAlignment")]
        public virtual string TextAlignment { get; set; }

        /// <summary>The grid item's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleAppsCardV1Icon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The description of the icon, used for accessibility. The default value is provided if you don't specify one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The crop style applied to the image. In some cases, applying a `CIRCLE` crop causes the image to be drawn
        /// larger than a standard icon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>The icon specified by the string name of a list of known icons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownIcon")]
        public virtual string KnownIcon { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image that is specified by a URL and can have an `onClick` action.</summary>
    public class GoogleAppsCardV1Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image, used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>An image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The action triggered by an `onClick` event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an image.</summary>
    public class GoogleAppsCardV1ImageComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accessibility label for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>The border style to apply to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual GoogleAppsCardV1BorderStyle BorderStyle { get; set; }

        /// <summary>The crop style to apply to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropStyle")]
        public virtual GoogleAppsCardV1ImageCropStyle CropStyle { get; set; }

        /// <summary>The image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the crop style applied to an image.</summary>
    public class GoogleAppsCardV1ImageCropStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The aspect ratio to use if the crop type is `RECTANGLE_CUSTOM`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The crop type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the response to an `onClick` event.</summary>
    public class GoogleAppsCardV1OnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If specified, an action is triggered by this `onClick`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual GoogleAppsCardV1Action Action { get; set; }

        /// <summary>A new card is pushed to the card stack after clicking if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("card")]
        public virtual GoogleAppsCardV1Card Card { get; set; }

        /// <summary>
        /// An add-on triggers this action when the action needs to open a link. This differs from the `open_link` above
        /// in that this needs to talk to server to get the link. Thus some preparation work is required for web client
        /// to do before the open link action response comes back.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openDynamicLinkAction")]
        public virtual GoogleAppsCardV1Action OpenDynamicLinkAction { get; set; }

        /// <summary>If specified, this `onClick` triggers an open link action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual GoogleAppsCardV1OpenLink OpenLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an `onClick` event that opens a hyperlink.</summary>
    public class GoogleAppsCardV1OpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the client forgets about a link after opening it, or observes it until the window closes. Not
        /// supported by Chat apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClose")]
        public virtual string OnClose { get; set; }

        /// <summary>How to open a link. Not supported by Chat apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openAs")]
        public virtual string OpenAs { get; set; }

        /// <summary>The URL to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A section contains a collection of widgets that are rendered vertically in the order that they are specified.
    /// Across all platforms, cards have a narrow fixed width, so there is currently no need for layout properties, for
    /// example, float.
    /// </summary>
    public class GoogleAppsCardV1Section : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether this section is collapsible. If a section is collapsible, the description must be given.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapsible")]
        public virtual System.Nullable<bool> Collapsible { get; set; }

        /// <summary>The header of the section. Formatted text is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// The number of uncollapsible widgets. For example, when a section contains five widgets and the
        /// `uncollapsibleWidgetsCount` is set to `2`, the first two widgets are always shown and the last three are
        /// collapsed as default. The `uncollapsibleWidgetsCount` is taken into account only when `collapsible` is
        /// `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncollapsibleWidgetsCount")]
        public virtual System.Nullable<int> UncollapsibleWidgetsCount { get; set; }

        /// <summary>A section must contain at least 1 widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Widget> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A widget that creates a UI item with options for users to select. For example, a dropdown menu.
    /// </summary>
    public class GoogleAppsCardV1SelectionInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of the selected items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1SelectionItem> Items { get; set; }

        /// <summary>The label displayed ahead of the switch control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The name of the text input which is used in `formInput`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If specified, the form is submitted when the selection changes. If not specified, you must specify a
        /// separate button.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>The type of the selection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A selectable item in the switch control.</summary>
    public class GoogleAppsCardV1SelectionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If more than one item is selected for `RADIO_BUTTON` and `DROPDOWN`, the first selected item is treated as
        /// selected and the ones after are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>The text to be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The value associated with this item. The client should use this as a form input value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggestion item.</summary>
    public class GoogleAppsCardV1SuggestionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The suggested autocomplete result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A container wrapping elements necessary for showing suggestion items used in text input autocomplete.
    /// </summary>
    public class GoogleAppsCardV1Suggestions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of suggestions used for autocomplete recommendations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1SuggestionItem> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Either a toggle-style switch or a checkbox.</summary>
    public class GoogleAppsCardV1SwitchControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The control type, either switch or checkbox.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlType")]
        public virtual string ControlType { get; set; }

        /// <summary>The name of the switch widget that's used in `formInput`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The action when the switch state is changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>If the switch is selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>The value is what is passed back in the callback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text input is a UI item where users can input text. A text input can also have an onChange action and
    /// suggestions.
    /// </summary>
    public class GoogleAppsCardV1TextInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The refresh function that returns suggestions based on the user's input text. If the callback is not
        /// specified, autocomplete is done in client side based on the initial suggestion items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCompleteAction")]
        public virtual GoogleAppsCardV1Action AutoCompleteAction { get; set; }

        /// <summary>The hint text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hintText")]
        public virtual string HintText { get; set; }

        /// <summary>The initial suggestions made before any user input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialSuggestions")]
        public virtual GoogleAppsCardV1Suggestions InitialSuggestions { get; set; }

        /// <summary>At least one of label and hintText must be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The name of the text input which is used in `formInput`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The onChange action, for example, invoke a function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>The style of the text, for example, a single line or multiple lines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The default value when there is no input from the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A paragraph of text that supports formatting. See [Text
    /// formatting](workspace/add-ons/concepts/widgets#text_formatting") for details.
    /// </summary>
    public class GoogleAppsCardV1TextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that's shown in the widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A widget is a UI element that presents texts, images, etc.</summary>
    public class GoogleAppsCardV1Widget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of buttons. For example, the following JSON creates two buttons. The first is a filled text button
        /// and the second is an image button that opens a link: ``` "buttonList": { "buttons": [ "button": { "text":
        /// "Edit", "Color": { "Red": 255 "Green": 255 "Blue": 255 } "disabled": true }, "button": { "icon": {
        /// "knownIcon": "INVITE" "altText": "check calendar" }, "onClick": { "openLink": { "url":
        /// "https://example.com/calendar" } } }, ] } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttonList")]
        public virtual GoogleAppsCardV1ButtonList ButtonList { get; set; }

        /// <summary>
        /// Displays a selection/input widget for date/time. For example, the following JSON creates a date/time picker
        /// for an appointment time: ``` "date_time_picker": { "name": "appointment_time", "label": "Book your
        /// appointment at:", "type": "DateTimePickerType.DATE_AND_TIME", "valueMsEpoch": "796435200000" } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimePicker")]
        public virtual GoogleAppsCardV1DateTimePicker DateTimePicker { get; set; }

        /// <summary>
        /// Displays a decorated text item in this widget. For example, the following JSON creates a decorated text
        /// widget showing email address: ``` "decoratedText": { "icon": { "knownIcon": "EMAIL" }, "topLabel": "Email
        /// Address", "content": "sasha@example.com", "bottomLabel": "This is a new Email address!", "switchWidget": {
        /// "name": "has_send_welcome_email_to_sasha", "selected": false, "controlType": "ControlType.CHECKBOX" } } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decoratedText")]
        public virtual GoogleAppsCardV1DecoratedText DecoratedText { get; set; }

        /// <summary>
        /// Displays a divider. For example, the following JSON creates a divider: ``` "divider": { } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("divider")]
        public virtual GoogleAppsCardV1Divider Divider { get; set; }

        /// <summary>
        /// Displays a grid with a collection of items. For example, the following JSON creates a 2 column grid with a
        /// single item: ``` "grid": { "title": "A fine collection of items", "numColumns": 2, "borderStyle": { "type":
        /// "STROKE", "cornerRadius": 4.0 }, "items": [ "image": { "imageUri": "https://www.example.com/image.png",
        /// "cropStyle": { "type": "SQUARE" }, "borderStyle": { "type": "STROKE" } }, "title": "An item",
        /// "textAlignment": "CENTER" ], "onClick": { "openLink": { "url":"https://www.example.com" } } } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grid")]
        public virtual GoogleAppsCardV1Grid Grid { get; set; }

        /// <summary>The horizontal alignment of this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>
        /// Displays an image in this widget. For example, the following JSON creates an image with alternative text:
        /// ``` "image": { "imageUrl": "https://example.com/sasha.png" "altText": "Avatar for Sasha" } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleAppsCardV1Image Image { get; set; }

        /// <summary>
        /// Displays a switch control in this widget. For example, the following JSON creates a dropdown selection for
        /// size: ``` "switchControl": { "name": "size", "label": "Size" "type": "SelectionType.DROPDOWN", "items": [ {
        /// "text": "S", "value": "small", "selected": false }, { "text": "M", "value": "medium", "selected": true }, {
        /// "text": "L", "value": "large", "selected": false }, { "text": "XL", "value": "extra_large", "selected":
        /// false } ] } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionInput")]
        public virtual GoogleAppsCardV1SelectionInput SelectionInput { get; set; }

        /// <summary>
        /// Displays a text input in this widget. For example, the following JSON creates a text input for mail address:
        /// ``` "textInput": { "name": "mailing_address", "label": "Mailing Address" } ``` As another example, the
        /// following JSON creates a text input for programming language with static suggestions: ``` "textInput": {
        /// "name": "preferred_programing_language", "label": "Preferred Language", "initialSuggestions": { "items": [ {
        /// "text": "C++" }, { "text": "Java" }, { "text": "JavaScript" }, { "text": "Python" } ] } } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInput")]
        public virtual GoogleAppsCardV1TextInput TextInput { get; set; }

        /// <summary>
        /// Displays a text paragraph in this widget. For example, the following JSON creates a bolded text: ```
        /// "textParagraph": { "text": " *bold text*" } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual GoogleAppsCardV1TextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image that is specified by a URL and can have an onclick action.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The aspect ratio of this image (width/height). This field allows clients to reserve the right height for the
        /// image while waiting for it to load. It's not meant to override the native aspect ratio of the image. If
        /// unset, the server fills it by prefetching the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The URL of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image button with an onclick action.</summary>
    public class ImageButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The icon specified by an enum that indices to an icon provided by Chat API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The name of this image_button which will be used for accessibility. Default value will be provided if
        /// developers don't specify.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Types of data inputs for widgets. Users enter data with these inputs.</summary>
    public class Inputs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date input values. Not supported by Chat apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateInput")]
        public virtual DateInput DateInput { get; set; }

        /// <summary>Date and time input values. Not supported by Chat apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimeInput")]
        public virtual DateTimeInput DateTimeInput { get; set; }

        /// <summary>
        /// Input parameter for regular widgets. For single-valued widgets, it is a single value list. For multi-valued
        /// widgets, such as checkbox, all the values are presented.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringInputs")]
        public virtual StringInputs StringInputs { get; set; }

        /// <summary>Time input values. Not supported by Chat apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInput")]
        public virtual TimeInput TimeInput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A UI element contains a key (label) and a value (content). And this element may also contain some actions such
    /// as onclick button.
    /// </summary>
    public class KeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text of the bottom label. Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        /// <summary>A button that can be clicked to trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual Button Button { get; set; }

        /// <summary>The text of the content. Formatted text supported and always required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>If the content should be multiline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentMultiline")]
        public virtual System.Nullable<bool> ContentMultiline { get; set; }

        /// <summary>An enum value that will be replaced by the Chat API with the corresponding icon image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>The onclick action. Only the top label, bottom label and content region are clickable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The text of the top label. Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of memberships in the requested (or first) page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; }

        /// <summary>
        /// Continuation token to retrieve the next page of results. It will be empty for the last page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListSpacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token to retrieve the next page of results. It will be empty for the last page of results.
        /// Tokens expire in an hour. An error is thrown if an expired token is passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of spaces in the requested (or first) page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaces")]
        public virtual System.Collections.Generic.IList<Space> Spaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A matched url in a Chat message. Chat apps can preview matched URLs. For more information, refer to [Preview
    /// links](https://developers.google.com/chat/how-tos/preview-links).
    /// </summary>
    public class MatchedUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The url that was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Media resource.</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a membership relation in Google Chat, such as whether a user or Chat app is invited to, part of, or
    /// absent from a space.
    /// </summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The creation time of the membership, such as when a member joined or was invited to join a
        /// space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// A Google Chat user or app. Format: `users/{user}` or `users/app` When `users/{user}`, represents a
        /// [person](https://developers.google.com/people/api/rest/v1/people) in the People API or a
        /// [user](https://developers.google.com/admin-sdk/directory/reference/rest/v1/users) in the Admin SDK Directory
        /// API. When `users/app`, represents a Chat app creating membership for itself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual User Member { get; set; }

        /// <summary>Resource name of the membership. Format: spaces/{space}/members/{member}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message in Google Chat.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Parameters that a Chat app can use to configure how its response is posted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionResponse")]
        public virtual ActionResponse ActionResponse { get; set; }

        /// <summary>Output only. Annotations associated with the text in this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<Annotation> Annotations { get; set; }

        /// <summary>Plain-text body of the message with all Chat app mentions stripped out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentText")]
        public virtual string ArgumentText { get; set; }

        /// <summary>User uploaded attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual System.Collections.Generic.IList<Attachment> Attachment { get; set; }

        /// <summary>
        /// Rich, formatted and interactive cards that can be used to display UI elements such as: formatted texts,
        /// buttons, clickable images. Cards are normally displayed below the plain-text body of the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cards")]
        public virtual System.Collections.Generic.IList<Card> Cards { get; set; }

        /// <summary>Output only. The time at which the message was created in Google Chat server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// A plain-text description of the message's cards, used when the actual cards cannot be displayed (e.g. mobile
        /// notifications).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackText")]
        public virtual string FallbackText { get; set; }

        /// <summary>
        /// Output only. The time at which the message was last updated. If the message was never updated, this field
        /// matches `create_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        /// <summary>
        /// Output only. A URL in `spaces.messages.text` that matches a link preview pattern. For more information,
        /// refer to [Preview links](https://developers.google.com/chat/how-tos/preview-links).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedUrl")]
        public virtual MatchedUrl MatchedUrl { get; set; }

        /// <summary>
        /// Resource name in the form `spaces/*/messages/*`. Example:
        /// `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The user who created the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sender")]
        public virtual User Sender { get; set; }

        /// <summary>Output only. Slash command information, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slashCommand")]
        public virtual SlashCommand SlashCommand { get; set; }

        /// <summary>The space the message belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>
        /// Plain-text body of the message. The first link to an image, video, web page, or other preview-able item
        /// generates a preview chip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The thread the message belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thread")]
        public virtual Thread Thread { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An onclick action (e.g. open a link).</summary>
    public class OnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A form action will be triggered by this onclick if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FormAction Action { get; set; }

        /// <summary>This onclick triggers an open link action if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual OpenLink OpenLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link that opens a new window.</summary>
    public class OpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A section contains a collection of widgets that are rendered (vertically) in the order that they are specified.
    /// Across all platforms, cards have a narrow fixed width, so there is currently no need for layout properties (e.g.
    /// float).
    /// </summary>
    public class Section : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The header of the section, text formatted supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>A section must contain at least 1 widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<WidgetMarkup> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A [slash command](https://developers.google.com/chat/how-tos/slash-commands) in Google Chat.</summary>
    public class SlashCommand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the slash command invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for slash commands (/).</summary>
    public class SlashCommandMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Chat app whose command was invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bot")]
        public virtual User Bot { get; set; }

        /// <summary>The command id of the invoked slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The name of the invoked slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandName")]
        public virtual string CommandName { get; set; }

        /// <summary>Indicating whether the slash command is for a dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggersDialog")]
        public virtual System.Nullable<bool> TriggersDialog { get; set; }

        /// <summary>The type of slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A space in Google Chat. Spaces are conversations between two or more users or 1:1 messages between a user and a
    /// Chat app.
    /// </summary>
    public class Space : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The space's display name. For direct messages between humans, this field might be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource name of the space. Format: spaces/{space}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Whether the space is a DM between a Chat app and a single human.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUserBotDm")]
        public virtual System.Nullable<bool> SingleUserBotDm { get; set; }

        /// <summary>Output only. Whether messages are threaded in this space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threaded")]
        public virtual System.Nullable<bool> Threaded { get; set; }

        /// <summary>
        /// Output only. Deprecated: Use `single_user_bot_dm` or `space_type` (developer preview) instead. The type of a
        /// space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Input parameter for regular widgets. For single-valued widgets, it is a single value list. For multi-valued
    /// widgets, such as checkbox, all the values are presented.
    /// </summary>
    public class StringInputs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of strings entered by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button with text and onclick action.</summary>
    public class TextButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The onclick action of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The text of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A paragraph of text. Formatted text supported.</summary>
    public class TextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A thread in Google Chat.</summary>
    public class Thread : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name, in the form "spaces/*/threads/*". Example: spaces/AAAAAAAAAAA/threads/TTTTTTTTTTT
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time input values. Not supported by Chat apps.</summary>
    public class TimeInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The hour on a 24-hour clock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>The number of minutes past the hour. Valid values are 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The timezone ID and offset from Coordinated Universal Time (UTC). Not supported by Chat apps.</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [IANA TZ](https://www.iana.org/time-zones) time zone database code, such as "America/Toronto".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The user timezone offset, in milliseconds, from Coordinated Universal Time (UTC).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user in Google Chat.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The user's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Unique identifier of the user's Google Workspace domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainId")]
        public virtual string DomainId { get; set; }

        /// <summary>Output only. When `true`, the user is deleted or their profile is not visible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAnonymous")]
        public virtual System.Nullable<bool> IsAnonymous { get; set; }

        /// <summary>
        /// Resource name for a Google Chat user. Represents a
        /// [person](https://developers.google.com/people/api/rest/v1/people#Person) in the People API or a
        /// [user](https://developers.google.com/admin-sdk/directory/reference/rest/v1/users) in the Admin SDK Directory
        /// API. Formatted as: `users/{user}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for user mentions (@).</summary>
    public class UserMentionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of user mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The user mentioned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A widget is a UI element that presents texts, images, etc.</summary>
    public class WidgetMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of buttons. Buttons is also oneof data and only one of these fields should be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<Button> Buttons { get; set; }

        /// <summary>Display an image in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>Display a key value item in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValue")]
        public virtual KeyValue KeyValue { get; set; }

        /// <summary>Display a text paragraph in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual TextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
