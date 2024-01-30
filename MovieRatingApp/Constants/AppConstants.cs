namespace MovieRatingApp.Constants
{
    public static class AppConstants
    {
        public static string BaseApiUrl = DeviceInfo.Platform == DevicePlatform.Android ? @"http://10.0.2.2:5119/api" : @"http://localhost:5119/api";
        public const string Movie = "/movie";

    }
}
