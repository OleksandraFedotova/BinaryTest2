using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        //Пользователи из города заданого в параметр
        public List<User> FindUserByFromCityAndBirthday(string city)
        {
            var list = new List<User>();
           list= _users.FindAll(u => u._city == city &&( u._birthDate.Month ==DateTime.Today.Month&&u._birthDate.Day==DateTime.Today.Day));
            return list;
        }
        //ключ мужчина-женщина
        public List<User> FindUserByGender(string gender)
        {
            var list = new List<User>();
            list=_users.FindAll(u => u._gender == gender);
            return list;
        }
        //Пользователи с почтой gmail.com
        public List<User> FindUserByGmail()
        {
            var list= new List<User>();
            
             list=_users.FindAll(u => u._email.Host == "gmail.com");
            return list;
        }

        //старше 18 из Киева
        public List<User> FindUserOlderEighteenFromKyiv()
        {
            DateTime today=DateTime.Today;
            var list = new List<User>();

           list= _users.FindAll(u =>today.Year- u._birthDate.Year>=18&&(u._city=="Kyiv"||u._city=="Київ"||u._city=="Киев"));
            return list;
        }
        //От _ возраста до _ возраста
        public List<User> FindUserFromAgeToAge(int from , int to)
        {
            DateTime today = DateTime.Today;
            var list = new List<User>();
            list = _users.FindAll(u => today.Year - u._birthDate.Year >= from&& today.Year - u._birthDate.Year <=to );
            return list;
        }

        public List<User> FindUserGirlsForLastTenDays()
        {
            var list = new List<User>();
            list = _users.FindAll(u => u._timeAdded ==DateTime.Today.AddDays(-10));
            return list;
        }
        //
        public List<User> FindUserBirthInJanuary()
        {
            DateTime today = DateTime.Today;
            var list = new List<User>();
            list = _users.FindAll(u => u._birthDate.Month==01  && u._address!=null&&u._phoneNumber!=null);
            list.OrderByDescending(x => x._lastName) ;
            return list;
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
        public readonly DateTime _birthDate;
        public readonly DateTime _timeAdded;
        public readonly string _city;
        public readonly string _address;
        public readonly string _phoneNumber;
        public readonly string _gender ;
        public readonly MailAddress _email;

        public User(string firstName, string lastName, DateTime birthDate, string city, string address, string phoneNumber,
            string gender, MailAddress email)
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
            return "User: " + _firstName + " Lastname: " + _lastName + " Address: " + _address+" City"+ _city;
        }
    }
}
