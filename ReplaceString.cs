using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raja_project
{
    class ReplaceString
    {
        public static void ReadingInputFromUser()
        {
            Console.WriteLine(" please enter your UserName");
            string name = Console.ReadLine();
            if (name.Length >= 3)
            {
                ReplaceStringWithTemplate(name);
            }
            else
            {
                Console.WriteLine("please provide atleast 3 characters");
            }
        }
        public static void ReplaceStringWithTemplate(string name)
        {
            string template = "Hello <<userName>>,How are you?";
            if (template.Contains("<<userName>>"))
            {
                string result = template.Replace("<<userName>>", name);
                Console.WriteLine("after Replace :" + result);

            }
            else
            {
                Console.WriteLine("userName not exists");
            }
        }
    }
}

