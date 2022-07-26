using System.Globalization;
using System.IO;
using System.Windows.Automation;
using System.Windows.Controls;

namespace WpfTestMultipleValidations;
public class NotEmptyValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        return string.IsNullOrWhiteSpace((value ?? "").ToString())
            ? new ValidationResult(false, "Field is required.")
            : ValidationResult.ValidResult;
    }
}

public class NumericEntryValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var s = value.ToString();
        if (int.TryParse(s, out int _))
            return ValidationResult.ValidResult;
        else
            return new ValidationResult(false, "Value is not numeric");
    }
}

public class NumberRangeValidationRule : ValidationRule
{
    public int Minimum { get; set; }
    public int Maximum { get; set; }

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        if (int.Parse(value.ToString()) >= Minimum && int.Parse(value.ToString()) <= Maximum)
            return ValidationResult.ValidResult;
        else
            return new ValidationResult(false, $"Value must be between {Minimum} and {Maximum}");
    }
}

public class FilePathValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var s = value.ToString();
        if (File.Exists(s))
            return ValidationResult.ValidResult;
        else
            return new ValidationResult(false, "File not found");
    }
}