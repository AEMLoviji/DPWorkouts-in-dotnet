using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPWorkout.Structural.Bridge
{
    /// <summary>
    /// Abstraction class used in Bridge pattern
    /// </summary>
    public class UserBL
    {
        protected IDatabase _db;

        public UserBL(IDatabase db)
        {
            _db = db;
        }

        public void Delete(string userName)
        {
            _db.DeleteUser(userName);
        }

        public void Get(string userName)
        {
            _db.GetUser(userName);
        }

        public void Insert(string userName)
        {
            _db.InsertUser(userName);
        }

        public void Update(string userName, string newUserName)
        {
            _db.UpdateUser(userName, newUserName);
        }
    }
}
