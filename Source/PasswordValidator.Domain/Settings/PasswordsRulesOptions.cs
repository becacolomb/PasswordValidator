using PasswordValidator.Domain.Models.PasswordsRules;

namespace PasswordValidator.Domain.Settings
{
    public class PasswordsRulesOptions
    {
        public AllowedPasswordRule Allowed { get; set; }
        public SpecialPasswordRule Special { get; set; }
        public LowercasePasswordRule Lowercase { get; set; }
        public UppercasePasswordRule Uppercase { get; set; }
        public NumericPasswordRule Numeric { get; set; }
        public LengthPasswordRule Length { get; set; }
        public NotRepeatedPasswordRule NotRepeated { get; set; }
    }
}
