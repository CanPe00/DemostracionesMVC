using System.ComponentModel.DataAnnotations;

namespace OperaWebSite.Validations
{
    public class CheckValidYearAttribute:ValidationAttribute
    {
        public CheckValidYearAttribute()
        {
            ErrorMessage = "El año debe ser mayor o igual a 1958";
        }

        public override bool IsValid(object value)
        {
            int year = (int)value;
            
            return (year < 1598) ? false : true;
        }
    }
}
