﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01_LampshadeQuery.Contracts.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}
