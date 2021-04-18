using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myplugin.Widget.SwiperSlider.Model;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;

namespace myplugin.Widget.SwiperSlider.Controllers
{
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    public class SliderController : BasePluginController
    {
        private readonly SliderSettings _sliderSettings;
        private readonly ISettingService _settingService;
        private readonly INotificationService _notificationService;
        private readonly ILocalizationService _localizationService;
        public SliderController(

            SliderSettings sliderSettings, 
            ISettingService settingService, 
            INotificationService notificationService,
            ILocalizationService localizationService 
            )
        {
            _sliderSettings = sliderSettings;
            _settingService = settingService;
            _notificationService = notificationService;
            _localizationService = localizationService;
        }

        public IActionResult Configure()
        {
            var data = new SliderConfigureModel
            {
                ContainerCssSelector = _sliderSettings.ContainerCssSelector,
                PaginationCssSelector = _sliderSettings.PaginationCssSelector,
                NavigationNextCssSelector = _sliderSettings.NavigationNextCssSelector,
                NavigationPrevCssSelector = _sliderSettings.NavigationPrevCssSelector,
                ScrollBarCssSelector = _sliderSettings.ScrollBarCssSelector,
                Direction = _sliderSettings.Direction,
                DirectionId=Convert.ToInt32(_sliderSettings.Direction),
                InitialSlide = _sliderSettings.InitialSlide,
                Speed = _sliderSettings.Speed,
                Loop = _sliderSettings.Loop,
                PaginationEnabled = _sliderSettings.PaginationEnabled,
                NavigationEnabled = _sliderSettings.NavigationEnabled,
                ScrollBarEnabled = _sliderSettings.ScrollBarEnabled

            };


            return View("~/Plugins/myplugin.swiperslider/Views/Configure.cshtml", data);
        }

        [HttpPost]
        public async Task<IActionResult> Configure(SliderConfigureModel model)
        {
            _sliderSettings.ContainerCssSelector = model.ContainerCssSelector;
            _sliderSettings.PaginationCssSelector = model.PaginationCssSelector;
            _sliderSettings.NavigationNextCssSelector = model.NavigationNextCssSelector;
            _sliderSettings.NavigationPrevCssSelector = model.NavigationPrevCssSelector;
            _sliderSettings.ScrollBarCssSelector = model.ScrollBarCssSelector;
            _sliderSettings.Direction=(Direction)Enum.Parse(typeof(Direction), model.DirectionId.ToString());
            _sliderSettings.InitialSlide = model.InitialSlide;
            _sliderSettings.Speed = model.Speed;
            _sliderSettings.Loop = model.Loop;
            _sliderSettings.PaginationEnabled = model.PaginationEnabled;
            _sliderSettings.NavigationEnabled = model.NavigationEnabled;
            _sliderSettings.ScrollBarEnabled = model.ScrollBarEnabled;

           
            await _settingService.SaveSettingAsync(_sliderSettings);
            await _settingService.ClearCacheAsync();
            _notificationService.SuccessNotification(await _localizationService.GetResourceAsync("Admin.Plugins.Saved"));

            return Configure();
        }
    }
}
