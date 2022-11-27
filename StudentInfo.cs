class StudentInfo: Info
{
    private string studentID;
    private string email;
    private string password;

    public StudentInfo(string title, string name, string lastname, string studentID,  string email, string password)
    :base(title, name, lastname)
    {
        this.studentID = studentID;
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