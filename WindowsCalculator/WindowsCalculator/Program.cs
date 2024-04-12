using System.Collections.Generic;
using System.Security.Claims;
using System.Xml.Linq;

using System;

< Window xmlns = "https://github.com/avaloniaui"
        xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns: d = "http://schemas.microsoft.com/expression/blend/2008"
        xmlns: mc = "http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc: Ignorable = "d" d: DesignWidth = "800" d: DesignHeight = "450"
        x: Class = "InClassCalculator.MainWindow"
        Title = "OOPCalculator"
        Height = "500" Width = "500" >
    < StackPanel HorizontalAlignment = "Center" Margin = "20" >
    < TextBox x: Name = "TextBox1" Height = "100" Width = "400"
    TextWrapping = "Wrap"
    HorizontalContentAlignment = "Right"
    TextAlignment = "Right" />

    < Grid ColumnDefinitions = "100,100,100,100"
     RowDefinitions = "Auto,Auto,Auto,Auto,Auto"
     Margin = "40" >

     < !--First Row-- >
     < Button x: Name = "ButtonAC" Width = "50"
     Height = "50" Click = "ACClickHandler" Grid.Row = "0"
     Grid.Column = "0" > AC </ Button >
     < Button x: Name = "ButtonPLM" Width = "50"
     Height = "50" Click = "" Grid.Row = "0"
     Grid.Column = "1" > +/ -</ Button >
     < Button x: Name = "ButtonMod" Width = "50"
     Height = "50" Click = "" Grid.Row = "0"
     Grid.Column = "2" >%</ Button >
     < Button x: Name = "ButtonDiv" Width = "50"
     Height = "50" Click = "" Grid.Row = "0"
     Grid.Column = "3" >/</ Button >

     < !--Second Row-- >
     < Button x: Name = "Button1" Width = "50"
     Height = "50" Click = "Button1ClickHandler" Grid.Row = "1"
     Grid.Column = "0" > 1 </ Button >
     < Button x: Name = "Button2" Width = "50"
     Height = "50" Click = "" Grid.Row = "1"
     Grid.Column = "1" > 2 </ Button >
     < Button x: Name = "Button3" Width = "50"
     Height = "50" Click = "" Grid.Row = "1"
     Grid.Column = "2" > 3 </ Button >
     < Button x: Name = "ButtonPlus" Width = "50"
     Height = "50" Click = "" Grid.Row = "1"
     Grid.Column = "3" > +</ Button >

     < !--Last Row-- >
     < Button x: Name = "Button0" Width = "150"
     Height = "50" Click = "" Grid.Row = "3"
     Grid.Column = "0" Grid.RowSpan = "2" > 0 </ Button >



    </ Grid >


    </ StackPanel >
</ Window >