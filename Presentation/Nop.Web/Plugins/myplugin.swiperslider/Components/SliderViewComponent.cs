using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;

namespace myplugin.Widget.SwiperSlider.Components
{
    [ViewComponent(Name = "Slider")]
    public class SliderViewComponent : NopViewComponent
    {
        private readonly SliderSettings _sliderSettings;
        //private readonly ISettingService _settingService;

        public SliderViewComponent(SliderSettings sliderSettings)
        {
            _sliderSettings = sliderSettings;
            //_settingService = settingService;
        }
        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            //var loadedSetting = _settingService.LoadSettingAsync<SliderSettings>();
            return View("~/Plugins/myplugin.swiperslider/Views/PublicInfo.cshtml",_sliderSettings);
        }
    }
}
