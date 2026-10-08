using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreSystem.Models
{
    #region Data Annotations Configuration
    //// Part B — Data Annotations
    [Table("Writers")]
    internal class Author
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        //// Optional by default
        public string Country { get; set; }
        #endregion
    }
    #endregion
}
