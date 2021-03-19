using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car was adding.";
        public static string CarNameInvalid = "Car name is invalid.";
        public static string MaintenanceTime = "System is a Maintenance.";
        public static string CarsListed = "Cars are listing.";
        public static string PersonAdded = "Pesonr was adding.";
        public static string PersonNameInvalid = "Person name is invalid.";
        public static string PersonDeleted = "Person was deleting.";
        public static string PersonUpdated = "The person information was modified successfull.";
        public static string PersonsListed = "Persons are listing.";
        public static string RentalSuccess = "Your rental is successful.";
        public static string RentalError = "The system is not has a return date car. So you don't rent a car.";
        public static string CarImageSızePassing = "Every car just has a 5 images.Another mean you just adding 5 images per car not much.";
        public static string CarImageAdding = "The car image is adding.";
        public static string CarImageDeleted = "The car image deleted.";
        public static string CarImagesListed = "Car images are listing.";
        public static string CarImageUpdated = "Car image is updated.";
        public static string AuthorizationDenied = "You were try to use different authorization!!!!";
        public static string UserRegistered = "User was successfully registered.";
        public static string UserNotFound = "The user was not found";
        public static string PasswordError = "The password is wrong.";
        public static string SuccessfulLogin = "You are login sucessfully.";
        public static string UserAlreadyExists = "User was already exists.";
        public static string AccessTokenCreated = "Your token was created successfull.";
        public static string BrandAdded = "Brand was adding.";
        public static string BrandIsDeleted = "Brand was deleting.";
        public static string BrandsListed = "Brands are listing.";
        public static string BrandUpdated = "Brand was update.";
        public static string ColorAdded = "Color was adding.";
        public static string ColorDeleted = "Color was deleting.";
        public static string ColorsListed = "Colors are listing.";
        public static string ColorUpdated = "Color was update.";
        public static string RentalsListed = "Rentals are listing.";

        //yeni eklenenler

        //CarImage

        public static string AddCarImageMessage = "Araç resmi başarıyla eklendi";
        public static string EditCarImageMessage = "Araç resmi başarıyla güncellendi";
        public static string DeleteCarImageMessage = "Araç resmi başarıyla silindi";
        public static string AboveImageAddingLimit = "Araç maksimum resim sayısına ulaştı. Resim ekleyemezsiniz";
        public static string IncorrectFileExtension = "Kabul edilmeyen dosya uzantısı";
        public static string ImageNotFound = "Resim dosyası bulunamadı.";
        public static string CarImageNotFound = "Değiştirilmek istenen resim bulunamadı.";


        internal static string CarDeleted;
        internal static string CarUpdated;
        internal static CarDetailAndImagesDto GetErrorCarMessage;
        internal static string GetSuccessCarMessage;
    }
}
