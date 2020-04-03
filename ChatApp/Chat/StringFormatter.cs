using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Net.Mail.MailAddress;
using System.Net.Mail;

namespace Chat
{
    class StringFormatter
    {
        public string NameFormat(string name)
        {
            string formattedName = name.Trim();
            return formattedName;
        }

        public string PhoneNumberFormat(string phoneNumber)
        {
            try
            {
                    string formattedPhoneNumber = String.Format("{0:(###) ###-####}", Int64.Parse(phoneNumber.Replace(" ", "")));
                    return formattedPhoneNumber;
            }
            catch (Exception)
            {
                return phoneNumber;
            }
        }

        public bool IsContainingChars(string text)
        {
            var regexItem = new Regex("^[a-zA-Z ]*$");
            bool result = regexItem.IsMatch(text);
            if (result)
            {
                return result;
            }
            else
            {
                return result;
            }
        }

        public bool IsEmailValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
