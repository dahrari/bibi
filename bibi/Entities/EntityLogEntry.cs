using System;
using System.Collections.Generic;
using System.Text;

namespace bibi.Entities
{
    class EntityLogEntry
    {
        public IParty Subject;
        public string WhatWasDone;
        public IParty Object;
        public string Subobject;

        public DateTime Time;

        public EntityLogEntry()
        {
            Time = DateTime.Now;
        }
    }
}
