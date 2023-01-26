<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607015/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3785)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# DXRichEdit for WPF: How to implement a custom command and bind it to the standard bar item


<p>This example illustrates how to implement a custom command for the RichEditControl and bind this command to the standard bar item in XAML. A custom command class implements the <a href="http://msdn.microsoft.com/en-us/library/system.windows.input.icommand.aspx"><u>ICommand Interface</u></a>. It <strong>Execute</strong> method is implemented as follows:</p>

```cs
public void Execute(object parameter) {<newline/>
   if (commandName != "CustomCommand")<newline/>
       throw new System.ApplicationException("Unknown command"); <newline/>
   RichEditControl richEditControl = (RichEditControl)parameter;<newline/>
   DXMessageBox.Show("Number of words in the document: " + richEditControl.WordsCount.ToString());<newline/>
}
```

<p> </p><p>The command is bound to the bar item in XAML as follows:</p>

```xml
   <!--Custom BarButtonItemLink--><newline/>
   <dxb:BarButtonItemLink BarItemName="biShowWordsCount" /><newline/>
   ...<newline/>
   <!--Custom BarButtonItem--><newline/>
   <dxb:BarButtonItem Command="{x:Static local:CustomRichEditUICommand.CustomCommand}" CommandParameter="{Binding ElementName=richEditControl1}" Name="biShowWordsCount" LargeGlyph="pack://application:,,,/Images/words.png" Content="Words Count" Hint="Shows the number of words in the document." />
```

<p> </p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#WPF/CustomDocument8847"><u>Lesson 2 - Provide Bars UI for a RichEditControl</u></a><br />
<a href="https://www.devexpress.com/Support/Center/p/E3229">DXRichEdit for WPF: How to bind commands to regular buttons and implement custom commands</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E3722">How to replace standard DXRichEdit command with your own custom command</a></p>

<br/>


