using SCMSTestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCMSTestServer.Services
{
    public abstract class BaseService<Model, Instance>
        where Instance : new()
        where Model : BaseModel
    {
        public static Lazy<Instance> loader;

        public static Instance ServiceInstance
        {
            get
            {
                if (loader == null)
                {
                    loader = new Lazy<Instance>(() => new Instance());
                }

                return loader.Value;
            }
        }

        public List<Model> AllObjects { get; set; }

        public abstract List<Model> GetAll();

        public virtual Model Get(string id)
        {
            if (AllObjects == null)
                GetAll();

            var obj = AllObjects?.SingleOrDefault(c => c.ID == id);

            if (obj == null)
                throw new Exception("Requested Resource not found");

            return obj;
        }

        public virtual bool Add(Model model)
        {
            if (model.ID == null)
                model.ID = Guid.NewGuid().ToString();

            if (AllObjects.SingleOrDefault(c => c.ID == model.ID) != null)
                throw new Exception("Requested Object already Exists");
            AllObjects?.Add(model);

            return AllObjects.SingleOrDefault(c => c.ID == model.ID) != null;
        }

        public virtual bool Update(Model model)
        {
            if (AllObjects.SingleOrDefault(c => c.ID == model.ID) == null)
                throw new Exception("Requested Object does nor Exists");

            AllObjects?.Remove(AllObjects?.SingleOrDefault(c => c.ID == model.ID));

            AllObjects?.Add(model);

            return AllObjects.SingleOrDefault(c => c.ID == model.ID) != null;
        }

        public virtual bool Delete(string id)
        {
            if (AllObjects?.SingleOrDefault(c => c.ID == id) == null)
                throw new Exception("The Requested Resource does not exist");

            return (AllObjects?.Remove(AllObjects?.SingleOrDefault(c => c.ID == id))).Value;
        }

        public Instance GetInstance()
        {
            return ServiceInstance;
        }
    }
}