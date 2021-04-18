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
    }
}
