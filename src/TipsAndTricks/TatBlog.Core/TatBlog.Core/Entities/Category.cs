using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities;

public class Category : IEntity

{
    //mã chuyên mục
    public int Id { get; set; }
    //tên chuyên mục
    public string Name { get; set; }
    //định danh dùng để tạo url
    public string UrlSlug { get; set; }
    //mô tả về chuyên mục
    public int Description { get; set; }
    //đánh dấu chuyên mục được hiển thị trên menu 
    public bool ShowOnMenu { get; set; }
    //danh sách các bài viết thuộc chuyên mục
    //public IList<Post> Posts { get; set; }
    int IEntity.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    IList<Post> IEntity.Posts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
