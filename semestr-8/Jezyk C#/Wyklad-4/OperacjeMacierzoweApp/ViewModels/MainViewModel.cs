using System;
using System.Windows;
using System.Windows.Input;
using OperacjeMacierzoweApp.Models;

namespace OperacjeMacierzoweApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
    }

    public MainViewModel(MainModel model)
    {
        Model = model;
    }

    public MainModel Model { get; set; }
    public ICommand TestCommand => new RelayCommand(o => Test());

    public ICommand AddCommand => new RelayCommand(o => Add());

    public ICommand SubCommand => new RelayCommand(o => Sub());

    public ICommand MulCommand => new RelayCommand(o => Mul());

    public ICommand DetCommand => new RelayCommand(o => Det());

    public ICommand InvCommand => new RelayCommand(o => Inv());

    public ICommand SolveCommand => new RelayCommand(o => Solve());

    public string Matrix1
    {
        get => Model.Matrix1;
        set
        {
            Model.Matrix1 = value;
            OnPropertyChanged();
        }
    }

    public string Matrix2
    {
        get => Model.Matrix2;
        set
        {
            Model.Matrix2 = value;
            OnPropertyChanged();
        }
    }

    public string Result
    {
        get => Model.Result;
        set
        {
            Model.Result = value;
            OnPropertyChanged();
        }
    }

    public ICommand Det1Command => new RelayCommand(o => Det1());

    private void Det1()
    {
        try
        {
            Result = Model.Det1();
        }
        catch (Exception ex)
        {
                       ShowError(ex.Message);
        }
    }

    public ICommand Det2Command => new RelayCommand(o => Det2());

    private void Det2()
    {
        try
        {
            Result = Model.Det2();
        }
        catch (Exception e)
        {
            ShowError(e.Message); 
        }
    }

    private void Test()
    {
        try
        {
            Result = Model.Test();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void ShowError(string message)
    {
        MessageBox.Show(message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
    }

    private void Add()
    {
        try
        {
            Result = Model.Add();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void Sub()
    {
        try
        {
            Result = Model.Sub();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void Mul()
    {
        try
        {
            Result = Model.Mul();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void Det()
    {
        try
        {
            Result = Model.Det();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void Inv()
    {
        try
        {
            Result = Model.Inv();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void Solve()
    {
        try
        {
            Result = Model.Solve();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }
}