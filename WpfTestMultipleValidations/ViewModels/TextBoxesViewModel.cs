namespace WpfTestMultipleValidations.ViewModels;

public class TextBoxesViewModel : ViewModelBase
{
    private string _textInput1;
    private string _textInput2;

    public string TextInput1
    {
        get => _textInput1;
        set => SetProperty(ref _textInput1, value);
    }


    public string TextInput2
    {
        get => _textInput2;
        set => SetProperty(ref _textInput2, value);
    }
}