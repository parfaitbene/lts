using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTS2.Models
{
    class Warehouse
    {
        public long id; 
        public String code;
        public String name;
        public String description;

        public Warehouse()
        {
            this.code = "";
            this.name = "";
            this.description = "";
        }

        public Warehouse(String code, String name, String description)
        {
            this.code = code;
            this.name = name;
            this.description = description;
        }

        public Warehouse(long id, String code, String name, String description)
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.description = description;
        }
    }
}
