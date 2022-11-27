class TeacherInfo: Info
{
    private string email;
    private string password;

    public TeacherInfo(string title, string name, string lastname, string email, string password)
    :base(title, name, lastname)
    {
        this.email = email;
        this.password = password;
    }

    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }
}