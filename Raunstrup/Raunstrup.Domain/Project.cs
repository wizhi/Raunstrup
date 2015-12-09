﻿using System;

namespace Raunstrup.Domain
{
    public class Project
    {
        private int _id;

        public virtual int Id
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

        public virtual Draft Draft { get; private set; }
        // TODO: Consider renaming this to something more related to "beginning a project".
        public virtual DateTime OrderDate { get; set; }

        public Project(Draft draft)
        {
            Draft = draft;
            OrderDate = DateTime.Now;
        }
    }
}
