#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using PullGestureRecognizer = Avalonia.Input.PullGestureRecognizer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PullGestureRecognizerExtensions
{
public static T PullDirection<T>(this T control, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);
public static T PullDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.PullGestureRecognizer
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func, Action<Avalonia.Input.PullDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.PullGestureRecognizer
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, func, onChanged, expression);
public static T PullDirection<T>(this T control, Avalonia.Input.PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.PullGestureRecognizer
=> control._setEx(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static T PullDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.PullGestureRecognizer
=> control._setEx(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

