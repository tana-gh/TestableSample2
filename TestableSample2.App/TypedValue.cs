using System;
using System.Text.RegularExpressions;

namespace TestableSample2.App
{
    public class TypedValue
    {
        public string   Value    { get; }
        public TypeKind TypeKind { get; }

        public TypedValue(string value)
        {
            Value = value;

            if (Regex.IsMatch(value, @"^(|null)$"))
            {
                TypeKind = TypeKind.Null;
            }
            else if (Regex.IsMatch(value, @"^(true|false)$"))
            {
                TypeKind = TypeKind.Bool;
            }
            else if (Regex.IsMatch(value, @"^-?[0-9]+(\.[0-9]+)?$"))
            {
                TypeKind = TypeKind.Number;
            }
            else
            {
                TypeKind = TypeKind.String;
            }
        }

        public void WriteLine()
        {
            Console.WriteLine($"{Value} : {ToString(TypeKind)}");
        }

        private string ToString(TypeKind typeKind)
        {
            switch (typeKind)
            {
                case TypeKind.Null:
                    return "null";

                case TypeKind.Bool:
                    return "bool";

                case TypeKind.Number:
                    return "number";

                case TypeKind.String:
                    return "string";
                    
                default:
                    return "";
            }
        }
    }
}
