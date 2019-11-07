/*
 * Quinlan Stevenson
 * Lost in a Building
 * November 6th, 2019
 * This code is for the text based adventure game.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //tracks what part of the game the user is at
        int scene = 0;

        //initializing the random number generator value holders
        int randNum;
        int randNumber = 0;

        //initializing the door values for the first random number generator
        int rightDoor = 0;
        int leftDoor = 0;
        int straightDoor = 0;

        //random number generators
        Random randGen = new Random();

        //sound players
        SoundPlayer doorCreakingSound = new SoundPlayer(Properties.Resources.Old_Door_Creaking_SoundBible_com_1197162460);
        SoundPlayer flashlightDeadSound = new SoundPlayer(Properties.Resources.Dying_Light_Bulb_SoundBible_com_742005847);
        SoundPlayer doorLockedSound = new SoundPlayer(Properties.Resources._472674__tvilgiat__locked_door);
        SoundPlayer flashlightTurningOnSound = new SoundPlayer(Properties.Resources._173420__lightyarn__flashlight_on);
        SoundPlayer hallwaySound = new SoundPlayer(Properties.Resources._84953__amszala__hallway);
        SoundPlayer winSound = new SoundPlayer(Properties.Resources.Ta_Da_SoundBible_com_1884170640);
        SoundPlayer loseSound = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You find yourself in a room. There are three doors. Which door do you choose?";
            redLabel.Text = "Right";
            blueLabel.Text = "Left";
            yellowLabel.Visible = true;
            yellowImage.Visible = true;
            yellowLabel.Text = "Straight";

            //setting up the random number generators
            randNum = randGen.Next(1, 101);
            randNumber = randGen.Next(1, 101);

            //displaying the image for scene 0
            sceneImage.BackgroundImage = Properties.Resources.IMG_1255;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //setting up which door is unlocked at the beginning of the game
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

            //check to see what button has been pressed and advance to the next appropriate scene
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
                        flashlightTurningOnSound.Play();
                    }
                    else
                    {
                        outputLabel.Text = "The flashlight flickers then turns off.";
                        flashlightDeadSound.Play();
                        redLabel.Visible = false;
                        redImage.Visible = false;
                        blueLabel.Visible = false;
                        blueImage.Visible = false;
                        Refresh();
                        flashlightDeadSound.Play();
                        sceneImage.BackgroundImage = Properties.Resources.nebo_transport_rechargeable_led_flashlight_on;
                        Thread.Sleep(1000);
                        sceneImage.Visible = false;
                        Thread.Sleep(250);
                        sceneImage.Visible = true;
                        Thread.Sleep(250);
                        sceneImage.Visible = false;
                        Refresh();
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
            //Display text and game options to screen based on current scene
            switch (scene)
            {
                case 0:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    randNum = randGen.Next(1, 101);
                    randNumber = randGen.Next(1, 101);
                    outputLabel.Text = "You find yourself in a room. There are three doors. Which door do you choose?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowLabel.Visible = true;
                    yellowImage.Visible = true;
                    yellowLabel.Text = "Straight";
                    sceneImage.BackgroundImage = Properties.Resources.IMG_1255;
                    hallwaySound.Play();
                    break;
                case 1:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "The door is locked. Try again.";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowLabel.Visible = true;
                    yellowImage.Visible = true;
                    yellowLabel.Text = "Straight";
                    sceneImage.BackgroundImage = Properties.Resources.IMG_1255;
                    doorLockedSound.Play();
                    break;
                case 2:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "The door creaks open. You find yourself in a hallway. Turn left or right?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    yellowLabel.ForeColor = Color.White;
                    redLabel.ForeColor = Color.White;
                    blueLabel.ForeColor = Color.White;
                    doorCreakingSound.Play();
                    sceneImage.BackgroundImage = Properties.Resources._0666f3308bbea81016370b75fc80ef8f;
                    break;
                case 3:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "You find a flashlight. Turn it on?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.MDC_Bodyguard_V2_18650_1_1400x_progressive;
                    hallwaySound.Play();
                    break;
                case 4:
                    sceneImage.Visible = true;
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "You see somebody down the hall. Do you call to them?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    redLabel.Visible = true;
                    redImage.Visible = true;
                    blueLabel.Visible = true;
                    blueImage.Visible = true;
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources._1_LI__2_;
                    hallwaySound.Play();
                    break;
                case 5:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "They ask you how you got there. Do you tell them you don't know or make up an answer?";
                    redLabel.Text = "You don't know";
                    blueLabel.Text = "Make up an answer";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.hat_man;
                    hallwaySound.Play();
                    break;
                case 6:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "They seem skeptical of your answer but believe you. They ask if you need help.";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.hat_man;
                    hallwaySound.Play();
                    break;
                case 7:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "They ask you what you are doing here. Do you tell them you don't know or do you try to learn about where you are.";
                    redLabel.Text = "You don't know";
                    blueLabel.Text = "Try to learn about where you are";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.hat_man;
                    hallwaySound.Play();
                    break;
                case 8:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "They leave you alone. Do you continue down the hall on the right or left?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources._0666f3308bbea81016370b75fc80ef8f;
                    hallwaySound.Play();
                    break;
                case 9:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "They leave you alone. Do you try to find your way out, or try to figure out where you are?";
                    redLabel.Text = "Try to find your way out";
                    blueLabel.Text = "Try to figure out where you are";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources._0666f3308bbea81016370b75fc80ef8f;
                    hallwaySound.Play();
                    break;
                case 10:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "They ask you if you'd like directions to get out. Do you say yes or no?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    hallwaySound.Play();
                    break;
                case 11:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "The flashlight turned on revealing a payphone at the end of the hall. Do you call for help?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    flashlightTurningOnSound.Play();
                    sceneImage.BackgroundImage = Properties.Resources.nebo_transport_rechargeable_led_flashlight_on;
                    break;
                case 12:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "You try to find your way around, but you get lost in the building. You never find your way out. Do you want to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources._0666f3308bbea81016370b75fc80ef8f;
                    loseSound.Play();
                    break;
                case 13:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "Thank you for playing!";
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    yellowLabel.Visible = false;
                    yellowImage.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.download;
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                case 14:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "You found the exit! You get out of the building and live the rest of your life. Do you want to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowImage.Visible = false;
                    yellowLabel.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.open_door_1024x682;
                    winSound.Play();
                    break;
                case 15:
                    hallwaySound.Stop();
                    flashlightTurningOnSound.Stop();
                    flashlightDeadSound.Stop();
                    doorLockedSound.Stop();
                    doorCreakingSound.Stop();
                    winSound.Stop();
                    loseSound.Stop();
                    outputLabel.Text = "Thank you for playing!";
                    redLabel.Visible = false;
                    redImage.Visible = false;
                    blueLabel.Visible = false;
                    blueImage.Visible = false;
                    yellowLabel.Visible = false;
                    yellowImage.Visible = false;
                    sceneImage.BackgroundImage = Properties.Resources.download;
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                    break;
            }
        }
    }
}