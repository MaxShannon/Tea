using System.Collections.Generic;
using System.Reflection;

namespace Model
{
    public class ModelHelper<TEntity, TModel> where TEntity : class, new() where TModel : class, new()
    {
        public static TModel EntityToModel(TEntity entity)
        {
            var t = new TModel();

            var type = typeof(TEntity);
            //object obj = Activator.CreateInstance(type);
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in props)
            {
                //property
                var name = property.Name;
                var value = type.GetProperty(name)?.GetValue(entity, null);
                t.GetType().GetProperty(name)?.SetValue(t, value);
            }

            return t;
        }

        public static List<TModel> EntitiesToModels(List<TEntity> entities)
        {
            var models = new List<TModel>();
            foreach (var entity in entities)
            {
                models.Add(EntityToModel(entity));
            }
            //IEnumerator GetEnumerator() => models.GetEnumerator();
            //var c = models.GetEnumerator();//Aggregate(1, (current, t) => current * t);
            //models.
            return models;

        }
    }
}
