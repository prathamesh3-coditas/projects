using System.ComponentModel.DataAnnotations;

namespace API_Apps.CustomValidator
{
    public class CatagoryValidator : ValidationAttribute
    {

        public override bool IsValid(object? value)
        {
            if (Convert.ToInt32(value) > 0)
                return true;

            return false;
        }
    }
}
