using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities;

public class Tag : IEntity
{
  // Mã từ khóa
  public int Id { get; set; }

  // Nội dung từ khóa
  public string Name { get; set; }

  // Tên định danh để tạo URL
  public string UrlSlug { get; set; }

  // Mô tả thêm về từ khóa
  public string Description { get; set; }

  // Danh sách bài viết có chứa từ khóa
  public IList<Post> Posts { get; set; }
}