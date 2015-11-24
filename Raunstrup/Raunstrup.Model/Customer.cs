﻿namespace Raunstrup.Model
{
    public class Customer
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

        public string SteetName { get; set; }

        public string StreetNumber { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }
    }
}
