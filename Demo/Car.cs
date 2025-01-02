using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        #region Attributes
        //private int id; // 4
        //private int speed; // 4
        //private string model; // 8
        #endregion

        #region Properties
        //public string Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}
        //public int Speed
        //{
        //    get { return speed; }
        //    set { speed = value; }
        //}
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        #endregion

        // public string Address { get; set; } : prop

        // Clr will generate parameterless constructor
        // This constructor will do nth  

        // ctor

        //public Car()
        //{
        //    Id = default;
        //    Model = default;
        //    Speed = default;
        //}
        // Do Nothing 

        //public Car(int id , int speed , string model): this(id,speed)
        //{
        //    //Id = id;
        //    //Speed = speed;
        //    Model = model;
        //}
        //public Car(int id , int speed ):this(id)
        //{
        //    //Id = id;
        //    Speed = speed;

        //}
        //public Car(int id )
        //{
        //    Id = id;      
        //}
        //public override string ToString()
        //{
        //    return $"Id : {id} , Model : {model} , Speed : {speed}";
        //}

    }
}
