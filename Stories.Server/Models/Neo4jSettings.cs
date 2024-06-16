﻿namespace Stories.Server.Models
{
    public class Neo4jSettings
    {
        public Neo4jSettings() { }

        public Neo4jSettings(string username, string password, string uri)
        {
            Username = username;
            Password = password;
            BaseURI = uri;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string BaseURI { get; set; }

    }
}
