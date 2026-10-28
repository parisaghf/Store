using Main.BlazorApp.Models;

namespace Main.BlazorApp.Services
{
    public class ProductService
    {
        private readonly List<Product> _products =
        [
            new Product
        {
            Id = 1,
            Name = "کرم مراقبت روزانه",
            Category = "مراقبت پوست",
            ShortDescription = "مناسب برای روتین مراقبت روزانه",
            Description = "این محصول برای معرفی در کاتالوگ طراحی شده است. توضیحات کامل، مشخصات و روش استفاده را می‌توان در این بخش قرار داد.",
            ImageUrl = "images/product-1.jpg",
            Features = "مناسب استفاده روزانه؛ بسته‌بندی کاربردی"
        },
        new Product
        {
            Id = 2,
            Name = "شامپو تقویت‌کننده",
            Category = "مراقبت مو",
            ShortDescription = "محصولی برای روتین مراقبت از مو",
            Description = "در این بخش می‌توان اطلاعات کامل شامپو، ویژگی‌ها و مشخصات آن را نمایش داد.",
            ImageUrl = "images/product-2.jpg",
            Features = "مناسب روتین مراقبت از مو"
        },
        new Product
        {
            Id = 3,
            Name = "محصول مراقبت شخصی",
            Category = "بهداشت فردی",
            ShortDescription = "ترکیبی از کیفیت و سادگی",
            Description = "توضیحات کامل محصول شماره سه در این قسمت قرار می‌گیرد.",
            ImageUrl = "images/product-3.jpg",
            Features = "استفاده آسان؛ طراحی کاربردی"
        },
        new Product
        {
            Id = 4,
            Name = "سرم مراقبت پوست",
            Category = "مراقبت پوست",
            ShortDescription = "بخشی از روتین مراقبت روزانه",
            Description = "در این صفحه می‌توان جزئیات محصول، ویژگی‌ها و اطلاعات تکمیلی آن را نمایش داد.",
            ImageUrl = "images/product-4.jpg",
            Features = "مناسب روتین مراقبت پوست"
        }
        ];

        public IReadOnlyList<Product> GetAll()
            => _products;

        public Product? GetById(int id)
            => _products.FirstOrDefault(p => p.Id == id);
    }
}
