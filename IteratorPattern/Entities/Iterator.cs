﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Entities
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }
}
