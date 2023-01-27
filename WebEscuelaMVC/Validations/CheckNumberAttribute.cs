using System;
using System.ComponentModel.DataAnnotations;

namespace WebEscuelaMVC.Validations
{
    public class CheckNumberAttribute:ValidationAttribute
    {
        public CheckNumberAttribute()
        {
            ErrorMessage="El número debe ser mayor a 100";
        }

        public override bool IsValid(object value)
        {
            int numero = Convert.ToInt32(value);
            return numero < 100 ? false : true;
        }
    }
}
