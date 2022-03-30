using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Entities
{
    public class Person
    {
        const string DefaultName = "DefaultPersonName";

        public int Id { get; private set; }

        public string Name { get; private set; } = DefaultName;
    }
}
