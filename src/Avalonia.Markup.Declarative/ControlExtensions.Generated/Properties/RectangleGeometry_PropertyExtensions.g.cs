#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using RectangleGeometry = Avalonia.Media.RectangleGeometry;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RectangleGeometryExtensions
{
public static T RadiusX<T>(this T control, IBinding binding) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty, binding);
public static T RadiusX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusX<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RadiusXProperty, func, onChanged, expression);
public static T RadiusX<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.RectangleGeometry
=> control._setEx(Avalonia.Media.RectangleGeometry.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static T RadiusX<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.RectangleGeometry
=> control._setEx(Avalonia.Media.RectangleGeometry.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RadiusY<T>(this T control, IBinding binding) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty, binding);
public static T RadiusY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RadiusY<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RadiusYProperty, func, onChanged, expression);
public static T RadiusY<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.RectangleGeometry
=> control._setEx(Avalonia.Media.RectangleGeometry.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static T RadiusY<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.RectangleGeometry
=> control._setEx(Avalonia.Media.RectangleGeometry.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Rect<T>(this T control, IBinding binding) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty, binding);
public static T Rect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Rect<T>(this T control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.RectangleGeometry
   => control._set(Avalonia.Media.RectangleGeometry.RectProperty, func, onChanged, expression);
public static T Rect<T>(this T control, Avalonia.Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.RectangleGeometry
=> control._setEx(Avalonia.Media.RectangleGeometry.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static T Rect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.RectangleGeometry
=> control._setEx(Avalonia.Media.RectangleGeometry.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Rect<T>(this T control, Double x = default, Double y = default, Double width = default, Double height = default) where T : Avalonia.Media.RectangleGeometry
   => control._set(() => control.Rect = new Avalonia.Rect(x, y, width, height));
public static T Rect<T>(this T control, Size size = default) where T : Avalonia.Media.RectangleGeometry
   => control._set(() => control.Rect = new Avalonia.Rect(size));
public static T Rect<T>(this T control, Point position = default, Size size = default) where T : Avalonia.Media.RectangleGeometry
   => control._set(() => control.Rect = new Avalonia.Rect(position, size));
public static T Rect<T>(this T control, Point topLeft = default, Point bottomRight = default) where T : Avalonia.Media.RectangleGeometry
   => control._set(() => control.Rect = new Avalonia.Rect(topLeft, bottomRight));
}

