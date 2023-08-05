using AccountBook.DataAccess;
using AccountBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Utils
{
    public static class Extensions
    {
        public static IEnumerable<CommonCode> GetByCategoryType(this IEnumerable<CommonCode> commonCodes, CategoryType categoryType) 
        {
            return from commonCode in commonCodes
                   where commonCode.Type == (int)categoryType
                   select commonCode;
        }

        public static List<T> ToCategories<T>(this IEnumerable<CommonCode> commonCodes) where T : BaseCategory, new()
        {
            var categories = new List<T>();

            foreach (var commonCode in commonCodes)
            {
                categories.Add(new T 
                {
                    Id = commonCode.Id,
                    IsDeleted = Convert.ToBoolean(commonCode.IsDeleted),
                    Name = commonCode.Name,
                    Amount = commonCode.Amount,
                    Sequence = commonCode.Sequence
                });
            }

            return categories;
        }

        public static T FirstOrDefaultDeepCopy<T>(this List<T> source, Func<T, bool> predicate) where T : BaseCategory
        {
            T item = source.FirstOrDefault(predicate);

            return item != null ? (T)item.Clone() : default;
        }

        public static void SwapSequence<T>(this List<T> source, int index, bool isUp) where T : BaseCategory 
        {
            int capacity = source.Count;
            int swap;

            if (isUp) 
            {
                if (index == 0) 
                {
                    return;
                }

                swap = (int)source[index - 1].Sequence;
                source[index - 1].Sequence = source[index].Sequence;
                source[index].Sequence = swap;

                return;
            }

            if (capacity <= index + 1) 
            {
                return;
            }

            swap = (int)source[index + 1].Sequence;
            source[index + 1].Sequence = source[index].Sequence;
            source[index].Sequence = swap;
        } 
    }
}
