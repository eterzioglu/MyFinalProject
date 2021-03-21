using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductInvalidName = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride 50 dan fazla ürün olamaz.";
        public static string ProductNameError = "Eklediğiniz isimde ürün mevcut farklı bir isim kullanınız.";
        public static string CategoryLimitExceded = "Eklenebilecek maximum kategori sayısına ulaştınız. Yeni ürün ekleyemezsiniz.";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kullanıcı kayıt edildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Access Token başarı ile oluşturuldu.";
    }
}
