using System;

namespace DenemeInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pr1 = new Person();
            pr1.FirstName = "Ali";
            pr1.HomeAddress = "xxxxxxxxxxx";

            Student st1 = new Student();
            st1.FirstName = "Veli";
            st1.StudentNumber = 90;

            KisiManager kisiManager = new KisiManager();
            kisiManager.Add(pr1);
            kisiManager.Add(st1);
            kisiManager.Add(new Student { Id = 3, FirstName = "Mehmet", StudentNumber = 88 }) ;
            kisiManager.Add(new Person  { Id = 3, FirstName = "Osman", HomeAddress = "yyyyyyyyyyy" });
            Console.WriteLine("----------------------------------------------------------------------------------");
                      
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.WriteLine("----Aynı anda tüm veritabanlarında Add gerçekleştirme : --------------------------");
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(), 
                new OracleServerCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.WriteLine("----------------------------------------------------------------------------------");

            //Person[] kisi = new Person[] { pr1, pr2 };

            //foreach (var k in kisi)
            //{
            //    Console.WriteLine(k.FirstName);
            //}

            Console.WriteLine(10 % 3);


        }
    }
}
