using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingApp.Extensions
{
    public static class EnumerableExtensions
    {
        public static ObservableCollection<T> ConvertToObservableCollection<T>(this IEnumerable<T> values) => new ObservableCollection<T>(values);
    }
}
