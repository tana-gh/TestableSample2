using System.Collections.Generic;
using Xunit;
using TestableSample2.App;

namespace TestableSample2.Test
{
    public class Test_TypedValue
    {
        [Theory]
        [MemberData(nameof(Constructor_Data))]
        public void Constructor(TypeKind expected, string value)
        {
            var typedValue = new TypedValue(value);

            Assert.Equal(value   , typedValue.Value);
            Assert.Equal(expected, typedValue.TypeKind);
        }

        public static IEnumerable<object[]> Constructor_Data()
        {
            return new[] {
                new object[] { TypeKind.Null  , ""        },
                new object[] { TypeKind.Null  , "null"    },
                new object[] { TypeKind.Bool  , "true"    },
                new object[] { TypeKind.Bool  , "false"   },
                new object[] { TypeKind.Number, "0.0"     },
                new object[] { TypeKind.Number, "789"     },
                new object[] { TypeKind.Number, "-12.345" },
                new object[] { TypeKind.String, "a123"    },
                new object[] { TypeKind.String, "$#@?+"   }
            };
        }
    }
}
