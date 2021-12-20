using AutoMapper;
using FirstTask.IRepo;
using FirstTask.Models;
using FirstTask.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask.Repos
{
    public class TipsRepo : ITipsRepo
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public TipsRepo(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<TipDto> GetAllTips()
        {
            var tipsDto = _context.Tips.Select(t=>_mapper.Map<TipDto>(t)).ToList();
            return tipsDto;
        }
    }
}
