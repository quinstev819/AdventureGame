﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //tracks what part of the game the user is at
        int scene = 0;
        int randNum;
        int randNumber = 0;
        int rightDoor = 0;
        int leftDoor = 0;
        int straightDoor = 0;

        //random number generators
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You find yourself in a room. There are three doors. Which door would you like to try first?";
            redLabel.Text = "Right";
            blueLabel.Text = "Left";
            yellowLabel.Visible = true;
            yellowImage.Visible = true;
            yellowLabel.Text = "Straight";
            randNum = randGen.Next(1, 101);
            randNumber = randGen.Next(1, 101);
            debugNum.Text = "randNum = " + randNum;
            debugNumber.Text = "randNumber = " + randNumber;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see what button has been pressed and advance
            //to the next appropriate scene
            if (randNum < 33)
            {
                rightDoor = 1;
            }
            else if ((33 < randNum) && (randNum < 66))
            {
                leftDoor = 1;
            }
            else if (randNum > 66)
            {
                straightDoor = 1;
            }
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    if (rightDoor == 1)
                    {
                        scene = 2;
                    }
                    else if (leftDoor == 1)
                    {
                        scene = 1;
                        redLabel.ForeColor = Color.Red;
                    }
                    else if (straightDoor == 1)
                    {
                        scene = 1;
                        redLabel.ForeColor = Color.Red;
                    }
                }
                else if (scene == 1)
                {
                    if (rightDoor == 1)
                    {
                        scene = 2;
                    }
                    else if (leftDoor == 1)
                    {
                        scene = 1;
                        redLabel.ForeColor = Color.Red;
                    }
                    else if (straightDoor == 1)
                    {
                        scene = 1;
                        redLabel.ForeColor = Color.Red;
                    }
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    if (randNumber <= 75)
                    {
                        scene = 11;
                    }
                    else
                    {
                        outputLabel.Text = "The flashlight flickers then turns off.";
                        redLabel.Visible = false;
                        redImage.Visible = false;
                        blueLabel.Visible = false;
                        blueImage.Visible = false;
                        Refresh();
                        Thread.Sleep(2000);
                        scene = 4;
                    }
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 10;
                }
                else if (scene == 7)
                {
                    scene = 10;
                }
                else if (scene == 8)
                {
                    scene = 14;
                }
                else if (scene == 9)
                {
                    scene = 12;
                }
                else if (scene == 10)
                {
                    scene = 14;
                }
                else if (scene == 11)
                {
                    scene = 14;
                }
                else if (scene == 12)
                {
                    scene = 0;
                }
                else if (scene == 14)
                {
                    scene = 0;
                }
            }
            if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    if (rightDoor == 1)
                    {
                        scene = 1;
                        blueLabel.ForeColor = Color.Red;
                    }
                    else if (leftDoor == 1)
                    {
                        scene = 2;
                    }
                    else if (straightDoor == 1)
                    {
                        scene = 1;
                        blueLabel.ForeColor = Color.Red;
                    }
                }
                else if (scene == 1)
                {
                    if (rightDoor == 1)
                    {
                        scene = 1;
                        blueLabel.ForeColor = Color.Red;
                    }
                    else if (leftDoor == 1)
                    {
                        scene = 2;
                    }
                    else if (straightDoor == 1)
                    {
                        scene = 1;
                        blueLabel.ForeColor = Color.Red;
                    }
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 12;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 9;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 12;
                }
                else if (scene == 9)
                {
                    scene = 14;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 11)
                {
                    scene = 4;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
            }
            if (e.KeyCode == Keys.N)
            {
                if (scene == 0)
                {
                    if (rightDoor == 1)
                    {
                        scene = 1;
                        yellowLabel.ForeColor = Color.Red;
                    }
                    else if (leftDoor == 1)
                    {
                        scene = 1;
                        yellowLabel.ForeColor = Color.Red;
                    }
                    else if (straightDoor == 1)
                    {
                        scene = 2;
                    }
                }
                else if (scene == 1)
                {
                    if (rightDoor == 1)
                    {
                        scene = 1;
                        yellowLabel.ForeColor = Color.Red;
                    }
                    else if (leftDoor == 1)
                    {
                        scene = 1;
                        yellowLabel.ForeColor = Color.Red;
                    }
                    else if (straightDoor == 1)
                    {
                        scene = 2;
                    }
                }
            }
            /// Display text and game options to screen based on current scene
            switch (scene)
            {
                case 0:
                    randNum = randGen.Next(1, 101);
                    randNumber = randGen.Next(1, 101);
                    debugNum.Text = "randNum = " + randNum;
                    debugNumber.Text = "randNumber = " + randNumber;
                    outputLabel.Text = "You find yourself in a room. There are three doors. Which door would you like to try first?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowLabel.Visible = true;
                    yellowImage.Visible = true;
                    yellowLabel.Text = "Straight";
                    break;
                case 1:
                    outputLabel.Text = "The door is locked. Try again.";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowLabel.Visible = true;
                    yellowImage.Visible = true;
                    yellowLabel.Text = "Straight";
                    break;
                case 2:
                    outputLabel.Text = "The door creaks open. You find yourself in a hallway. Turn left or right?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    yellowLabel.ForeColor = Color.White;
                    redLabel.ForeColor = Color.White;
                    blueLabel.ForeColor = Color.White;
                    break;
                case 3:
                    outputLabel.Text = "You find a flashlight. Turn it on?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 4:
                    outputLabel.Text = "You see somebody down the hall. Call to them?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    redLabel.Visible = true;
                    redImage.Visible = true;
                    blueLabel.Visible = true;
                    blueImage.Visible = true;
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 5:
                    outputLabel.Text = "They ask you how you got there. Do you tell them you don't know or make up an answer?";
                    redLabel.Text = "You don't know";
                    blueLabel.Text = "Make up an answer";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "They seem skeptical of your answer but believe you. The ask you if you need help.";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 7:
                    outputLabel.Text = "They ask you what you are doing here. Do you tell them you don't know or do you try to learn about where you are.";
                    redLabel.Text = "You don't know";
                    blueLabel.Text = "Try to learn about where you are";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 8:
                    outputLabel.Text = "They leave you be. Do you continue down the hall on the right or left?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 9:
                    outputLabel.Text = "They leave you be. Do you try to find your way out, or try to figure out where you are?";
                    redLabel.Text = "Try to find your way out";
                    blueLabel.Text = "Try to figure out where you are";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 10:
                    outputLabel.Text = "They ask you if you'd like directions to get out. Do you say yes or no.";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 11:
                    outputLabel.Text = "The flashlight turned on revealing a payphone at the end of the hall. Call for help?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 12:
                    outputLabel.Text = "You try to find your way around, but you get lost in the building. You never find your way out. Do you want to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 13:
                    outputLabel.Text = "Thank you for playing!";
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    yellowLabel.Visible = false;
                    yellowImage.Visible = false;
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                case 14:
                    outputLabel.Text = "You find the exit! You get out of the building and live the rest of your life. Do you want to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 15:
                    outputLabel.Text = "Thank you for playing!";
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    yellowLabel.Visible = false;
                    yellowImage.Visible = false;
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                    break;
            }
        }
    }
}