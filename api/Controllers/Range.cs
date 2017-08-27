using System;
using System.Collections.Generic;
using System.Linq;
using Faker.Extensions;

namespace api.Controllers
{
    public class Range
    {
        public int Count { get; set; } = 10;
        public bool Sort { get; set; } = false;

        public IEnumerable<TItem> Of<TItem>(Func<TItem> generateItem)
            => Count.Times(i => generateItem());
                // This should trigger a broken build
                //.OrderBy(n => Sort ? n : default(TItem)); 
    }
}
