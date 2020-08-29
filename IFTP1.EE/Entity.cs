using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IFTP1.Interfaces;

namespace IFTP1.EE
{
    public abstract class Entity : IEntity
    {
        public Entity()
        {
            Id = new int();
        }
        public int Id { get; set; }
    }
}
