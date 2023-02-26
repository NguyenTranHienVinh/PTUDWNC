using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities;

public class Author :IEntity

{
    // mã tác giả bài viết 
    public int Id { get; set; }
    //tên tác giả 
    public string FullName { get; set; }
    // tên định danh dùng để tạo URL
    public string UrlSlug { get; set; }
    //đường dẫn tới files hình ảnh 
    public string ImageUrl { get; set; }
    // ngày bắt đầu 
    public DateTime JoinedDate { get; set; }
    //địa chỉ email
    public string Email { get; set; }
    //Ghi chú 
    public string Notes { get; set; }
    int IEntity.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    IList<Post> IEntity.Posts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    // danh sách các bài viết của chuyên mục
    //public IList<Post> Posts { get; set; }

}
