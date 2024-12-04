using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models
{
    public class BlogMetadata
    {
        [StringLength(100)]
        [Display(Name ="Tên")]
        public string Name;
        [Display(Description= "Mô tả")]
        public string Description;
    }
    public class PostMetadata
    {
        [StringLength (500)]
        [Display(Title="Tiêu đề")]
        public string Title;

        [Display(Content="Nội dung")]
        public string Content;
        
        [Display(CreateDate = "Ngày tạo")]
        public string CreateDate;
    }

}