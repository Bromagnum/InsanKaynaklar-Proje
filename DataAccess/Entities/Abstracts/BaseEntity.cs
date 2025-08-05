using DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Abstracts
{
    public abstract class BaseEntity : IBaseEntity<Guid>
    {
       
        public Guid MasterId { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIpAddress { get; set; }
        public DataStatus DataStatus { get; set; }

        public void CreatedAudit()
        {
            CreatedDate = DateTime.Now;
            CreatedComputerName = Environment.MachineName;
            DataStatus =DataStatus.Active; 
        }
        public void UpdatedAudit()
        {
            UpdatedDate = DateTime.Now;
            UpdatedComputerName = Environment.MachineName;
            DataStatus = DataStatus.Updated;
        }
    }
}
