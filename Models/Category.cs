using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    public Category()
    {
        
    }
    public Category(int id, string title)
    {
        Id = id;
        Title = title;
    }

    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o título")]
    [MinLength(3, ErrorMessage = "A categoria deve ter pelo menos 3 Caracteres")]
    [MaxLength(60, ErrorMessage = "A categoria deve ter no máximo 60 Caracteres")]
    public string Title { get; set; } = string.Empty;
}