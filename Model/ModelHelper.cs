using System;
using System.Collections.Generic;
using System.Reflection;

namespace Model
{
    public class ModelHelper<TEntity, TModel> where TEntity : class, new() where TModel : class, new()
    {
        //public ibaseservice

        public static TModel EntityToModel(TEntity entity)
        {
            var model = new TModel();

            var type2 = typeof(TModel);
            var props2 = type2.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in props2)
            {
                var name = property.Name;
                var pro = typeof(TEntity).GetProperty(name);

                object value = null;
                if (pro == null)
                {
                    var table = name.Substring(0, name.Length - 4); // 得到表名，采用默认约定的方式
                    var id = Convert.ToInt32(typeof(TEntity).GetProperty(table + "Id")?.GetValue(entity));
                    value = GetEntityName(table, id);
                }
                else
                {
                    value = pro.GetValue(entity, null);
                }

                model.GetType().GetProperty(name)?.SetValue(model, value);

            }

            var type = typeof(TEntity);
           
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in props)
            {
                var name = property.Name;
                var value = type.GetProperty(name)?.GetValue(entity, null);
                model.GetType().GetProperty(name)?.SetValue(model, value);
            }

            return model;
        }


        //public static TModel EntityToModel(TEntity entity)
        //{
        //    var model = new TModel();

        //    var type = typeof(TEntity);
        //    //object obj = Activator.CreateInstance(type);
        //    var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        //    foreach (var property in props)
        //    {
        //        //property
        //        var name = property.Name;
        //        var value = type.GetProperty(name)?.GetValue(entity, null);
        //        model.GetType().GetProperty(name)?.SetValue(model, value);
        //    }

        //    return model;
        //}

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

        public static List<TModel> EntitiesToModels2(List<TEntity> entities)
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

        private static object GetEntityName(string table, int id)
        {

            object propName = null;
            dynamic entity;

            if (table == "CargoInfo")
            {
                entity = GetEntity<CargoInfo>(id);
            }
            else if (table == "ProjectInfo")
            {
                entity = GetEntity<ProjectInfo>(id); // 别的表
            }
            else
            {
                 entity = GetEntity<ProjectInfo>(id); // 别的表
            }
            
            //entity = db.Set<table>().Find(id);
            var colName = table.Substring(0, table.Length - 4) + "Name"; // 去除约定Info + Name
            propName = entity?.GetType().GetProperty(colName)?.GetValue(entity); // 数据库表的约定
            return propName;
        }

        private static T GetEntity<T>(int id) where T : class, new()
        {
            var db = new EntityFrameworkDataModelContainer();
            var entity = db.Set<T>().Find(id);
            return entity;
        }
    }
}
