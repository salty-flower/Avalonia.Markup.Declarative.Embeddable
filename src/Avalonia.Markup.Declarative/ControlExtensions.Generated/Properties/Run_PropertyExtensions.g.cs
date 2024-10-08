#nullable enable
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Run = Avalonia.Controls.Documents.Run;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RunExtensions
{
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.Run
   => control._set(Avalonia.Controls.Documents.Run.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.Run
   => control._set(Avalonia.Controls.Documents.Run.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.Run
   => control._set(Avalonia.Controls.Documents.Run.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Run
=> control._setEx(Avalonia.Controls.Documents.Run.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Run
=> control._setEx(Avalonia.Controls.Documents.Run.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

