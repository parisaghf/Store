namespace Main.BlazorApp.Models
{
    public class BaseInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string HeaderImageUrl { get; set; } = "images/hero.jpg";
        public List<Category> Categories { get; set; }
        public About AboutUs { get; set; }


    }

    public class Category
    {
        public string Code { get; set; }
        public string Title { get; set; }
    }

    public class About
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
