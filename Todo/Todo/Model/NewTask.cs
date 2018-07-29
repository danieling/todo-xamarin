using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Model
{
    class NewTask
    {
        [PrimaryKey, AutoIncrement, Column("_id_task")]
        public int Id
        {
            get;
            set;
        }

        [MaxLength(100)]
        public string Nombre
        {
            get; set;
        }

        public DateTime Fecha
        {
            get; set;
        }

        public TimeSpan Hora
        {
            get; set;
        }

        public bool TaskComplete
        {
            get; set;
        }
    }
}
