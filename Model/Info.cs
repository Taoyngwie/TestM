class Info
{
    private string title;
    private string name;
    private string lastname;

    public Info(string title, string name, string lastname)
    {
        this.title = title;
        this.name = name;
        this.lastname = lastname;
    }

    public string GetTitle()
    {
        return this.title;
    } 

    public string GetName()
    {
        return this.name;
    }  

    public string GetLastName()
    {
        return this.lastname;
    }  

}