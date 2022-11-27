using System.Collections.Generic;

class RegisterInfoList
{
    private List<Info> registerInfoList;

    public RegisterInfoList()
    {
        this.registerInfoList = new List<Info>();
    }

    public void AddNewPerson(Info info)
    {
        this.registerInfoList.Add(info);
        int num = 0;
        num++;
    }

     public void FetchCollegeStudentList()
    {
        Console.WriteLine("List Student");
        Console.WriteLine("***************************");

        foreach(Info info in this.registerInfoList)
        {
            if(info is StudentInfo)
            {
                Console.WriteLine("1. {0} {1} {2}", info.GetTitle(), info.GetName(), info.GetLastName());
            }
        }
    }

    public void FetchTeacherList()
    {
        Console.WriteLine("List Teacher");
        Console.WriteLine("***************************");

        foreach(Info info in this.registerInfoList)
        {
            if(info is TeacherInfo)
            {
                Console.WriteLine("1. {0} {1} {2}", info.GetTitle(), info.GetName(), info.GetLastName());
            }
        }
    }

    public bool CheckLogin(string email, string password)
    {
         foreach(Info info in this.registerInfoList)
         {
            if(info is TeacherInfo teacherInfo)
            {
                if(teacherInfo.GetEmail() == email && teacherInfo.GetPassword() == password)
                {
                    return true;
                }
            }
            else if(info is StudentInfo studentInfo)
            {
                if(studentInfo.GetEmail() == email && studentInfo.GetPassword() == password)
                {
                    return true;
                }
            }
         }  
         return false;
    }

    public bool CheckRegister(string email)
    {
         foreach(Info info in this.registerInfoList)
         {
            if(info is TeacherInfo teacherInfo)
            {
                if(teacherInfo.GetEmail() == email )
                {
                    return false;
                }
            }
            else if(info is StudentInfo studentInfo)
            {
                if(studentInfo.GetEmail() == email )
                {
                    return false;
                }
            }
         }  
         return true;
    }
}
