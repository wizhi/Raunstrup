﻿namespace Raunstrup.Model
{
    public class Product
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != default(int))
                {
                    // TODO: Handle object apparently already being persisted.
                }

                _id = value;
            }
        }

        public string Name { get; set; }

        public decimal SalesPrice { get; set; }
    }
}