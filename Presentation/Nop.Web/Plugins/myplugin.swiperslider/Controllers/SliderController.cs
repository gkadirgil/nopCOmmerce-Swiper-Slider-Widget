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
                DirectionId = Convert.ToInt32(_sliderSettings.Direction),
                InitialSlide = _sliderSettings.InitialSlide,
                Speed = _sliderSettings.Speed,
                Loop = _sliderSettings.Loop,
                LoopFillGroupWithBlankEnabled = _sliderSettings.LoopFillGroupWithBlankEnabled,
                PaginationEnabled = _sliderSettings.PaginationEnabled,
                PaginationClickableEnabled = _sliderSettings.PaginationClickableEnabled,
                NavigationEnabled = _sliderSettings.NavigationEnabled,
                ScrollBarEnabled = _sliderSettings.ScrollBarEnabled,
                AutoPlayEnabled = _sliderSettings.AutoPlayEnabled,
                AutoPlayDelay = _sliderSettings.AutoPlayDelay,
                AutoPlayDisableOnInteraction = _sliderSettings.AutoPlayDisableOnInteraction,
                SlidesPerGroup = _sliderSettings.SlidesPerGroup,
                SpaceBetween = _sliderSettings.SpaceBetween,
                SlidesPerView = _sliderSettings.SlidesPerView,
                SlidesPerColumn = _sliderSettings.SlidesPerColumn,
                FreeModeEnabled = _sliderSettings.FreeModeEnabled,
                DynamicBulletsEnabled = _sliderSettings.DynamicBulletsEnabled,
                CenteredSlidesEnabled = _sliderSettings.CenteredSlidesEnabled,
                CustomCSS=_sliderSettings.CustomCSS
                
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
            _sliderSettings.Direction = (Direction)Enum.Parse(typeof(Direction), model.DirectionId.ToString());
            _sliderSettings.InitialSlide = model.InitialSlide;
            _sliderSettings.Speed = model.Speed;
            _sliderSettings.Loop = model.Loop;
            _sliderSettings.PaginationEnabled = model.PaginationEnabled;
            _sliderSettings.NavigationEnabled = model.NavigationEnabled;
            _sliderSettings.ScrollBarEnabled = model.ScrollBarEnabled;
            _sliderSettings.LoopFillGroupWithBlankEnabled = model.LoopFillGroupWithBlankEnabled;
            _sliderSettings.PaginationClickableEnabled = model.PaginationClickableEnabled;
            _sliderSettings.AutoPlayEnabled = model.AutoPlayEnabled;
            _sliderSettings.AutoPlayDelay = model.AutoPlayDelay;
            _sliderSettings.AutoPlayDisableOnInteraction = model.AutoPlayDisableOnInteraction;
            _sliderSettings.SlidesPerGroup = model.SlidesPerGroup;
            _sliderSettings.SpaceBetween = model.SpaceBetween;
            _sliderSettings.SlidesPerView = model.SlidesPerView;
            _sliderSettings.SlidesPerColumn = model.SlidesPerColumn;
            _sliderSettings.FreeModeEnabled = model.FreeModeEnabled;
            _sliderSettings.DynamicBulletsEnabled = model.DynamicBulletsEnabled;
            _sliderSettings.CenteredSlidesEnabled = model.CenteredSlidesEnabled;
            _sliderSettings.CustomCSS = model.CustomCSS;
            ;

            await _settingService.SaveSettingAsync(_sliderSettings);
            await _settingService.ClearCacheAsync();
            _notificationService.SuccessNotification(await _localizationService.GetResourceAsync("Admin.Plugins.Saved"));



            return Configure();
        }

        public IActionResult SliderList()
        {
            return View("~/Plugins/myplugin.swiperslider/Views/SliderList.cshtml");
        }
    }
}
