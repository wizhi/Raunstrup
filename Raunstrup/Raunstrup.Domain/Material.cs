﻿namespace Raunstrup.Domain
{
    public class Material : Product
    {
        public Material(string name)
        {
            Name = name;
        }
        private double _costPrice;
    }
}