using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    [Required(ErrorMessage = "The recipe's name can't be empty!")]
    public string RecipeName { get; set;}
    [Range(1, int.MaxValue, ErrorMessage = "You must add a recipe to a category.  Have you created a category?")]
    public string Ingredients { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your recipe to a tag. Have you created a tag yet?")]
    public string Instructions { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your recipe to a tag. Have you created a tag yet?")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<RecipeTag> JoinEntities { get;}
    public ApplicationUser User { get; set; }  
  }
}