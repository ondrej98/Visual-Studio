using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClassMoje
    {
        private int _id;

        public int ID { get { return _id; } private set { _id = value; OnIDChange(value); } }

        public EventHandler IDChanged;

        protected virtual void OnIDChange(object sender)
        {
            IDChanged?.Invoke(sender, EventArgs.Empty);
        }

        public ClassMoje()
        {

        }
    }
}
