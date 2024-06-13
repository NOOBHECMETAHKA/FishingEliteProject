using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace FishingElite
{
    public class MainFunctions
    {
        FishingEliteEntities2 db = new FishingEliteEntities2();

        public bool auth(string email, string password)
        {
            List<Employee> employees = db.Employee.Where(user => user.email.Equals(email) && user.password.Equals(password)).ToList<Employee>();
            return employees.Count > 0;
        }

        public List<Active> getActive()
        {
            return db.Active.ToList();
        }

        public List<Category> getCategory()
        {
            return db.Category.ToList();
        }

        public bool deleteActive(int id)
        {
            Active active = db.Active.Where(a => a.id == id).First();
            db.Active.Remove(active);
            db.SaveChanges();
            return true;
        }

        public bool createActive(string name, decimal oncePrice, int typeActiveID, string description)
        {
            Active active = new Active() { 
            
                name = name,
                once_price = oncePrice,
                category_id = typeActiveID,
                description = description
            };
            db.Active.Add(active);
            db.SaveChanges();

            return true;
        }
    }
}
