# HighlightableTextBlock - Highlighting add-on for WPF TextBlock

## Quick Start
### Modifying the XAML file

After installing HighlightableTextBlock:

* Open up the xaml file containing the TextBlock you wish to add highlighting. 
* Add this namespace reference to the XAML: 
  
  xmlns:controls="clr-namespace:HighlightableTextBlock;assembly=HighlightableTextBlock"
* Locate the TextBlock declaration in the XAML. 
* Add this attribute:

  controls:HighlightableTextBlock.HightlightText="{Binding SearchText}" 
  
* Ta-da! Now you have highlightable TextBlocks in your application!
* Customization:

  * Highlight color - controls:HighlightableTextBlock.HighlightBrush="Yellow" 
  * Highlight text color - controls:HighlightableTextBlock.HighlightTextBrush="Red"
  * Bold - controls:HighlightableTextBlock.Bold="True"
  * Italic - controls:HighlightableTextBlock.Italic="True"
  * Underline - controls:HighlightableTextBlock.Underline="True"

## Target Frameworks

The library is built for the following target frameworks:

- `netstandard2.0`
- `netstandard2.1`
- `net8.0-windows`
- `net9.0-windows`
