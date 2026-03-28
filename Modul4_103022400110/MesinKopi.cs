using System;
using System.Collections.Generic;
using System.Text;

public class MesinKopi
{
    // Enum untuk mendefinisikan state mesin kopi
    public enum State
    {
        OFF,
        STANDBY,
        BREWING,
        MAINTENANCE
    }

    // Variabel untuk menyimpan state saat ini
    private State currentState;

    // Konstruktor untuk inisialisasi state awal
    public MesinKopi()
    {
        currentState = State.OFF;
        Console.WriteLine("State awal mesin: OFF");
    }

    // Method untuk mengubah state mesin kopi
    public void PowerOn()
    {
        if (currentState == State.OFF)
        {
            currentState = State.STANDBY;
            Console.WriteLine("Mesin Off berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void StartBrew()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.BREWING;
            Console.WriteLine("Mesin Standby berubah menjadi Brewing");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void FinishBrew()
    {
        if (currentState == State.BREWING)
        {
            currentState = State.STANDBY;
            Console.WriteLine("Mesin Brewing berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void StartMaintenance()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.MAINTENANCE;
            Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void FinishMaintenance()
    {
        if (currentState == State.MAINTENANCE)
        {
            currentState = State.STANDBY;
            Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void PowerOff()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.OFF;
            Console.WriteLine("Mesin Standby berubah menjadi Off");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    // Method untuk menampilkan state saat ini
    public void TampilkanState()
    {
        Console.WriteLine("State saat ini: " + currentState);
    }

}