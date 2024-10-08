#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RadioButton = Avalonia.Controls.RadioButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RadioButtonExtensions
{
public static T GroupName<T>(this T control, IBinding binding) where T : Avalonia.Controls.RadioButton
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty, binding);
public static T GroupName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RadioButton
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T GroupName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RadioButton
   => control._set(Avalonia.Controls.RadioButton.GroupNameProperty, func, onChanged, expression);
public static T GroupName<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RadioButton
=> control._setEx(Avalonia.Controls.RadioButton.GroupNameProperty, ps, () => control.GroupName = value, bindingMode, converter, bindingSource);
public static T GroupName<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RadioButton
=> control._setEx(Avalonia.Controls.RadioButton.GroupNameProperty, ps, () => control.GroupName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

