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
        private int _id;
        private string _model;
        private int _speed;
        #endregion


        #region Properties
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
        #endregion

        // CLR will create parmaterless constructor
        // ctor
        //public Car()
        //{

        //}
        // this constructor do nothing


        //public Car()
        //{
        //    Id = default;
        //    Model = default;
        //    Speed = default;
        //}


        // Internally chaining
        //public Car(int id, string model, int speed) : this(id, model)
        //{
        //    Speed = speed;
        //}

        //public Car(int id, string model) : this(id)
        //{
        //    Model = model;
        //}

        //public Car(int id)
        //{
        //    Id = id;
        //}

        //public override string ToString()
        //{
        //    return $"ID: {Id}, Model: {Model}, Speed: {Speed}";
        //}
    }
}
