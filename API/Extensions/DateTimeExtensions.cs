using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;

            // user did not have their birthday yet
            if (dob.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}