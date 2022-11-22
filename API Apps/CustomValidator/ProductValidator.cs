using System.ComponentModel.DataAnnotations;

namespace API_Apps.CustomValidator
{
    public class ProductValidator : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string str = value.ToString();
            string checker = "-.";

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]) && checker.Contains(str[i]))
                {
                    count++;
                }
            }

            if (count == str.Length)
            {
                return true;
            }
            return false;
        }
    }
}
