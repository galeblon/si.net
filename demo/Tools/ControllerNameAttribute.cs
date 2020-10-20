using System;

namespace demo.Tools
{
    public class ControllerNameAttribute : Attribute {

        public string Name { get; }

        public ControllerNameAttribute(string name) {
            // suffix Controller
            Name = name;
        }
    }
}