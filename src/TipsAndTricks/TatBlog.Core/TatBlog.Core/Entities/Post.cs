using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities
{
    internal class Post : IEntity
    {
        //mã bài viết 
        public int Id { get; set; }
        //nội dung từ khóa 
        string Title { get; set; }
        // mô tả hay giới thiệu ngắn về nội dung
        public string ShortDescription { get; set; }
        // nội dung chi tiết của bài viết 
        public string Description { get; set; }
        //Metadata
        public string Meta { get; set; }
        // tên định danh để tạo URL
        public string UrlSlug { get; set; }
        // đường dân đến hình tập tin hình ảnh 
        public string ImageUrl { get; set; }
        // số lượt xem và đọc bài viết 
        public int ViewCount { get; set; }
        //trạng thái bài viết 
        public bool Published { get; set; }
        // ngày giờ đăng bài 
        public DateTime PostedDate { get; set; }
        //ngày giờ cập nhật lần cuối 
        public DateTime? ModifiedDate { get; set; }
        //mã chuyên mục 
        public int CategoryId { get; set; }
        //mã tác giả 
        public int AuthorId { get; set; }
        //chuyên mục của bài viết 
        public Author Author { get; set; }
        // danh sách bài viết có chứa từ khóa 
        public IList<Tag> Tags { get; set; }
        public IList<Post> Posts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
