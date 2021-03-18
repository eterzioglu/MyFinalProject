using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductInvalidName = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride 10 dan fazla ürün olamaz.";
        public static string ProductNameError = "Eklediğiniz isimde ürün mevcut farklı bir isim kullanınız.";
        public static string CategoryLimitExceded = "Eklenebilecek maximum kategori sayısına ulaştınız. Yeni ürün ekleyemezsiniz.";
    }
}
