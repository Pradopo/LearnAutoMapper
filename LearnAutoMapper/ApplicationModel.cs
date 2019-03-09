namespace LearnAutoMapper
{
    class ApplicationModel
    {
        public string ApplicationID { get; set; }
        public string ApplicationName { get; set; }
        public string Type { get; set; }

        public UserModel Customer { get; set; }
    }
}
