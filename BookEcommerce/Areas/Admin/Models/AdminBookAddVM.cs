using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminBookAddVM
    {       
        public int Id { get; set; }
        [Required(ErrorMessage ="Kitap Adını giriniz !")]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori Adını giriniz !")]
        public string CategoryName { get; set; }
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Yazar Adını giriniz !")]
        public string AuthorName { get; set; }
        public int PublisherId { get; set; }
        [Required(ErrorMessage = "Yayıncı giriniz !")]
        public string PublisherName { get; set; }
        [Required(ErrorMessage = "Fiyat giriniz !")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Kitabın açıklamasını giriniz !")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Stok Adedini giriniz !")]
        public int StockCount { get; set; }
        [Required(ErrorMessage = "Sayfa sayısını giriniz !")]
        public int BookPages { get; set; }
    }
}
