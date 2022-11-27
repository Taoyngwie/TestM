enum Menu
{
    Register = 1, Login
}

enum MenuII
{
    Register = 1, BangModToBangKhunTien, BangKhunTienToBangMod, Logout
}

class Program
{
    static RegisterInfoList registerList;

    static void Main(string[] args)
    {
        PrepareRegisterListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen()
    {
        Console.Clear();

        PrintFirstListMenu();
        InputMenuFromKeyboard();
    }

    static void PrintFirstListMenu()
    {
        Console.WriteLine("Welcome to KMUTT Bus Booking");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("Any number to end this program.");
        Console.WriteLine("*******************************************************");
    }

    static void PrintSecondListMenu()
    {
        Console.WriteLine("Welcome to KMUTT Bus Booking");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. BangMod - BangKhunTien");
        Console.WriteLine("3. BangKhunTie - BangMod");
        Console.WriteLine("4. Logout");
        Console.WriteLine("*******************************************************");
    }

    static void InputMenuFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine())); 

        PresentMenu(menu);
    }

    static void InputMenuIIFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        MenuII menuII = (MenuII)(int.Parse(Console.ReadLine())); 

        PresentMenu(menuII);
    }

    static void PresentMenu(Menu menu)
    {
        switch (menu)
        {
            case Menu.Register:
                ShowInputRegister();
                break;

            case Menu.Login:
                Login();
                break;

            default:
                break;
        }
    }

     static void PresentMenu(MenuII menuII)
    {
        switch (menuII)
        {
            case MenuII.Register:
                ShowInputRegister();
                break;

            case MenuII.BangModToBangKhunTien:
                Logout();
                break;

            case MenuII.BangKhunTienToBangMod:
                Logout();
                break;

            case MenuII.Logout:
                Logout();
                break;

            default:
                BlackToMenuII();
                break;
        }
    }

     static void ShowInputRegister()
    {
        Console.Clear();

        Console.WriteLine("Register for KMUTT Bus Booking");
        Console.WriteLine("*****************************************");

        Console.WriteLine("Input Your Type");
        Console.WriteLine("1.College Student.");
        Console.WriteLine("2.Teacher.");
            for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    InputCollegeStudentInfoFromKeyboard();
                    i++;
                }

                else if (s == 3)
                {
                    InputTeacherInfoFromKeyboard();
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1 or 2 :");             
                }
            }
          BlackToMenu();
    } 

    static void InputCollegeStudentInfoFromKeyboard()
    {
        string getemailStudent = InputEmail();
        StudentInfo student = new StudentInfo(InputTitle(), InputName(), InputLast(),InputStudentID(),getemailStudent, InputPassword());
        if(Program.registerList.CheckRegister(getemailStudent))
        {
            Program.registerList.AddNewPerson(student);
        }

        else
        {
            Console.WriteLine("Try again. This email exist in system");
            PrintFirstListMenu();
            InputMenuFromKeyboard();
        }
    }

    static void InputTeacherInfoFromKeyboard()
    {
        string getemailTeacher = InputEmail();
        TeacherInfo teacher = new TeacherInfo(InputTitle(), InputName(), InputLast(),getemailTeacher, InputPassword());
        if(Program.registerList.CheckRegister(getemailTeacher))
        {
            Program.registerList.AddNewPerson(teacher);
        }

        else
        {
            Console.WriteLine("Try again. This email exist in system");
            PrintFirstListMenu();
            InputMenuFromKeyboard();
        }
        
    }

    static void Login()
    {
        Console.WriteLine("Login");
        Console.WriteLine("***************************");
        Console.WriteLine("Input Email: ");
        string mail = Console.ReadLine();
        Console.WriteLine("Input Password: ");
        string pass = Console.ReadLine();

        if(mail == "exit")
        {
            PrintMenuScreen();
        }
        else if(Program.registerList.CheckLogin(mail, pass))
        {
            BlackToMenuII();
        }
        else
        {
            Login();
        }
    }

    static void Logout()
    {
        Console.Clear();
        BlackToMenu();
    }

    static void BlackToMenu()
    {
        Console.Clear();
        PrintFirstListMenu();
        InputMenuFromKeyboard();
    }

    static void BlackToMenuII()
    {
        Console.Clear();
        PrintSecondListMenu();
        InputMenuIIFromKeyboard();
    }

     static void PrepareRegisterListWhenProgramIsLoad()
    {
        Program.registerList = new RegisterInfoList();
    }

    static string InputName()
    {
        Console.Write("Name: ");

        return Console.ReadLine();
    }

    static string InputStudentID()
    {
        Console.Write("StudentID: ");

        return Console.ReadLine();
    }

    static string InputLast()
    {
        Console.Write("Last Name: ");

        return Console.ReadLine();
    }

    static string InputEmail()
    {
       Console.Write("Email: ");

        return Console.ReadLine(); 
    }

    static string InputPassword()
    {
       Console.Write("Password: ");

        return Console.ReadLine(); 
    }

    static string InputTitle()
    {
        Console.WriteLine("Input Your Title Name");
        Console.WriteLine("1.Mr.");
        Console.WriteLine("2.Mrs.");
        Console.WriteLine("3.Miss.");
        for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    return  "Mr.";
                    i++;
                }

                else if (s == 2)
                {
                    return "Mrs.";
                    i++;
                }

                else if (s == 3)
                {
                    return "Miss.";
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-3 :");             
                }
            }
            return null;
    }

}
