using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace myplugin.Widget.SwiperSlider.Model
{
    public record SliderConfigureModel : BaseNopModel
    {
        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.ContainerCssSelector")]
        public string ContainerCssSelector { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.PaginationCssSelector")]
        public string PaginationCssSelector { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.NavigationNextCssSelector")]
        public string NavigationNextCssSelector { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.NavigationPrevCssSelector")]
        public string NavigationPrevCssSelector { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.ScrollBarCssSelector")]
        public string ScrollBarCssSelector { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.Direction")]
        public Direction Direction { get; set; }
        
        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.Direction")]
        public int DirectionId { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.InitialSlide")]
        public int InitialSlide { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.Speed")]
        public int Speed { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.Loop")]
        public bool Loop { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.PaginationEnabled")]
        public bool PaginationEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.NavigationEnabled")]
        public bool NavigationEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.ScrollBarEnabled")]
        public bool ScrollBarEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.LoopFillGroupWithBlankEnabled")]
        public bool LoopFillGroupWithBlankEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.AutoPlayDelay")]
        public int AutoPlayDelay { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.AutoPlayDisableOnInteraction")]
        public bool AutoPlayDisableOnInteraction { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.SlidesPerGroup")]
        public int SlidesPerGroup { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.SpaceBetween")]
        public int SpaceBetween { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.SlidesPerView")]
        public string SlidesPerView { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.SlidesPerColumn")]
        public int SlidesPerColumn { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.FreeModeEnabled")]
        public bool FreeModeEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.PaginationClickableEnabled")]
        public bool PaginationClickableEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.DynamicBulletsEnabled")]
        public bool DynamicBulletsEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.CenteredSlidesEnabled")]
        public bool CenteredSlidesEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.AutoPlayDelayEnabled")]
        public bool AutoPlayEnabled { get; set; }

        [NopResourceDisplayName("myplugin.Widget.SwiperSlider.Model.CustomCSS")]
        public string CustomCSS { get; set; }
    }
}
