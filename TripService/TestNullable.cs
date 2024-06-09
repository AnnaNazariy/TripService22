#nullable enable

using System;

namespace TripService
{
    public class TestNullable
    {
        public string? NullableString { get; set; }

        public void CheckNullability()
        {
            if (NullableString == null)
            {
                Console.WriteLine("NullableString is null");
            }
            else
            {
                Console.WriteLine(NullableString.Length);
            }
        }
    }
}
