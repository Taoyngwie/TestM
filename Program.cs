enum Menu {
    Register = 1, Login, MockupTime
}
enum MenuII {
    Register = 1, BangModToBangKhunTien, BangKhunTienToBangMod, Logout
}
class Program {
    static RegisterInfoList registerList;
    static Info currentLogin;
    static Queue<string> BM_BKT07_30 = new Queue<string>();
    static Queue<string> BM_BKT08_00 = new Queue<string>();
    static Queue<string> BM_BKT08_15 = new Queue<string>();
    static Queue<string> BM_BKT08_30 = new Queue<string>();
    static Queue<string> BM_BKT12_00 = new Queue<string>();
    static Queue<string> BM_BKT14_00 = new Queue<string>();
    static Queue<string> BM_BKT16_00 = new Queue<string>();

    static Queue<string> BKT_BM07_00 = new Queue<string>();
    static Queue<string> BKT_BM10_00 = new Queue<string>();
    static Queue<string> BKT_BM13_00 = new Queue<string>();
    static Queue<string> BKT_BM15_00 = new Queue<string>();
    static Queue<string> BKT_BM16_30 = new Queue<string>();
    static Queue<string> BKT_BM17_00 = new Queue<string>();
    static Queue<string> BKT_BM17_30 = new Queue<string>();
    static Queue<string> BKT_BM18_30 = new Queue<string>();
    public static void Main(string[] args) {

        PrepareRegisterListWhenProgramIsLoad();
        PrintMenuScreen();
        
    }
    public static void PrintNotification(string text, ref bool IsTrueTime) {

        if(text == "7:00:00 AM" ) { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 07:00:00 |*************");
            for(int Number = 0; Number <= BKT_BM07_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM07_00.Get(Number));
            }
            while (BKT_BM07_00.GetLength() != 0) {
                BKT_BM07_00.Pop();
            }
        }
        else if(text == "7:30:00 AM") {
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 07:30:00 |*************");
            for(int Number = 0; Number <= BM_BKT07_30.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BM_BKT07_30.Get(Number));
            }
            while (BM_BKT07_30.GetLength() != 0) {
                BM_BKT07_30.Pop();
            }
        }
        else if(text == "8:00:00 AM") {
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 08:00:00 |*************");
            for(int Number = 0; Number <= BM_BKT08_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BM_BKT08_00.Get(Number));
            }
            while (BM_BKT08_00.GetLength() != 0) {
                BM_BKT08_00.Pop();
            }
        }
        else if(text == "8:15:00 AM") {
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 08:15:00 |*************");
            for(int Number = 0; Number <= BM_BKT08_15.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BM_BKT08_15.Get(Number));
            }
            while (BM_BKT08_15.GetLength() != 0) {
                BM_BKT08_15.Pop();
            }
        }
        else if(text == "8:30:00 AM") {
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 08:30:00 |*************");
            for(int Number = 0; Number <= BM_BKT08_30.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BM_BKT08_30.Get(Number));
            }
            while (BM_BKT08_30.GetLength() != 0) {
                BM_BKT08_30.Pop();
            }
        }
        else if(text == "10:00:00 AM") { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 10:00:00 |*************");
            for(int Number = 0; Number <= BKT_BM10_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM10_00.Get(Number));
            }
            while (BKT_BM10_00.GetLength() != 0) {
                BKT_BM10_00.Pop();
            }
        }
        else if(text == "12:00:00 AM") {
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 12:00:00 |*************");
            for(int Number = 0; Number <= BM_BKT12_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BM_BKT12_00.Get(Number));
            }
            while (BM_BKT12_00.GetLength() != 0) {
                BM_BKT12_00.Pop();
            }
        }
        else if(text == "1:00:00 PM") { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 13:00:00 |*************");
            for(int Number = 0; Number <= BKT_BM13_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM13_00.Get(Number));;
            }
            while (BKT_BM13_00.GetLength() != 0) {
                BKT_BM13_00.Pop();
            }
        }
        else if(text == "2:00:00 PM") {
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 14:00:00 |*************");
            for(int Number = 0; Number <= BM_BKT14_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BM_BKT14_00.Get(Number));
            }
            while (BM_BKT14_00.GetLength() != 0) {
                BM_BKT14_00.Pop();
            }
        }
        else if(text == "3:00:00 PM") { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 15:00:00 |*************");
            for(int Number = 0; Number <= BKT_BM15_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM15_00.Get(Number));
            }
            while (BKT_BM15_00.GetLength() != 0) {
                BKT_BM15_00.Pop();
            }
        }
        else if(text == "4:00:00 PM") {
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 16:00:00 |*************");
            for(int Number = 0; Number <= BM_BKT16_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BM_BKT16_00.Get(Number));
            }
            while (BM_BKT16_00.GetLength() != 0) {
                BM_BKT16_00.Pop();
            }
        }
        else if(text == "4:30:00 PM") { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 16:30:00 |*************");
            for(int Number = 0; Number <= BKT_BM16_30.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM16_30.Get(Number));
            }
            while (BKT_BM16_30.GetLength() != 0) {
                BKT_BM16_30.Pop();
            }
        }
        else if(text == "5:00:00 PM") { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 17:00:00 |*************");
            for(int Number = 0; Number <= BKT_BM17_00.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM17_00.Get(Number));
            }
            int round = BKT_BM17_00.GetLength()-1;
            while (BKT_BM17_00.GetLength() != 0) {
                BKT_BM17_00.Pop();
            }
        }
        else if(text == "5:30:00 PM") { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 17:30:00 |*************");
            for(int Number = 0; Number <= BKT_BM17_30.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM17_30.Get(Number));
            }
            while (BKT_BM17_30.GetLength() != 0) {
                BKT_BM17_30.Pop();
            }
        }
        else if(text == "6:30:00 PM") { //บางขุน
            IsTrueTime = true;
            Console.Clear();
            Console.WriteLine("*************| Time Table : 18:30:00 |*************");
            for(int Number = 0; Number <= BKT_BM18_30.GetLength()-1; Number++) {
                Console.WriteLine("{0}. {1}", Number+1, BKT_BM18_30.Get(Number));
            }
            while (BKT_BM18_30.GetLength() != 0) {
                BKT_BM18_30.Pop();
            }
        }
    }
    static void MockupTime() {
        Console.WriteLine("*************| Time mockup select |*************");
        Console.WriteLine("1.  07:30");
        Console.WriteLine("2.  08:00");
        Console.WriteLine("3.  08:15");
        Console.WriteLine("4.  08:30");
        Console.WriteLine("5.  12:00");
        Console.WriteLine("6.  14:00");
        Console.WriteLine("7.  16:00");
        Console.WriteLine("8.  07:00");
        Console.WriteLine("9.  10:00");
        Console.WriteLine("10. 13:00");
        Console.WriteLine("11. 15:00");
        Console.WriteLine("12. 16:30");
        Console.WriteLine("13. 17:00");
        Console.WriteLine("14. 17:30");
        Console.WriteLine("15. 18:30");
        string TimeSelect = "";
        Console.Write("Please Input number : ");
        int numberSelect = int.Parse(Console.ReadLine());       
        switch (numberSelect)
        {
            case 1:
                TimeSelect = "7:30:00 AM";
                break;

            case 2:
                TimeSelect = "8:00:00 AM";
                break;
            case 3:
                TimeSelect = "8:15:00 AM";
                break;
            case 4:
                TimeSelect = "8:30:00 AM";
                break;
            case 5:
                TimeSelect = "12:00:00 AM";
                break;
            case 6:
                TimeSelect = "2:00:00 PM";
                break;
            case 7:
                TimeSelect = "4:00:00 PM";
                break;
            case 8:
                TimeSelect = "7:00:00 AM";
                break;
            case 9:
                TimeSelect = "10:00:00 AM";
                break;
            case 10:
                TimeSelect = "1:00:00 PM";
                break;
            case 11:
                TimeSelect = "3:00:00 PM";
                break;
            case 12:
                TimeSelect = "4:30:00 PM";
                break;
            case 13:
                TimeSelect = "5:00:00 PM";
                break;
            case 14:
                TimeSelect = "5:30:00 PM";
                break;
            case 15:
                TimeSelect = "6:30:00 PM";
                break;            
            default:
                break; 
        }  
        bool Nothing = false;
        PrintNotification(TimeSelect , ref Nothing);
        Console.Write("please Enter for back to menu");
        Console.ReadLine();
        Console.Clear();
        
    }
    static void PrintMenuScreen()
    {   
        Thread mainThred = Thread.CurrentThread;
        mainThred.Name = "Main thred";
        Thread thread1 = new Thread(() => CheckTime()); 
        Thread thread2 = new Thread(() => PrintFirstListMenu());
        Thread thread3 = new Thread(() => InputMenuFromKeyboard());
        
        thread1.Start();
        thread2.Start();
        thread3.Start();
    }
    static void CheckTime() {
        bool IsTrueTime = false; 
        while(IsTrueTime == false) {

            //Thread.Sleep(1000);//เรียกต่อ1วินาที
            string text = DateTime.Now.ToLongTimeString();
            
            PrintNotification(text, ref IsTrueTime);
        }
        Thread.Sleep(10000);
        PrintMenuScreen();
    }
    static void PrintFirstListMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to KMUTT Bus Booking");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Select mockup time");
        Console.WriteLine("Any number to end this program.");
        Console.WriteLine("*******************************************************");
        Console.Write("Please Input Menu: ");
    }

    static void PrintSecondListMenu()
    {
        Console.WriteLine("Welcome : {0} => | KMUTT Bus Booking |",Program.registerList.CurrentLogin.GetFullName());
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. BangMod - BangKhunTien");
        Console.WriteLine("3. BangKhunTie - BangMod");
        Console.WriteLine("4. Logout");
        Console.WriteLine("*******************************************************");
        Console.Write("Please Input Menu: ");
    }

    static void InputMenuFromKeyboard()
    {
        Menu menu = (Menu)(int.Parse(Console.ReadLine())); 

        PresentMenu(menu);
    }

    static void InputMenuIIFromKeyboard()
    {
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
            case Menu.MockupTime:
                MockupTime();
                PrintMenuScreen();
                break;
            default:
                break;
        }
    }

     static void PresentMenu(MenuII menuII)
    {
        var login = Program.registerList.CurrentLogin;
        switch (menuII)
        {
            case MenuII.Register:
                ShowInputRegister();
                break;

            case MenuII.BangModToBangKhunTien:
                string TimeCheckBM = ShowTimeBM_BKT();
                AddQueue(TimeCheckBM, login);
                Logout();
                break;

            case MenuII.BangKhunTienToBangMod:
                string TimeCheckBKT = showTimeBKT_BM();
                AddQueue(TimeCheckBKT, login);
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
    public static void AddQueue(string TimeCheck, Info login) {
        switch (TimeCheck) {
            case "07:30" :
                CheckTimeRegister(ref BM_BKT07_30, login);
                break;
            case "08:00" :
                CheckTimeRegister(ref BM_BKT08_00, login);
                break;
            case "08:15" :
                CheckTimeRegister(ref BM_BKT08_15, login);
                break;
            case "08:30" :
                CheckTimeRegister(ref BM_BKT08_30, login);
                break;
            case "12:00" :
                CheckTimeRegister(ref BM_BKT12_00, login);
                break;
            case "14:00" :
                CheckTimeRegister(ref BM_BKT14_00, login);
                break;
            case "16:00" :
                CheckTimeRegister(ref BM_BKT16_00, login);
                break;
            case "07:00" :
                CheckTimeRegister(ref BKT_BM07_00, login);
                break;
            case "10:00" :
                CheckTimeRegister(ref BKT_BM10_00, login);
                break;
            case "13:00" :
                CheckTimeRegister(ref BKT_BM13_00, login);
                break;
            case "15:00" :
                CheckTimeRegister(ref BKT_BM15_00, login);
                break;
            case "16:30" :
                CheckTimeRegister(ref BKT_BM16_30, login);
                break;
            case "17:00" :
                CheckTimeRegister(ref BKT_BM17_00, login);
                break;
            case "17:30" :
                CheckTimeRegister(ref BKT_BM17_30, login);
                break;
            case "18:30" :
                CheckTimeRegister(ref BKT_BM18_30, login);
                break;
        }
    }
    public static void CheckTimeRegister(ref Queue<string> input, Info login) {
        if(input.GetLength() != 0)
            {
                for(int roundNum = 0; roundNum <= input.GetLength() - 1; roundNum++)
                {
                    if(input.Get(roundNum) != login.GetFullName())
                    {
                        input.Push(login.GetFullName());
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("You already register this time => Please enter to Go next");
                        Console.ReadLine();
                        BlackToMenuII();
                    }
                }
            }
        else
        {
            input.Push(login.GetFullName());
       }
    }
    public static string ShowTimeBM_BKT()
    {   
        Console.Clear();
        Console.WriteLine("*********| Select time to go |*********");
        Console.WriteLine("1. 07:30");
        Console.WriteLine("2. 08:00");
        Console.WriteLine("3. 08:15");
        Console.WriteLine("4. 08:30");
        Console.WriteLine("5. 12:00");
        Console.WriteLine("6. 14:00");
        Console.WriteLine("7. 16:00");
        Console.WriteLine("***************************************");
        Console.Write("Please input time : ");

        int i = int.Parse(Console.ReadLine());
        if(i == 1) {
            return "07:30";
        }
        else if(i == 2) {
            return "08.00";
        }
        else if(i == 3) {
            return "08:15";
        }
        else if(i == 4) {
            return "08:30";
        }
        else if(i == 5) {
            return "12:00";
        }
        else if(i == 6) {
            return "14:00";
        }
        else if(i == 7) {
            return "16:00";
        }
        else return null;
    }
    public static string showTimeBKT_BM()
    {   
        Console.Clear();
        Console.WriteLine("*********| Select time to go |*********");
        Console.WriteLine("1. 07:00");
        Console.WriteLine("2. 10:00");
        Console.WriteLine("3. 13:00");
        Console.WriteLine("4. 15:00");
        Console.WriteLine("5. 16:30");
        Console.WriteLine("6. 17:00");
        Console.WriteLine("7. 17:30");
        Console.WriteLine("8. 18:00");
        Console.WriteLine("***************************************");
        Console.Write("Please input time : ");

        int i = int.Parse(Console.ReadLine());
        if(i == 1) {
            return "07:00";
        }
        else if(i == 2) {
            return "10:00";
        }
        else if(i == 3) {
            return "13:00";
        }
        else if(i == 4) {
            return "15:00";
        } 
        else if(i == 5) {
            return "16:30";
        } 
        else if(i == 6) {
            return "17:00";
        } 
        else if(i == 7) {
            return "17:30";
        } 
        else if(i == 8) {
            return "18:30";
        }
        else return null;
    }
     static void ShowInputRegister()
    {
        Console.Clear();

        Console.WriteLine("Register for KMUTT Bus Booking");
        Console.WriteLine("*****************************************");
        Console.Write("Select Type (1.College Student, 2.Teacher) : ");
            for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    InputCollegeStudentInfoFromKeyboard();
                    Console.Clear();
                    i++;
                }
                else if (s == 3)
                {
                    InputTeacherInfoFromKeyboard();
                    Console.Clear();
                    i++;
                }
                else
                {
                    Console.WriteLine("*****************************************");
                    Console.Write("Please Enter only 1 or 2 : ");             
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
            Console.ReadLine();
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
            Console.ReadLine();
        }
    }

    static void Login()
    {   
        Console.Clear();
        Console.WriteLine("Login for KMUTT Bus Booking");
        Console.WriteLine("*****************************************");
        Console.Write("Input Email : ");
        string mail = Console.ReadLine();
        Console.Write("Input Password : ");
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
        Console.Write("Name : ");

        return Console.ReadLine();
    }

    static string InputStudentID()
    {
        Console.Write("StudentID : ");

        return Console.ReadLine();
    }

    static string InputLast()
    {
        Console.Write("Last Name : ");

        return Console.ReadLine();
    }

    static string InputEmail()
    {
       Console.Write("Email : ");

        return Console.ReadLine(); 
    }

    static string InputPassword()
    {
       Console.Write("Password : ");

        return Console.ReadLine(); 
    }

    static string InputTitle()
    {   
        Console.Write("Input Your Title Name (1.Mr, 2.Mrs, 3.Miss) : ");
        int s = int.Parse(Console.ReadLine());
        if (s == 1)
        {
            return  "Mr.";
        }

        else if (s == 2)
        {
            return "Mrs.";
        }

        else if (s == 3)
        {
            return "Miss.";
        }
        else
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Please Enter only 1-3 :");
            return null;             
        }
    }
}