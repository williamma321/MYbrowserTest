using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProblemTest
{
    class MyBrowser
    {
        public class MyTypeBrowserTest
        {
            private List<string> MyListofURLs;
            private int i_Indexof;

            public MyTypeBrowserTest()
             {
                i_Indexof = -1;
                List<string> iLMyListofURLs = new List<string>();
                MyListofURLs = iLMyListofURLs;
            }

            public void visit(string s_URL)
            {                
                int i_TrackLengthIndex =  (MyListofURLs.Count())-1;

                if (i_TrackLengthIndex <= 0)
                {
                    MyListofURLs.Add(s_URL);
                }
                else if (i_Indexof < i_TrackLengthIndex)
                {
                    MyListofURLs[i_Indexof] = s_URL;
                }
                else
                {
                    MyListofURLs.Add(s_URL);
                }  
                i_Indexof++;

            }
            public string back()
            {
                string s_ReturnURL = "NO BACK PAGE";
                
                if ( (i_Indexof <= MyListofURLs.Count()) && (i_Indexof >= 0))
                {                   
                    s_ReturnURL = MyListofURLs[i_Indexof-1];
                }

                i_Indexof--;

                return s_ReturnURL;
            }
            public string forward()
            {
                string s_ReturnURL = "NO FORWARD PAGE";

                if ((i_Indexof+1 <= MyListofURLs.Count()) && (i_Indexof >=0))
                {
                    s_ReturnURL = MyListofURLs[i_Indexof];
                }

                i_Indexof++;

                return s_ReturnURL;
            }
        }

    }

   
    
    class Program
    {
        static void Main(string[] args)
        {            

            MyBrowser.MyTypeBrowserTest testB = new MyBrowser.MyTypeBrowserTest();

            testB.visit("first URL");
            testB.visit("2nd URL");

            testB.visit("3rd URL");

            string test1 = testB.back();
            string test2 = testB.back();

            testB.visit("New URL1");
            testB.visit("New URL2");

            string testF1 = testB.forward();
            string testF2 = testB.forward();

            string test3 = testB.back();
            string test4 = testB.back();

            string test5 = testB.back();
            string test6 = testB.back();

            testB.visit("Newer URL0");
            testB.visit("Newer URL1");
			
			string test7 = testB.back();
            string test8 = testB.back();
			string test9 = testB.back();           


        }
    }
}
