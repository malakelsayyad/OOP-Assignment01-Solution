using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        //private int id;
        //private string name ; 
        //private double salary;
        //private string address;
        // Address

        #region Apply Encapsulation using Setter Getter method

        // Apply Encapsulation using Setter Getter method

        // Setter 
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        // Getter
        //public int GetId()
        //{
        //    return id;
        //}

        // Setter Name 
        //public void SetName(string name)
        //{
        //    if (name.Length >= 8 && name.Length <= 20)
        //    {
        //        this.name = name;
        //    }
        //}  
        // Getter Name

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetSalary(double salary)
        //{
        //    if (salary > 0) 
        //    {
        //        this.salary = salary;
        //    }
        //}

        //public double GetSalary() 
        //{
        //  return salary;
        //} 
        #endregion

        #region Apply Encapsulation using properties
        // Apply Encapsulation using properties [Recommended]


        #region Full property
        // 1.Full property 

        // Id
        //public int Id
        //{
        //    //set
        //    //get

        //    set
        //    {
        //        id = value;
        //    }

        //    get
        //    {
        //        return id;
        //    }
        //}

        // Name
        //public string Name
        //{
        //    //set
        //    //get

        //    set
        //    {
        //        if (value.Length >= 8 && value.Length <= 20)
        //        {
        //            name = value;
        //        }
        //    }

        //    get
        //    {
        //        return name;
        //    }
        //}

        // Salary
        //public double Salary
        //{

        //    set
        //    {
        //        if (value > 0)
        //        {
        //            salary = value;
        //        }
        //    }

        //    get
        //    {
        //        return salary;
        //    }
        //} 
        #endregion


        #region Automatic property
        // 2.Automatic property
        //public string Address { set; get; } 
        #endregion

        // 3.Special property [Indexer]


        //public Employee(int id, string name, double salary)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(salary);

        //}

        //public override string ToString()
        //{
        //    return $" Id : {id} :: Name : {name} :: Salary : {salary}";
        //} 
        #endregion
    }
}
