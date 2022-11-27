class Program
{
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

    static void CheckTime()
    {
        while (true)
        {

            string text = DateTime.Now.ToLongTimeString();
            //Thread.Sleep(1000);//เรียกต่อ1วินาที

            // PrintNontification(text, BM_BKT07_30, BM_BKT08_00, BM_BKT08_15, BM_BKT08_30, BM_BKT12_00, BM_BKT14_00
            // , BM_BKT16_00, BKT_BM07_00, BKT_BM10_00, BKT_BM13_00, BKT_BM15_00, BKT_BM16_30, BKT_BM17_00
            // , BKT_BM17_30, BKT_BM18_30);
        }
    }

    public static void Main() { }
}