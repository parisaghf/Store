using Main.BlazorApp.Models;

namespace Main.BlazorApp.Services
{
    public class BaseInfoService
    {
        private readonly BaseInfo _baseInfo = new()
        {
            Title = "انتخابی متفاوت، برای سلیقه‌ای خاص",
            Description = @"مجموعه‌ای از محصولات باکیفیت،
                           برای تجربه‌ای ساده‌تر و بهتر.",
            HeaderImageUrl = "images/hero.jpg",

            Categories =
           [
               new Category
            {
                Code = "SKIN",
                Title = "مراقبت پوست"
            },
            new Category
            {
                Code = "HAIR",
                Title = "مراقبت مو"
            },
            new Category
            {
                Code = "PERSONAL",
                Title = "بهداشت فردی"
            }
           ]
        };

        public BaseInfo Get()
        {
            return _baseInfo;
        }
    }
}
