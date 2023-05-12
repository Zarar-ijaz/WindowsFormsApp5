using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
			// create a new instance of the form you want to open
			Form3 form3 = new Form3();

			// show the new form
			form3.Show();
			Visible = false;
		}

        private void pictureBox5_Click(object sender, EventArgs e)
        {
			// create a new instance of the form you want to open
			Form4 form4 = new Form4();

			// show the new form
			form4.Show();
			Visible = false;
		}

        private void pictureBox6_Click(object sender, EventArgs e)
        {
			// create a new instance of the form you want to open
			Form5 form5 = new Form5();

			// show the new form
			form5.Show();
			Visible = false;
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			// create a new instance of the form you want to open
			Form6 form6 = new Form6();

			// show the new form
			form6.Show();
			Visible = false;
		}
    }
}
public static class GlobalMembersConsoleApplication42
{ }
	 /*static int ()
	{
		// Create some devices
		Laptop laptop1 = new Laptop("192.168.0.10", "00:11:22:33:44:55");
		Computer computer1 = new Computer("192.168.0.11", "11:22:33:44:55:66");
		Mobile mobile1 = new Mobile("192.168.0.12", "22:33:44:55:66:77");
		Printer printer1 = new Printer("192.168.0.13", "33:44:55:66:77:88");

		// Add devices to network manager
		NetworkManager networkManager = new NetworkManager();
		networkManager.addDevice(laptop1);
		networkManager.addDevice(computer1);
		networkManager.addDevice(mobile1);
		networkManager.addDevice(printer1);

		// Display devices
		networkManager.displayDevices();

		// Turn on all devices
		networkManager.turnOnAllDevices();

		// Display devices again
		networkManager.displayDevices();

		// Turn off the first device (laptop1)
		networkManager.turnOffDevice(0);

		// Display devices again
		networkManager.displayDevices();

		return 0;
	}
}

// Abstract base class for devices
public abstract class Device
{
	public abstract void displayStatus(); // Pure virtual function for displaying device status
	public abstract void turnOn(); // Pure virtual function for turning on device
	public abstract void turnOff(); // Pure virtual function for turning off device

	// Getter functions for IP and MAC address
	//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
	//ORIGINAL LINE: string getIPAddress() const
	public string getIPAddress()
	{
		return ipAddress;
	}
	//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
	//ORIGINAL LINE: string getMACAddress() const
	public string getMACAddress()
	{
		return macAddress;
	}

	protected string ipAddress;
	protected string macAddress;
	protected bool isOn;
}

// Derived class for laptop
public class Laptop : Device
{
	public Laptop(string ipAddress, string macAddress)
	{
		this.ipAddress = ipAddress;
		this.macAddress = macAddress;
		isOn = false;
	}

	public override void displayStatus()
	{
		string status = isOn ? "ON" : "OFF";
		Console.Write("Laptop\t");
		Console.Write(status);
		Console.Write("\t");
		Console.Write(ipAddress);
		Console.Write("\t");
		Console.Write(macAddress);
		Console.Write("\n");
	}

	public override void turnOn()
	{
		isOn = true;
		Console.Write("Laptop is now ON.");
		Console.Write("\n");
	}

	public override void turnOff()
	{
		isOn = false;
		Console.Write("Laptop is now OFF.");
		Console.Write("\n");
	}
}

// Derived class for computer
public class Computer : Device
{
	public Computer(string ipAddress, string macAddress)
	{
		this.ipAddress = ipAddress;
		this.macAddress = macAddress;
		isOn = false;
	}

	public override void displayStatus()
	{
		string status = isOn ? "ON" : "OFF";
		Console.Write("Computer\t");
		Console.Write(status);
		Console.Write("\t");
		Console.Write(ipAddress);
		Console.Write("\t");
		Console.Write(macAddress);
		Console.Write("\n");
	}

	public override void turnOn()
	{
		isOn = true;
		Console.Write("Computer is now ON.");
		Console.Write("\n");
	}

	public override void turnOff()
	{
		isOn = false;
		Console.Write("Computer is now OFF.");
		Console.Write("\n");
	}
}

// Derived class for mobile
public class Mobile : Device
{
	public Mobile(string ipAddress, string macAddress)
	{
		this.ipAddress = ipAddress;
		this.macAddress = macAddress;
		isOn = false;
	}

	public override void displayStatus()
	{
		string status = isOn ? "ON" : "OFF";
		Console.Write("Mobile\t");
		Console.Write(status);
		Console.Write("\t");
		Console.Write(ipAddress);
		Console.Write("\t");
		Console.Write(macAddress);
		Console.Write("\n");
	}

	public override void turnOn()
	{
		isOn = true;
		Console.Write("Mobile is now ON.");
		Console.Write("\n");
	}

	public override void turnOff()
	{
		isOn = false;
		Console.Write("Mobile is now OFF.");
		Console.Write("\n");
	}
}

// Derived class for printer
public class Printer : Device
{
	public Printer(string ipAddress, string macAddress)
	{
		this.ipAddress = ipAddress;
		this.macAddress = macAddress;
		isOn = false;
	}

	public override void displayStatus()
	{
		string status = isOn ? "ON" : "OFF";
		Console.Write("Printer\t");
		Console.Write(status);
		Console.Write("\t");
		Console.Write(ipAddress);
		Console.Write("\t");
		Console.Write(macAddress);
		Console.Write("\n");
	}

	public override void turnOn()
	{
		isOn = true;
		Console.Write("Printer is now ON.");
		Console.Write("\n");
	}

	public override void turnOff()
	{
		isOn = false;
		Console.Write("Printer is now OFF.");
		Console.Write("\n");
	}
}


public class NetworkManager
{
	public void addDevice(Device device)
	{
		devices.Add(device);
	}


	public void displayDevices()
	{
		Console.Write("Type\tStatus\tIP Address\tMAC Address");
		Console.Write("\n");
		foreach (Device device in devices)
		{
			device.displayStatus();
		}
	}
	public void turnOnAllDevices()
	{
		foreach (Device device in devices)
		{
			device.turnOn();
		}
	}

	public void turnOffAllDevices()
	{
		foreach (Device device in devices)
		{
			device.turnOff();
		}
	}

	public void turnOnDevice(int deviceIndex)
	{
		if (deviceIndex >= 0 && deviceIndex < devices.Count)
		{
			devices[deviceIndex].turnOn();
		}
		else
		{
			Console.Write("Invalid device index.");
			Console.Write("\n");
		}
	}

	public void turnOffDevice(int deviceIndex)
	{
		if (deviceIndex >= 0 && deviceIndex < devices.Count)
		{
			devices[deviceIndex].turnOff();
		}
		else
		{
			Console.Write("Invalid device index.");
			Console.Write("\n");
		}
	}

	private List<Device> devices = new List<Device>();
}

	*/