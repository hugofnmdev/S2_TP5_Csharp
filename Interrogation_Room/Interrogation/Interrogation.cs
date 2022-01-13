using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Security;

namespace TP5
{
    public class Interview
    {
        public class Profile
        {
           
            public string Name; //name of the suspect ex: "Sherlock"
            public string Sex = ""; //gender of the suspect ex: "Male"
            public string Address = ""; //address of the suspect
            public uint Age = 0; //age of the suspect ex: 30
            public uint Size = 0; //size of the suspect ex: 180
            public List<string> Question = new List<string>(); //list of question
            public List<string> Answer = new List<string>(); //list of the answer

            public Profile(string name)
            {
                //TODO
            }
        }
        public static Profile ReadProfile(string path)
        {
            
        }

        public static void ReadQuestion(List<Profile> allProfiles, string path)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static void PrintInformation(Profile profile)
        {
            // TODO
            throw new NotImplementedException();
        }
        
        public static void SaveProfile(Profile profile)
        {
            // TODO
            throw new NotImplementedException();
        }
        
        public static void CreateProfile()
        {
            // TODO
            throw new NotImplementedException();
        }

        public static void Interrogation()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}