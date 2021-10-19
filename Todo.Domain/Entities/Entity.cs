﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Entities
{    
    public abstract class Entity 
    {
        public Entity()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

    }
}
