using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace myplugin.Widget.SwiperSlider
{
    public class SwiperSliderPlugin : BasePlugin, IWidgetPlugin
    {
        private readonly IWebHelper _webHelper;
        private readonly ISettingService _settingService;
        private readonly ILocalizationService _localizationService;


        #region IWidget Plugin

        public async Task<IList<string>> GetWidgetZonesAsync()
        {
            return new List<string> { PublicWidgetZones.HomepageTop, PublicWidgetZones.ProductDetailsTop };
        }
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "Slider";
        }


        public bool HideInWidgetList => false;



        #endregion

        #region Ctor
        public SwiperSliderPlugin(ISettingService settingService, IWebHelper webHelper, ILocalizationService localizationService)
        {
            _webHelper = webHelper;
            _settingService = settingService;
            _localizationService = localizationService;
        }
        #endregion

        #region BasePlugin Overrides
        public override Task InstallAsync()
        {
            var settings = new SliderSettings()
            {
                ContainerCssSelector = ".swiper-container",
                PaginationCssSelector = ".swiper-pagination",
                NavigationNextCssSelector = ".swiper-button-next",
                NavigationPrevCssSelector = ".swiper-button-prev",
                ScrollBarCssSelector = ".swiper-scrollbar",
                Direction = Direction.Horizontal,
                InitialSlide = 0,
                Speed = 300

            };

            _settingService.SaveSettingAsync(settings);


            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.ContainerCssSelector", "Container Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.PaginationCssSelector", "Pagination Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.NavigationNextCssSelector", "Navigation Next Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.NavigationPrevCssSelector", "Navigation Prev Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.ScrollBarCssSelector", "ScrollBar Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.Direction", "Direction");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.InitialSlide","Initial Slide");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.Speed", "Speed");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.Loop", "Loop");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.PaginationEnabled", "Pagination Enabled");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.NavigationEnabled", "Navigation Enabled");
            _localizationService.AddOrUpdateLocaleResourceAsync("myplugin.Widget.SwiperSlider.Model.ScrollBarEnabled", "ScrollBar Enabled");




            return base.InstallAsync();
        }

        public override Task UninstallAsync()
        {
            _settingService.DeleteSettingAsync<SliderSettings>();

            _localizationService.DeleteLocaleResourcesAsync("myplugin.Widget.SwiperSlider");

            return base.UninstallAsync();
        }

        public override Task PreparePluginToUninstallAsync()
        {
            return base.PreparePluginToUninstallAsync();
        }

        // Pluginde Yapılandır Sekmesini Çıkartır.
        public override string GetConfigurationPageUrl()
        {
            string deger = $"{_webHelper.GetStoreLocation()}Admin/Slider/Configure";
            //deger=https://localhost44000/Admin/Slider/Configure

            return $"{_webHelper.GetStoreLocation()}Admin/Slider/Configure";
        }




        //public override string GetConfigurationPageUrl()
        //{
        //    return base.GetConfigurationPageUrl();
        //}
        #endregion
    }
}