using System.ComponentModel.DataAnnotations;

namespace SenaiAPI.Entidades
{
    public class BaseEntity
    {
        [Key] //primary key
        public long Id { get; set; }
    }
}
