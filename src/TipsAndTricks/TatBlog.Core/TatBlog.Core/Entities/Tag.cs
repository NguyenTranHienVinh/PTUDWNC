using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities;

internal class Tag : IEntity
{
    //mã từ khóa
    public int Id { get; set; }
    //nội dung từ khóa 
    string Name { get; set; }
    string UrlSlug { get; set; }
    //mô tả thêm về từ khóa 
    string Description { get; set; }
    // danh sách bài viết có chứa từ khóa 
    public IList<Post> Posts { get; set; }
}
