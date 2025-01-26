namespace Demo
{
    internal class Program
    {
        static void DoSomeCode()
        {
            try { 
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = x / y;
            int[] arr = { 1, 2, 3 };
            arr[10] = 5; 
            } // this will throw an exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block");
                // Release | Close | Dispose Resources | deallocate memory
            }
        }

        enum Season:byte { Winter, Spring, Summer, Fall=10 } // called labels
        enum WeekDays { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
        enum Gender { M=1, F=2 , Male = 1 , Female = 2 }
        [Flags]
        enum Permission { Read=1 , Write=2 , Delete = 4 , Create =8  }

        static void DoSomeProtectiveCode()
        {
            int x, y, z;
            bool flag;
            do 
            {
                flag = int.TryParse(Console.ReadLine(), out x);
            } while (!flag);
            do
            {
                flag = int.TryParse(Console.ReadLine(), out y);
            } while (!flag || y==0);
            z = x / y;
            int[] arr = { 1, 2, 3 };
            if (arr?.Length > 10)
            {
                arr[10] = 5;
            }
        }
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            //// Boxing is : Casting a value type to a reference type
            //// Unboxing is : Casting a reference type to a value type

            //object o1; // can refer to instance of "object" or instance of any type
            //o1 = 5; // cast from valuetype to reference type (boxing)
            //o1 = 'a'; // cast from valuetype to reference type (boxing)

            //int x = 5;
            //object o2 = x; // cast from valuetype to reference type (boxing)
            //// implicit casting , safe casting


            //object o3 = 3;
            ////int y = o3; // won't work , because not any int is object so we have to use explicit casting
            //int z = (int)o3; // cast from reference type to valuetype (unboxing)
            //                 // explicit casting , unsafe casting

            #endregion

            #region Nullable Types 
            //int? age = null; // can be nullable after adding '?' to the type
            //// Nullable<int>: allow us to assign null

            //// Nullable Value Types : Allow null as a valid value
            //int? x = null;
            //int y;
            //y = x.HasValue ? x.Value : 0;
            //Console.WriteLine(y);

            //// Null Coalescing Operator ??
            //y = x ?? 0;

            #endregion

            #region Nullable Reference Types 
            // Nullable Reference Types [C# 10.0 .NET 6.0] (Compiler Enhancement)
            string Message = "Hello"; // this is required to the compiler
            Message = null; // is ok because the refernce types default value is null

            string? Message2 = null; // this is nullable/optional to the compiler
                                     // this is an enhancment for client side to know which is optional and required
                                     //Console.WriteLine(Message2.Length); // null reference exception
            #endregion

            #region Null Propagation Operator ?
            //// best practice
            //int[] arr = { 1, 2, 3, 4, 5 };
            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //// there is also null propagation method
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //// propagation operator '?.' will check if the array is null or not
            //// if it is null it will return null
            //// null is always smaller than anything when it comes to comparison
            //// so the loop will not be executed
            //// for last example the if condition is better than using null propagation

            // null propagation operator is best used with reference types
            // when it comes null from database or api we don't want null reference exception
            // so we can use null propagation operator to check if the object is null or not\

            #endregion

            #region Exception Handling
            // Exception Handling and Protective Code
            //DoSomeCode();  
            // try .. catch ..finally
            //DoSomeProtectiveCode();
            // but we have to also put the protective code in the try block
            // we have 3 reasons : 1- to catch an exception you haven't considered
            // 2- to catch an exception you have considered but you haven't handled it correctly
            // 3- to handle application exceptions
            #endregion

            #region Enums
            //// Enums is a value type
            //// stack
            //// Enum is a set of named constants
            //// created in namespace

            //Season S01 = Season.Winter;
            //Console.WriteLine(S01);
            //Season S02 = Season.Fall;
            //Console.WriteLine((int)S02);

            //// CLR Represent the enum as integer in memory
            //Gender G01;
            ////G01 = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine(), true);
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object o1 );
            //G01 = (Gender)o1;
            //Console.WriteLine(G01);
            #endregion

            #region Enums 2
            Permission per01 = Permission.Read;
            //per01 ^= Permission.Write; // XOR operation works as toggle, if the permission is there it will remove it and vice versa
            //per01 |= Permission.Delete; // OR operation works as adding permission
            per01 &= ~Permission.Delete; // AND operation works as removing permission
            // & checks permission

            Console.WriteLine(per01);
            #endregion

        }
    } 
}
