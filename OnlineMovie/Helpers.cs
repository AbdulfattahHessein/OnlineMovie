using OnlineMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie
{
    public static class Helpers
    {
        public static void Save<T>(this List<T> entities, T entity) where T : IEntity
        {
            entity.Save();
            entities.Add(entity);
        }
    }
}
