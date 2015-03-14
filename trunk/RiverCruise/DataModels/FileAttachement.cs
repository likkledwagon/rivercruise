using System;
using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class FileAttachement
    {
        public string Name { get; set; }
        public byte[] FileBytes { get; set; }

        [Key]
        public int Id { get; set; }
        public DateTime InsetTime { get; set; }
        public string Type { get; set; }
        public virtual Ship Ship { get; set; }
    }
}