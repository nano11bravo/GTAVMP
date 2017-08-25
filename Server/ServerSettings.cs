namespace GTAServer
{
    public class ServerSettings
    {
        public string Name { get; set; }
        public int MaxPlayers { get; set; }
        public int Port { get; set; }
        public bool PasswordProtected { get; set; }
        public string Password { get; set; }
        public bool Announce { get; set; }
        public string MasterServer { get; set; }

        public bool AllowDisplayNames { get; set; }

        public string Gamemode { get; set; }
        public string[] Filterscripts { get; set; }

        public ServerSettings()
        {
            Port = 4499;
            MaxPlayers = 32;
            Name = "Seven-Labs | Development Server";
            Password = "letmein";
            PasswordProtected = false;
            Gamemode = "freeroam";
            Announce = true;
            AllowDisplayNames = true;
            MasterServer = "http://west.us.seven-labs.com/gtavmp/";
            Filterscripts = new string[] { "" };
        }
    }
}