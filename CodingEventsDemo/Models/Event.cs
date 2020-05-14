﻿using System;
namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }

        public Event(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
