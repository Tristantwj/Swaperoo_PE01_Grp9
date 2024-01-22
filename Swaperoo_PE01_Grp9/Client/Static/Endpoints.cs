using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string ChatsEndpoint = $"{Prefix}/chats";
        public static readonly string MessagessEndpoint = $"{Prefix}/messages";
        public static readonly string CategorysEndpoint = $"{Prefix}/categorys";
        public static readonly string PurchasesEndpoint = $"{Prefix}/purchases";
        public static readonly string RatingsEndpoint = $"{Prefix}/ratings";
        public static readonly string ReportsEndpoint = $"{Prefix}/reports";
        public static readonly string SubCategorysEndpoint = $"{Prefix}/subcategorys";
        public static readonly string SwapsEndpoint = $"{Prefix}/swaps";
        public static readonly string UsersEndpoint = $"{Prefix}/users";
    }
}
