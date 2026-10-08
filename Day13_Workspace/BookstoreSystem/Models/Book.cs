using System;

namespace BookstoreSystem.Models
{
    #region Mapping by Convention
    //// Part A — Mapping by Convention
    internal class Book
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        
        //// Explicitly Optional
        public DateTime? PublishedDate { get; set; }
        #endregion
    }
    #endregion
}
