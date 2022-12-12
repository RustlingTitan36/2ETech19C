using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Contact
    {
        private string emailAddress;
        private string faxNumber;
        private string name;
        private string primaryContactMethod;
        public string getEmailAddress()
        {
            return emailAddress;
        }
        public string getFaxNumber()
        {
            return faxNumber;
        }
        public string getName()
        {
            return name;
        }
        public string getPrimaryContactMethod()
        {
            return primaryContactMethod;
        }
        public void setEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;   
        }
        public void setFaxNumber(string faxNumber)
        {
            this.faxNumber = faxNumber;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPrimaryContactMethod(string primaryContactMethod)
        {
            this.primaryContactMethod = primaryContactMethod;
        }
    }
    class ContactGroup
    {
        private string name;
        public string getname()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }

    class Account
    {
        private string emailAddress;
        private string name;
        public string getEmailAddress()
        {
            return emailAddress;
        }
        public string getName()
        {
            return name;
        }
        public void setEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
    class AddressBook
    {
        private string name;
        public Contact GetContact(Contact name)
        {
            return name;
        }
        public ContactGroup GetContacts(ContactGroup name)
        {
            return name;
        }
        public string getName()
        {
            return name;
        }
        public void insertContact(Contact name)
        {
            Console.WriteLine(name);
        }
        public void setName(string name)
        {
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
