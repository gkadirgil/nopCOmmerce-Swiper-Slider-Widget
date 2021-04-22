﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Configuration;

namespace myplugin.Widget.SwiperSlider
{
    public class SliderSettings:ISettings
    {
        public string ContainerCssSelector { get; set; }
        public string PaginationCssSelector { get; set; }
        public string NavigationNextCssSelector { get; set; }
        public string NavigationPrevCssSelector { get; set; }
        public string ScrollBarCssSelector{ get; set; }
        public Direction Direction { get; set; }
        public int InitialSlide { get; set; }
        public int Speed { get; set; }
        public bool Loop { get; set; }
        public bool PaginationEnabled { get; set; }
        public bool NavigationEnabled { get; set; }
        public bool ScrollBarEnabled { get; set; }
        public bool LoopFillGroupWithBlankEnabled { get; set; }
        public bool AutoPlayEnabled { get; set; }
        public int AutoPlayDelay { get; set; }
        public bool AutoPlayDisableOnInteraction { get; set; }
        public int SlidesPerGroup { get; set; }
        public int SpaceBetween { get; set; }
        public string SlidesPerView { get; set; }
        public int SlidesPerColumn { get; set; }
        public bool FreeModeEnabled { get; set; }
        public bool PaginationClickableEnabled { get; set; }
        public bool DynamicBulletsEnabled { get; set; }
        public bool CenteredSlidesEnabled { get; set; }

        public string CustomCSS { get; set; }

    }
}
