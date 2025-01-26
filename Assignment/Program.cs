namespace Assignment;

internal class Program
{
    #region Q1 Enum
    enum WeekDays {Monday,Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    #endregion
    #region Q2 Enum
    enum Season { Spring , Summer , Autumn, Winter}

    #endregion
    #region Q4 Enum
    [Flags]
    enum Permission { Read = 1, Write = 2, Delete = 4, Execute = 8 }
    #endregion
    #region Q5 Enum
    enum Colors { Red, Green, Blue }
    #endregion
    static void Main(string[] args)
    {
        // Part 1 is in Demo project

        // Part 2
        #region Q1
        //for(int i=0; i<7; i++)
        //{
        //    Console.WriteLine((WeekDays)i);
        //}
        #endregion

        #region Q2
        //Season s = (Season)Enum.Parse(typeof(Season), Console.ReadLine(), true);
        //if (s == Season.Spring) {
        //    Console.WriteLine("March to May");
        //}
        //else if (s == Season.Summer)
        //{
        //    Console.WriteLine("June to August");
        //}
        //else if (s == Season.Autumn)
        //{
        //    Console.WriteLine("September to November");
        //}
        //else if (s == Season.Winter)
        //{
        //    Console.WriteLine("December to February");
        //}
        #endregion

        #region Q4
        //Permission p01 = Permission.Read; // initial
        //Console.WriteLine(p01);
        //p01 |= Permission.Execute; // Add
        //Console.WriteLine(p01);
        //p01 ^= Permission.Read; // Check if it is there, remove
        //Console.WriteLine(p01);
        //p01 &= ~Permission.Execute; // Remove
        //Console.WriteLine(p01);

        //p01 |= Permission.Write;
        //p01 &= Permission.Write; // checks
        //if(p01 == Permission.Write)
        //{
        //    Console.WriteLine("Write is there");
        //}
        #endregion

        #region Q5
        //bool flag = Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out object o);
        //if(flag)
        //{
        //    Console.WriteLine("Primary Color");
        //}
        //else
        //{
        //    Console.WriteLine("Not A Primary Color");
        //}
        #endregion
    }
}
