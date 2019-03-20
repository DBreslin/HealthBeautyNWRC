using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairBeautyNWRC
{
    class MyValidation
    {
        // check text is the correct Length and not empty
        public static bool validLength(String text, int min, int max)
        {
            bool ok = true;

            if (String.IsNullOrEmpty(text) || text.Length < min || text.Length > max)
            {
                ok = false;
            }

            return ok;
        }


        // Check it is a valid number
         public static bool validNumber(String text)
        {
            bool ok = true;

            for (int x = 0; x < text.Length; x++)
            {
                if (!(char.IsNumber(text[x])))
                {
                    ok = false;
                }
               
            }
            return ok;
        }

        //check it is a vaild letter 
         public static bool validLetter(String text)
         {
             bool ok = true;
             if (text.Trim().Length == 0)
             {
                 ok = false;
             }
             else
             {
                 for (int x = 0; x < text.Length; x++)
                 {
                     if (!(char.IsLetter(text[x])))
                         ok = false;
                 }
             }
             return ok;
         }

        // allows alphabetic characters and whitespace
        public static bool validLetterWhitespace(String text)
         {
             bool ok = true;

             if (text.Trim().Length == 0)
             {
                 ok = false;
             }
             else
             {
                 for (int x = 0; x < text.Length; x++)
                 {
                     if (!(char.IsLetter(text[x])) && !(char.IsWhiteSpace(text[x])))
                         ok = false;
                 }
             }
             return ok;
         }

        // allows alphabetic characters, dash and whitespace
        public static bool validForename(String text)
        {
            bool ok = true;

            if (text.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < text.Length; x++)
                {
                    if (!(char.IsLetter(text[x])) && !(char.IsWhiteSpace(text[x])) && !(text[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }

        // allows alphabetic characters, dash and whitespace
        public static bool validSurname(String text)
        {
            bool ok = true;

            if (text.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < text.Length; x++)
                {
                    if (!(char.IsLetter(text[x])) && !(char.IsWhiteSpace(text[x])) && !(text[x].Equals('-')) && !(text[x].Equals('\'')))
                        ok = false;
                }
            }
            return ok;
        }

        // allows alphanumeric characters and whitespace
        public static bool validEmail(String text)
        {
            bool formatOk = true;
            bool regionOk = false;
            bool allOk = false;

            if (text.Trim().Length == 0)
            {
                formatOk = false;
            }
            else if (!(text.Contains("@")) || text[0].Equals('@'))
            {
                formatOk = false;
            }
           else
            {
                for (int x = 0; x < text.Length; x++)
                {
                    if (text[x].Equals('@'))
                    {
                        if (!(char.IsLetter(text[x - 1])) && !(char.IsNumber(text[x - 1])) && !(text[x - 1].Equals('-')) && !(text[x - 1].Equals('_')) && !(text[x - 1].Equals('.')))
                        {
                            formatOk = false;
                        }
                        
                    }

                    if (!(char.IsLetter(text[x])) && !(char.IsNumber(text[x])) && !(text[x].Equals('@')) && !(text[x].Equals('-')) && !(text[x].Equals('_')) && !(text[x].Equals('.')))
                        formatOk = false;
                }

                
            }

            if ((text.EndsWith(".com")) && text.IndexOf(".com")>0)
            {
                int loc = text.IndexOf(".com");
                if (!(char.IsLetter(text[loc - 1])) && !(char.IsNumber(text[loc - 1])) && !(text[loc - 1].Equals('-')) && !(text[loc - 1].Equals('_')))
                    formatOk = false;
                else
                regionOk = true;
            }
            else if ((text.EndsWith(".uk")) && text.IndexOf(".uk") > 0)
            {
                int loc = text.IndexOf(".uk");
                if (!(char.IsLetter(text[loc - 1])) && !(char.IsNumber(text[loc - 1])) && !(text[loc - 1].Equals('-')) && !(text[loc - 1].Equals('_')))
                    formatOk = false;
                else
                    regionOk = true;
            }
            else if ((text.EndsWith(".net")) && text.IndexOf(".net") > 0)
            {
                int loc = text.IndexOf(".net");
                if (!(char.IsLetter(text[loc - 1])) && !(char.IsNumber(text[loc - 1])) && !(text[loc - 1].Equals('-')) && !(text[loc - 1].Equals('_')))
                    formatOk = false;
                else
                    regionOk = true;
            }
            else if ((text.EndsWith(".org")) && text.IndexOf(".org") > 0)
            {
                int loc = text.IndexOf(".org");
                if (!(char.IsLetter(text[loc - 1])) && !(char.IsNumber(text[loc - 1])) && !(text[loc - 1].Equals('-')) && !(text[loc - 1].Equals('_')))
                    formatOk = false;
                else
                    regionOk = true;
            }
            else if ((text.EndsWith(".edu")) && text.IndexOf(".edu") > 0)
            {
                int loc = text.IndexOf(".edu");
                if (!(char.IsLetter(text[loc - 1])) && !(char.IsNumber(text[loc - 1])) && !(text[loc - 1].Equals('-')) && !(text[loc - 1].Equals('_')))
                    formatOk = false;
                else
                    regionOk = true;
            }
            else if ((text.EndsWith(".gov")) && text.IndexOf(".gov") > 0)
            {
                int loc = text.IndexOf(".gov");
                if (!(char.IsLetter(text[loc - 1])) && !(char.IsNumber(text[loc - 1])) && !(text[loc - 1].Equals('-')) && !(text[loc - 1].Equals('_')))
                    formatOk = false;
                else
                    regionOk = true;
            }
            else if ((text.EndsWith(".ie")) && text.IndexOf(".ie") > 0)
            {
                int loc = text.IndexOf(".ie");
                if (!(char.IsLetter(text[loc - 1])) && !(char.IsNumber(text[loc - 1])) && !(text[loc - 1].Equals('-')) && !(text[loc - 1].Equals('_')))
                    formatOk = false;
                else
                    regionOk = true;
            }

            if (regionOk && formatOk)
                allOk = true;

            return allOk;
        }

        // check DOB Date is vaild
        public static bool ValidDOB(String text)
        {
            DateTime curentDate = DateTime.Now;
            DateTime dob = Convert.ToDateTime(text);

            TimeSpan t = curentDate - dob;
            double noOfDays = t.TotalDays;

            bool ok = true;

            if (text.Trim().Length == 0 || t.TotalDays == 0) // Maybe change this from 0 days to an age that should be the minimum to visit salon
            {
                ok = false;
            }
            return ok;
        }

        // Change first letter of words to Upper
        public static String firstlettertoUpper(String word)
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }

            // Check for any spaces and make the first letter after the space an Uppercase letter
            for (int x = 1; x < array.Length; x++)
            {
                if(array[x-1] == ' ')
                {
                    if(Char.IsLower(array[x]))
                    {
                        array[x] = Char.ToUpper(array[x]);
                    }
                }
                else
                {
                    array[x] = Char.ToLower(array[x]);
                }  
            }
            return new String(array);
        }

        public static bool postcodeChk(String post)
        {
            bool ok = true;

            if (post.Trim().Length == 0)
                ok = false;
            else if (post.Length > 8)
                ok = false;
            else if(post.Length>=1 && !(char.IsLetter(post[0])))
                    ok = false;
            else if (post.Length >= 2 && !(char.IsLetter(post[1])))
                    ok = false;
            else if (post.Length >= 3 && !(char.IsNumber(post[2])))
                    ok = false;
            else if (post.Length >= 4 && !(char.IsNumber(post[3])))
                    ok = false;
            else if (post.Length >= 5 && !(char.IsWhiteSpace(post[4])))
                    ok = false;
            else if (post.Length >= 6 && !(char.IsNumber(post[5])))
                    ok = false;
            else if (post.Length >= 7 && !(char.IsLetter(post[6])))
                    ok = false;
            else if (post.Length == 8 && !(char.IsLetter(post[7])))
                    ok = false;

            return ok;
        }

    }
}
