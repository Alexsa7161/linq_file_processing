using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Context
    {
        public string path { get; set; }
        private int num_task;
        public IStrategy ContextStrategy { get; set; }
        public Context(IStrategy _strategy, string path, int num_task)
        {
            ContextStrategy = _strategy;
            this.path = path;
            this.num_task = num_task;
        }

        public void ExecuteAlgorithm()
        {
            switch (num_task)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
