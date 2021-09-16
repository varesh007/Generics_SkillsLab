using System;
using System.Reflection;

namespace Generics_SkillsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            TryReflection_Exercise();
            Console.ReadLine();
        }

        private static void TryReflection_Exercise()
        {
            //Do Step 1-5 first within GetActualInternType
            var actualOBJ = GetActualInternType();

            //Do Step 6 within DisplayAllFieldAndPropertyValuesOfOBJ
            DisplayAllFieldAndPropertyValuesOfOBJ(actualOBJ);

            while (true)
            {
                Console.WriteLine("Field or Property To change: ");
                var propertyToChange = Console.ReadLine(); //Expect user to type in a field/private in the class they have selected above -> Can either be private or public

                if (propertyToChange == "-1")// just for the sake of simplicity
                    break;

                #region Step 7 - Get type of actualOBJ and map propertyToChange To an actual member of that class from string
                //Make sure your bindings shows both private and public
                // https://docs.microsoft.com/en-us/dotnet/api/system.type.getmember?view=net-5.0#System_Type_GetMember_System_String_
                MemberInfo[] member = null; // populate this array before moving on
                #endregion

                var propName = member[0].Name; //If all goes well, you have successfully map the string to an actual member type of either the class Jedi or SkillsLab
                Console.WriteLine($"Change {propName} to: ");
                var valueToChangeTo = Console.ReadLine();

                if (member[0].MemberType == MemberTypes.Property)
                {
                    var asProp = member[0] as PropertyInfo;

                    #region Step 8 - using propertyInfo, Set the value on ActualObj, make sure to cast first
                    //https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo.setvalue?view=net-5.0
                    //To cast use Convert.ChangeType(valueToChangeTo, Type.GetType(asProp.PropertyType.FullName))
                    #endregion
                }

                else if (member[0].MemberType == MemberTypes.Field)
                {
                    var asProp = member[0] as FieldInfo;

                    #region Step 9 - using FieldInfo, Set the value on ActualObj, make sure to cast first
                    //https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo.setvalue?view=net-5.0
                    //To cast use Convert.ChangeType(valueToChangeTo, Type.GetType(asProp.FieldType.FullName))
                    #endregion
                }

                DisplayAllFieldAndPropertyValuesOfOBJ(actualOBJ);
            }
        }


        /// <summary>
        /// Output of this method is either an instance of a JEDI class or of a Skillslab class
        /// </summary>
        /// <returns></returns>
        private static IInterns GetActualInternType()
        {
            Console.WriteLine($"***Jedi Members****{Environment.NewLine}");

            Console.WriteLine("***Fields****");

            #region Step 1 - Write Code to Show all the public|private Fields in Jedi class [You'll see fields that the compiler creates, ignore them]
            //https://docs.microsoft.com/en-us/dotnet/api/system.type.getfields?view=net-5.0#System_Type_GetFields
            #endregion

            Console.WriteLine("***Properties****");

            #region Step 2 - Write Code to Show all the public|private Properties in Jedi class
            // https://docs.microsoft.com/en-us/dotnet/api/system.type.getproperties?view=net-5.0
            #endregion

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"***SkillsLab Members****{Environment.NewLine}");

            Console.WriteLine("***Fields****");

            #region Step 3 - Write Code to Show all the public|private Fields in SkillsLab class [You'll see fields that the compiler creates, ignore them]
            //https://docs.microsoft.com/en-us/dotnet/api/system.type.getfields?view=net-5.0#System_Type_GetFields
            #endregion

            Console.WriteLine("***Properties****");

            #region Step 4 - Write Code to Show all the public|private Properties in SkillsLab class
            // https://docs.microsoft.com/en-us/dotnet/api/system.type.getproperties?view=net-5.0
            #endregion

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Which Are you?"); // Expected To Write Either Jedi or SkillsLab 
            var typeName = $"Generics_SkillsLab.{Console.ReadLine()}"; // fully qualified typename, use this to convert to type later on

            Console.WriteLine("Id?"); //Common
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Name?"); //Common
            var name = Console.ReadLine();

            #region Step 5 - Instantiate using Activator
            //From string get the type
            //From type, create an instance using Activator and pass in the parameter and cast to the interface
            //https://docs.microsoft.com/en-us/dotnet/api/system.type.gettype?view=net-5.0
            //https://docs.microsoft.com/en-us/dotnet/api/system.activator?view=net-5.0


            IInterns actualOBJ; //use the following Activator.CreateInstance(.., new object[] { .. }) as IInterns

            //assign and return
            return null;
            #endregion
        }

        static void DisplayAllFieldAndPropertyValuesOfOBJ(IInterns intern)
        {
            Console.WriteLine(Environment.NewLine);

            #region Step 6 - Get all the private, public properties and fields of the objects and show the value 
            //https://docs.microsoft.com/en-us/dotnet/api/system.type.getfields?view=net-5.0#System_Type_GetFields
            //https://docs.microsoft.com/en-us/dotnet/api/system.type.getproperties?view=net-5.0
            //https://docs.microsoft.com/en-us/dotnet/api/system.reflection.fieldinfo.getvalue?view=net-5.0#System_Reflection_FieldInfo_GetValue_System_Object_
            //https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo.getvalue?view=net-5.0
            #endregion
        }
    }
}