using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MandelbrotApp.Helpers;
using MandelbrotApp.Models;
using Color = System.Drawing.Color;

namespace MandelbrotApp.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly Color[,] colors;

    public double TotalWidth = 5;
    public double TotalHeight = 3;
    public double MinX = -1;
    public double MinY = -1;

    public MainViewModel(MainModel model)
    {
        Model = model;
        colors = new Color[Width, Height];

        for (var i = 0; i < Width; i++)
        {
            for (var j = 0; j < Height; j++)
            {
                var x = i * TotalWidth / Width + MinX;
                var y = j * TotalHeight / Height + MinY;

                var index = MandelbrotHelper.Calc(x, y);
                var color = MandelbrotHelper.Theme[index];
                colors[i, j] = color;
            }
        }


        Bitmap = new WriteableBitmap(Width, Height, 96, 96, PixelFormats.Bgra32, null);

        //var xx = MandelbrotHelper.ArrToBmp(colors);
         

        //UpdateBitmap(xx);
        UpdateBitmap(colors);
    }

    public void UpdateBitmap(System.Drawing.Bitmap bitmap)
    { 

        int width = bitmap.Width;
        int height = bitmap.Height;

        // Convert bitmap to byte array
        BitmapData data = bitmap.LockBits(
            new System.Drawing.Rectangle(0, 0, width, height),
            ImageLockMode.ReadOnly,
            System.Drawing.Imaging.PixelFormat.Format32bppArgb);

        byte[] pixelData = new byte[data.Stride * height];
        Marshal.Copy(data.Scan0, pixelData, 0, pixelData.Length);

        bitmap.UnlockBits(data);

        // Create WriteableBitmap
        WriteableBitmap writeableBitmap = new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgra32, null);

        // Write pixel data into WriteableBitmap
        writeableBitmap.WritePixels(new Int32Rect(0, 0, width, height), pixelData, data.Stride, 0);

    }

    public int Width { get; set; } = 800;
    public int Height { get; set; } = 600;

    private MainModel Model { get; }

    public double PositionX
    {
        get => Model.PositionX;
        set
        {
            Model.PositionX = value;
            OnPropertyChanged();
        }
    }

    public double PositionY
    {
        get => Model.PositionY;
        set
        {
            Model.PositionY = value;
            OnPropertyChanged();
        }
    }

    public WriteableBitmap Bitmap { get; set; }
    public ICommand LeftClickCommand => new RelayCommand(p => LeftClick(p));
    public ICommand RightClickCommand => new RelayCommand(p => RightClick(p));

    public event PropertyChangedEventHandler? PropertyChanged;

    private void UpdateBitmap(Color[,] colors)
    {
        // The bitmap that will eventually be assigned to the Image object
        var width = colors.GetLength(1); // the length of the second dimension
        var height = colors.GetLength(0); // the length of the first dimension

        // Copy the colors into the bitmap
        var colorData = new byte[width * height * 4]; // each pixel uses 4 bytes

        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                var index = (y * width + x) * 4;
                colorData[index] = colors[y, x].B; // Blue
                colorData[index + 1] = colors[y, x].G; // Green
                colorData[index + 2] = colors[y, x].R; // Red
                colorData[index + 3] = colors[y, x].A; // Alpha (transparency)
            }
        }

        // Write the color data into the bitmap
        var rect = new Int32Rect(0, 0, width, height);
        Bitmap.WritePixels(rect, colorData, width * 4, 0);
    }

    private void LeftClick(object parameter)
    {
        var imageElement = parameter as IInputElement;

        var mousePos = Mouse.GetPosition(imageElement);

        PositionX = mousePos.X;
        PositionY = mousePos.Y;
    }


    private void RightClick(object parameter)
    {
        var mouse = parameter as MouseEventArgs;
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}