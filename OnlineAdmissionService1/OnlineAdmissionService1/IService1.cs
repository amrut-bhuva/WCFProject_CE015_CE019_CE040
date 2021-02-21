using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
namespace OnlineAdmissionService1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string RegisterStudent(Student s);
        [OperationContract]
        string ValidateUser(string username, string password);
        [OperationContract]
        getmerit Merit();

    }
    [DataContract]
    public class Student
    {
        String name = string.Empty;
        String email = string.Empty;
        String mo = string.Empty;
        int pcm = 0;
        int guj = 0;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string Mo
        {
            get { return mo; }
            set { mo = value; }
        }
        [DataMember]
        public int Pcm
        {
            get { return pcm; }
            set { pcm = value; }
        }
        [DataMember]
        public int Guj
        {
            get { return guj; }
            set { guj = value; }
        }
    }
    [DataContract]
    public class getmerit
    {
        [DataMember]
        public DataTable merit
        {
            get;
            set;
        }
    }
}