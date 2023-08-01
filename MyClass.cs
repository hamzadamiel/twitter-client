using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twitter_test
{
    public static class MyClass
    {
        public const string Api_key = "e2RlgqmXOu2u6hipjwohoLjxp";//static-is a constant that can be retrieved outside of member function or class
        public const string other_key = "VeLME88GD9QnVS54yimgi3r8tG0RUPx6MZBLWiqJsUtOv9xyez";
        public enum keys{

            Api_key,
            other_key

        }

        private const int exitnum = 0;
        public static void InternetAvailable()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("http://www.google.com/"))
                    {


                    }
                }
            }
            catch
            {



                 MessageBox.Show("It seems you dont have an internet connection");
                 Application.Restart();
                 System.Windows.Forms.Application.Exit();
                 Environment.Exit(exitnum);
       
            }
            
        }
        public static void SignOut()
        {
            try
            {
                MessageBox.Show("Thanks");
                Application.Restart();

                try
                {
                    Environment.Exit(exitnum);
                }
                catch
                {

                }
               
            }

            catch
            {

            }
            
        }

    }
}
