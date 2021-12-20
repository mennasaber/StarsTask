using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask.Models.Dtos
{
    public class TipDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public string VideoPath { get; set; }
        public string VideoExtension { get; set; }
    }
}
