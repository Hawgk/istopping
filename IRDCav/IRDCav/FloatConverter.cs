﻿using Avalonia.Data.Converters;
using Avalonia.Data;
using System;
using System.Globalization;

namespace IRDCav
{
    public class FloatConverter : IValueConverter
    {
        public static readonly FloatConverter Instance = new();

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            string returnString = string.Empty;

            if (value is float sourceValue && parameter is string targetCase && targetType.IsAssignableTo(typeof(string)))
            {
                switch (targetCase)
                {
                    case "Fuel":
                        returnString = Math.Round(sourceValue, 2).ToString("0.00") + " L    ";
                        return returnString.PadLeft(11);
                    case "FuelPerLap":
                        returnString = Math.Round(sourceValue, 2).ToString("0.00") + " L/Lap";
                        return returnString.PadLeft(11);
                    case "FuelPerMinute":
                        returnString = Math.Round(sourceValue, 2).ToString("0.00") + " L/Min";
                        return returnString.PadLeft(11);
                }
            }
            // converter used for the wrong type
            return new BindingNotification(new InvalidCastException(), BindingErrorType.Error);
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
