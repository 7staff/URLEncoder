using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main()
        {
            try
            {
                string project_name = " ";
                string activity_name = " ";


                Console.WriteLine("Enter the project name");
                project_name = Console.ReadLine();
                project_name = project_name.Replace(" ", "%20");
                project_name = project_name.Replace("<", "%3C");
                project_name = project_name.Replace(">", "%3E");
                project_name = project_name.Replace("#", "%23");
                project_name = project_name.Replace("\"", "%22");
                project_name = project_name.Replace(";", "3B");
                project_name = project_name.Replace("/", "%2F");
                project_name = project_name.Replace("?", "%3F");
                project_name = project_name.Replace(":", "%3A");
                project_name = project_name.Replace("@", "%40");
                project_name = project_name.Replace("&", "%26");
                project_name = project_name.Replace("=", "%3D");
                project_name = project_name.Replace("+", "%2B");
                project_name = project_name.Replace("$", "%24");
                project_name = project_name.Replace(",", "%2C");
                project_name = project_name.Replace("{", "%7B");
                project_name = project_name.Replace("}", "%7D");
                project_name = project_name.Replace("|", "%7C");
                project_name = project_name.Replace("\\", "%5C");
                project_name = project_name.Replace("^", "%5E");
                project_name = project_name.Replace("[", "%5B");
                project_name = project_name.Replace("]", "%5D");
                project_name = project_name.Replace("`", "%60");

                Console.WriteLine("Enter the activity name");
                activity_name = Console.ReadLine();
                activity_name = activity_name.Replace(" ", "%20");
                activity_name = activity_name.Replace("<", "%3C");
                activity_name = activity_name.Replace(">", "%3E");
                activity_name = activity_name.Replace("#", "%23");
                activity_name = activity_name.Replace("\"", "%22");
                activity_name = activity_name.Replace(";", "3B");
                activity_name = activity_name.Replace("/", "%2F");
                activity_name = activity_name.Replace("?", "%3F");
                activity_name = activity_name.Replace(":", "%3A");
                activity_name = activity_name.Replace("@", "%40");
                activity_name = activity_name.Replace("&", "%26");
                activity_name = activity_name.Replace("=", "%3D");
                activity_name = activity_name.Replace("+", "%2B");
                activity_name = activity_name.Replace("$", "%24");
                activity_name = activity_name.Replace(",", "%2C");
                activity_name = activity_name.Replace("{", "%7B");
                activity_name = activity_name.Replace("}", "%7D");
                activity_name = activity_name.Replace("|", "%7C");
                activity_name = activity_name.Replace("\\", "%5C");
                activity_name = activity_name.Replace("^", "%5E");
                activity_name = activity_name.Replace("[", "%5B");
                activity_name = activity_name.Replace("]", "%5D");
                activity_name = activity_name.Replace("`", "%60");


                string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";
                for (int ctr = 0; ctr < url.Length; ctr++)
                {
                    if (Char.IsControl(url, ctr))
                        Console.WriteLine("Control character found. URL is invalid.",
                          Convert.ToInt32(url[ctr]).ToString("X4"), ctr);
                 

                }
                Console.WriteLine("\n");
                Console.WriteLine(url);
                
            }
            catch
            {
                Console.WriteLine("Please enter vaild details");
                Console.ReadLine();
            }
            {


                Console.WriteLine("Would you like to restart? y or n");

                String restart = Console.ReadLine();

                if (restart == "y")
                    Main();

           


            }
        }
    }
}
