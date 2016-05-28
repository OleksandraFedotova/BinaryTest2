using System;
using System.Collections.Generic;
using System.Linq;
using Logger;

namespace AddressBook
{
    public class AddressBook
    {
        /*----------properties */
        private List<User> _users;
        private static AddressBook _book;
        private Logger.Logger _logger;

        /*   ------------      events   --------- */
        
        public event LogDelegate UserAdded;
        public event LogDelegate UserRemoved;

        private AddressBook()
        {
            _users = new List<User>();   
        }

        public static AddressBook Book
        {
            get
            {
                if (_book != null)
                {
                    return _book;
                }
                else
                {
                    return new AddressBook();
                }
            }
        }

        /*----------   Methods Add and Remove User -----------*/

        public void AddUser(User user)
        {
            try
            {
                //раскоментировать для проверки работы LogError
                //_users = null; 
                _users.Add(user);
                UserAdded = _logger.LogInfo;
            }
            catch (Exception)
            {
                UserAdded = _logger.LogError;
            }
            finally
            {
                UserAdded(user + " ADDED");
            }
        }

        public void RemoveUser(User user)
        {
            try
            {
                //раскоментировать для проверки работы LogError
                //_users = null; 
                _users.RemoveAll(u => u._firstName == user._firstName && u._lastName == user._lastName);
                UserRemoved = _logger.LogInfo;
            }
            catch (Exception)
            {
                UserRemoved = _logger.LogError;
            }
            finally
            {
                UserRemoved(user + " REMOVED");
            }
        }

        public void SetLogger(Logger.Logger logger)
        {
            this._logger = logger;
        }

        //Метод не относится к общей архитектуре - просто отображает содержание AddressBook
        public string Print()
        {
            string res = null;
            foreach (User user in _users)
            {
                res += user + "\n";
            }
            return res;
        }
    }

    public class User
    {
        public readonly string _firstName;
        public readonly string _lastName;
        private readonly string _birthDate;
        private readonly DateTime _timeAdded;
        private readonly string _city;
        private readonly string _address;
        private readonly string _phoneNumber;
        private readonly string _gender;
        private readonly string _email;

        public User(string firstName, string lastName, string birthDate, string city, string address, string phoneNumber,
            string gender, string email)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._birthDate = birthDate;
            this._address = address;
            this._city = city;
            this._phoneNumber = phoneNumber;
            this._gender = gender;
            this._email = email;
            this._timeAdded = DateTime.Now;
        }

        public override string ToString()
        {
            return "User: " + _firstName + " Lastname: " + _lastName + " Address: " + _address;
        }
    }
}
