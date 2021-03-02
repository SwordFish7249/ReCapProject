using Core.Entities.Concrete;
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
    }
}
