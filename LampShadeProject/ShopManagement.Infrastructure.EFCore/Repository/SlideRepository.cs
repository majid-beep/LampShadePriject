using _0_FrameWork.Infrastructure;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SlideAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class SlideRepository : RepositoryBase<long, Slide>, ISlideRepository
    {
        private readonly ShopContext _context;
        public EditSlide GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<SlideViewModel> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
