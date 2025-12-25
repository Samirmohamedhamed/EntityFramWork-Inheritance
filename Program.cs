using EntityFrameWorkCodeFirst.Data;
using InheritanceCodeByEntityFramWork.Models;

namespace InheritanceCodeByEntityFramWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*************************************************************/
            //
            //    I Hope This Help You
            //    I Hope You Get Benefit From It
            //    it's My Pleasure to Help You
            //
            //ادعي لي بالخير وبالتوفيق  وبصلاح الحال 
            // سمير محمد_حاسبات ومعلومات_جامعة الزقازيق 
            //My Linkendin Profile: https://www.linkedin.com/in/samir-mohamed-074896383
            //
            //*************************************************************/


            // I Create Three Classes Person, Employee, Student
            // Person is Base Class
            // Employee and Student are Derived Classes
            //now i will make a migration and update database
            // PM> Add-Migration InitialInheritanceDataCreate
            // PM> Update-Database
            //in first migration only one table will be created named People with a discriminator column  This way is Called TPH (Table Per Hierarchy) to determine the type of the entity but the null values will be allowed in the derived class columns to solve this issue we can use TPT or TPC inheritance strategy
            //TPT (Table Per Type): In this strategy, each class in the inheritance hierarchy is mapped to a separate table in the database. The base class table contains the common properties, while each derived class table contains the specific properties along with a foreign key reference to the base class table.
            //I will Use TPT Strategy
            // PM> Add-Migration TPTInheritanceDataCreate
            // PM> Update-Database
            //TPT issue: TPT can lead to performance issues due to the need for joins between multiple tables when querying for derived types.
            //Tpc (Table Per Concrete Class): In this strategy, each concrete class in the inheritance hierarchy is mapped to its own table in the database. Each table contains all the properties of the class, including those inherited from the base class. There is no separate table for the base class.
            //I will Use TPC Strategy and put abstract before Person class to make it abstract class
            // PM> Add-Migration TPCInheritanceDataCreate
            // PM> Update-Database
            //Now I will add data to the database 2 tables Students and Employees
            SamirContext samirContext = new SamirContext();
            Student std = new Student() { Name = "Mohamed", Age = 24, Grade = 12 };
            Employee emp = new Employee() { Name = "Samir", Age = 24, Salary = 1200 };
            samirContext.Students.Add(std);
            samirContext.Employees.Add(emp);
            samirContext.SaveChanges();
            // 3 Strategies for Inheritance in Entity Framework
            // 1 - TPH (Table Per Hierarchy => Defult) هيعمل جدول واحد لكل الوراثة كلها وعيوبة انة هيكون في Null Values في الاعمدة بتاعة الكلاسات الابناء
            //2 - TPT (Table Per Type) هيعمل جدول لكل كلاس في الوراثة وهيربطهم بعلاقة Foreign Key وعيوبة انة هيكون في مشكلة في الاداء بسبب Joins الكتير
            // 3 - TPC (Table Per Concrete Class) هيعمل جدول لكل كلاس في الوراثة وهيحط كل الاعمدة بتاعة الكلاس الاب والابناء في الجدول بتاع الكلاس الابن وميزة انة هيكون في اداء افضل من TPT


         
        }
    }
}
