using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Business.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
