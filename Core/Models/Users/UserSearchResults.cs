﻿// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GithubSharp.Core.Models.Users
{

    public class UserSearchResults
    {

        [JsonProperty("users")]
        public UserSearchResult[] Users { get; set; }
    }
}
