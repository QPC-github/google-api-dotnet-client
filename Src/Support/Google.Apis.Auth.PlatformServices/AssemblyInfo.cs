﻿/*
Copyright 2017 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Runtime.CompilerServices;

// All platformservice types have been moved to the main Google.Apis.Auth dll.
// Type-forwards are required so existing dlls will pick up the type move.

[assembly: TypeForwardedTo(typeof(Google.Apis.Auth.OAuth2.GoogleCredential))]
[assembly: TypeForwardedTo(typeof(Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker))]
[assembly: TypeForwardedTo(typeof(Google.Apis.Auth.OAuth2.LocalServerCodeReceiver))]
#pragma warning disable CS0618 // Type or member is obsolete
[assembly: TypeForwardedTo(typeof(Google.Apis.Auth.OAuth2.PromptCodeReceiver))]
#pragma warning restore CS0618 // Type or member is obsolete
[assembly: TypeForwardedTo(typeof(Google.Apis.Auth.OAuth2.ServiceAccountCredential))]
