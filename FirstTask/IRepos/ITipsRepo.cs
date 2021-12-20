using FirstTask.Models;
using FirstTask.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask.IRepo
{
    public interface ITipsRepo
    {
        ICollection<TipDto> GetAllTips();
    }
}
