using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.DirectInput;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {

        Device joystickDevice; //create the device joystick for use later on

        byte[] buttons = null; //create a byte array and set it to null for use later on

        public Form1()

        {
            InitializeComponent(); //intializes the form

        }

        private void From1_Load(object sender, EventArgs e)

        {
            //does nothing during the form load

        }

        private void button1_Click(object sender, EventArgs e)

        {

            //THIS BUTTON MUST BE CLICKED FIRST
            
            serialPort1.Open(); //opens the serial port, this can be removed as well as the line below I commented to be removed if you don't want serial communication

            initiate(); //calls the intiate sub routine which opens the joystick for use in the program
            
            
        }

        private void button2_Click(object sender, EventArgs e)

        {
            //THIS BUTTON MUST BE CLICKED SECOND

            Thread thread1 = new Thread(new ThreadStart(DisplayThread1)); //make a new thread from DisplayThread1 below
            //This is not a good idea because in the program there ARE illegal cross calls which can cause problems down the road I chose to set this to false which
            //simply ignores the errors to avoid having to invoke things which can get very complicated.
            Control.CheckForIllegalCrossThreadCalls = false;
            //starts the thread
            thread1.Start();


        }

    private void initiate()

        {

             DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly); //get a list of attached game controllers

             if (gameControllerList.Count > 0) //if there is a game controller then enter
             {
                 // Move to the first device

                 gameControllerList.MoveNext();
                 DeviceInstance deviceInstance = (DeviceInstance) //picks the first controller
                     gameControllerList.Current;

                 // create a device from this controller.

                 joystickDevice = new Device(deviceInstance.InstanceGuid);
                 joystickDevice.SetCooperativeLevel(this,CooperativeLevelFlags.Background |CooperativeLevelFlags.NonExclusive);

                 joystickDevice.SetDataFormat(DeviceDataFormat.Joystick);

                 // Finally, acquire the device.

                 joystickDevice.Acquire();


             }


       }

        //below is the sub routine that actually does stuff

    private void poll()

    {

        System.Threading.Thread.Sleep(10); //delay for 10ms

        joystickDevice.Poll(); //poll the joystick

        buttons = new byte[11]; //create a byte array of 0 to 11 (12 buttons) you have to change this to how many buttons your joystick has look at the website in the top comments
        //under What is the joystick capable of? run that code to find out

        buttons = joystickDevice.CurrentJoystickState.GetButtons();

        int X = joystickDevice.CurrentJoystickState.X;
        int Y = joystickDevice.CurrentJoystickState.Y;
        int Z = joystickDevice.CurrentJoystickState.Z;

        int output = (Y - 0) * (180 - 0) / (65535 - 0) + 0; //scale the joystick values from 0 to 65535 to 0 to 180 for the servo.

        String send = Convert.ToString(output);

        int numLen = send.Length; 
             
        send = numLen + send; //combine the 2 strings

        serialPort1.Write(send); //*****remove this line as well if you don't want serial communication

        buttonCheck(); //calls button check to update the check boxes on the form

        //updates all of the progress bars on the screen

        if (X >= 33767)
        {
            prgX2.Value = X;
        }
        else
        {

            if (X <= 31767)
            {
                X = 31767 - X;

                prgX1.Value = X;
            }
        }

        if (Y >= 33767)
        {
            prgY2.Value = Y;
        }
        else
        {

            if (Y <= 31767)
            {
                Y = 31767 - Y;

                prgY1.Value = Y;
            }
        }

        //bar z is the easiest

        Z = 65535 - Z;

        prgZ.Value = Z;


    }

        //this checks the byte array to see if any of the buttons have been pushed 128 means the button is pushed 0 means it is not then sets the check boxes on the form

    private void buttonCheck()
    {

        //*******************************************

        if (buttons[0] >= 128)
        {

            chkTrigger.Checked = true;

        }
        else
        {

            chkTrigger.Checked = false;
        }

        //*******************************************

        if (buttons[1] >= 128)
        {

            chkButton2.Checked = true;

        }
        else
        {

            chkButton2.Checked = false;

        }

        //*******************************************

        if (buttons[2] >= 128)
        {

            chkButton3.Checked = true;

        }
        else
        {

            chkButton3.Checked = false;

        }

        //*******************************************

        if (buttons[3] >= 128)
        {

            chkButton4.Checked = true;

        }

        else
        {

            chkButton4.Checked = false;
        }

        //*******************************************

        if (buttons[4] >= 128)
        {

            chkButton5.Checked = true;

        }

        else
        {

            chkButton5.Checked = false;
        }

        //*******************************************

        if (buttons[5] >= 128)
        {

            chkButton6.Checked = true;

        }

        else
        {

            chkButton6.Checked = false;
        }

        //*******************************************

        if (buttons[10] >= 128)
        {

            chkButtonLeft.Checked = true;

        }

        else
        {

            chkButtonLeft.Checked = false;
        }

        //*******************************************

        if (buttons[11] >= 128)
        {

            chkButtonRight.Checked = true;

        }

        else
        {

            chkButtonRight.Checked = false;
        }

        //*******************************************

        if (buttons[6] >= 128)
        {

            chkButtonP1.Checked = true;

        }

        else
        {

            chkButtonP1.Checked = false;
        }

        //*******************************************

        if (buttons[7] >= 128)
        {

            chkButtonP2.Checked = true;

        }

        else
        {

            chkButtonP2.Checked = false;
        }

        //*******************************************

        if (buttons[8] >= 128)
        {

            chkButtonP3.Checked = true;

        }

        else
        {

            chkButtonP3.Checked = false;
        }

        //*******************************************

        if (buttons[9] >= 128)
        {

            chkButtonP4.Checked = true;

        }

        else
        {

            chkButtonP4.Checked = false;
        }

        //*******************************************
    }

    private void DisplayThread1()

    {  
        int xyz = 0; //I forgot how to make a while loop run forever so I just made a variable xyz and a condition that will never be true so it runs forever ghetto yes but functional

        while (xyz < 100)

        {

            poll();

        }

    }

            
  }


    
}
