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
    public int id { get; set; }
    //tên chuyên mục
    public string name { get; set; }
    //định danh dùng để tạo url
    public string UrlSlug { get; set; }
    //mô tả về chuyên mục
    public int Description { get; set; }
    //đánh dấu chuyên mục được hiển thị trên menu 
    public bool ShowOnMenu { get; set; }
}
