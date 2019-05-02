using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment5
{
    class PhoneBook : Phone
    {
        List<DanhBa> PhoneList = new List<DanhBa>();

        public PhoneBook(List<DanhBa> phoneList)
        {
            PhoneList = phoneList;
        }

        public void insertPhone(string name, string phone)
        {
            // vòng lặp dữ liệu
            foreach (DanhBa item in PhoneList)
            {
                if (!item.Name.Equals(name))
                {
                    Console.WriteLine("Test");
                    PhoneList.Add(new DanhBa(name, phone));
                }
                if (!item.Name.Equals(phone))
                {
                    item.Phone += phone;
                }

            }
        }

        public void removePhone(string name)
        {
            foreach (DanhBa item in PhoneList)
            {
                if (item.Equals(name))
                {
                    PhoneList.Remove(item);
                }
            }
        }

        public void searchPhone(string name)
        {
            foreach (DanhBa item in PhoneList)
            {
                if (item.Name.Equals(name))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void updatePhone(string name, string newphone)
        {
            foreach (DanhBa item in PhoneList)
            {
                if (item.Name.Equals(name))
                {
                    item.Phone = newphone;

                }
            }
        }
    }
}
