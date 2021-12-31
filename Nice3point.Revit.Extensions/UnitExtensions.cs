﻿using Autodesk.Revit.DB;

namespace Nice3point.Revit.Extensions;

/// <summary>
///     Revit Unit Extensions
/// </summary>
public static class UnitExtensions
{
    /// <summary>
    ///     Convert Millimeters to Feet
    /// </summary>
    [Pure]
    public static double FromMillimeters(this double millimeters)
    {
#if R19 || R20
        return UnitUtils.ConvertToInternalUnits(millimeters, DisplayUnitType.DUT_MILLIMETERS);
#else
        return UnitUtils.ConvertToInternalUnits(millimeters, UnitTypeId.Millimeters);
#endif
    }

    /// <summary>
    ///     Convert Feet to Millimeters
    /// </summary>
    [Pure]
    public static double ToMillimeters(this double feet)
    {
#if R19 || R20
        return UnitUtils.ConvertFromInternalUnits(feet, DisplayUnitType.DUT_MILLIMETERS);
#else
        return UnitUtils.ConvertFromInternalUnits(feet, UnitTypeId.Millimeters);
#endif
    }

    /// <summary>
    ///     Convert Inches to Feet
    /// </summary>
    [Pure]
    public static double FromInches(this double inches)
    {
#if R19 || R20
        return UnitUtils.ConvertToInternalUnits(inches, DisplayUnitType.DUT_DECIMAL_INCHES);
#else
        return UnitUtils.ConvertToInternalUnits(inches, UnitTypeId.Inches);
#endif
    }

    /// <summary>
    ///     Convert Feet to Inches
    /// </summary>
    /// <returns>Value in feet</returns>
    [Pure]
    public static double ToInches(this double feet)
    {
#if R19 || R20
        return UnitUtils.ConvertFromInternalUnits(feet, DisplayUnitType.DUT_DECIMAL_INCHES);
#else
        return UnitUtils.ConvertFromInternalUnits(feet, UnitTypeId.Inches);
#endif
    }
}