﻿using DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Abstracts
{
    internal interface IBaseEntity<T>
    {
        public T MasterId { get; set; }
        public int Id { get; set; }

        //CreatedProperties
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }

        //UpdatedProperties

        public DateTime UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIpAddress { get; set; }

        public DataStatus DataStatus { get; set; }

    }
}
