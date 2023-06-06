﻿namespace MvuTemplate;

public class SimpleComponent : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .VerticalAlignment(VerticalAlignment.Center)
            .HorizontalAlignment(HorizontalAlignment.Center)
            .Children(
                new TextBlock()
                    .Ref(out _textBlock1)
                    .Text("Hello world"),
                new TextBlock()
                    .Text(() => $"Counter: {_counter + _counter}"),
                new Button()
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );

    private TextBlock _textBlock1 = null!;
    private int _counter = 0;

    [Inject] SampleDataService DataService { get; set; } = null!;

    private void OnButtonClick(RoutedEventArgs e)
    {
        _counter++;
        _textBlock1.Text = DataService.GetData();
        StateHasChanged();
    }
}