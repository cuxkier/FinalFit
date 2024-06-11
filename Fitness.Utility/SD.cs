using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Utility
{
    public static class SD
    {
        public const string Role_Customer = "Użytkownik";
        public const string Role_Company = "Firma";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Pracownik";

        public const string StatusPending = "Oczekujące";
        public const string StatusApproved = "Zaakceptowane";
        public const string StatusInProcess = "Procesowane";
        public const string StatusShipped = "Wysłane";
        public const string StatusRefunded = "Zwrócone";
        public const string StatusCancelled = "Anulowane";

        public const string PaymentStatusPending = "Oczekujące";
        public const string PaymentStatusApproved = "Zaakceptowane";
        public const string PaymentStatusDelayedPayment = "ApprovedForDelayedPayement";
        public const string PaymentStatusRejected = "Odrzucone";

        public const string SessionCart = "SessionShoppingCart";

    }
}
