# ZombieRandomiser

Project made to randomise Black Ops 3 zombie games.
We played it so much with my friends, we decided to spice it up a little :)

# Installation
To install the program, follow these simple steps

- Get the latest release from [here](https://github.com/LouisRichard/ZombieRandomiser/releases)
- Download and run ZombieRandomiser_vX-Y-Z.msi

  - Windows will warn you that this program is not signed and you're installing at your own risk.
    - To bypass this warning, click <u>More info</u> and the option `Run Anyway` will appear.
- The Setup Wizard will then appear
- You can choose to install it wherever. 

  - Default : C:\Program Files (x86)\Lilith\ZombieRandomiser\
- Then it's next , next and close, the usual



After these few steps, the program will appear in your start menu and on your desktop with the name "Zombie Randomiser"



# How to use the program
  
 
![alt text](https://raw.githubusercontent.com/LouisRichard/ZombieRandomiser/main/_assets/mainWindow.jpg "Main Window")


1. Button to randomise the map. Click this button to get a random map
2. Map selection. Use this menu to select a specific map. If you randomise, the map name will appear here
3. Player color. This is the color the players score will appear as
4. Perks. 4 perks per player. 
5. Weapons. Include all weapons in the box and on the walls. A third option will appear if the player has Mule Kick in their perks.
6. Randomize button. Click here to randomise the perks and weapons according to the selected map.



Rules : Make up your own! That's the beauty of it.

But in case you don't want to, here's how me and my friends play : 

* The final setup must be the same as the one in this window
* If it takes the player too long to get to their build, they may buy a wallgun temporarily
* The perks are to be bought In no perticular orther
* If the player just can't play with their randomised build and it kills the fun for him, he may reroll
* It none of the players have juggernog in their build, good luck :) 
* The players may use the Pack A Punch machine at will
* Gobblegums aren't restricted. You may pick whichever one you want
* Have fun :D  


# General informations 
The project is written in C# .NET with the .NET Framework.
It's only meant to work on Windows. I'm sure there's way to run it on Linux and I'm sure you can figure it out by yourself :)

This software uses an SQLite database to store all the weapons, perks and maps as well as which weapons and perks are on which map.



# Edit the program

Before editing the program, there's a little thing you need to do

take the ZombieDB.db3 file and put it in the following folder : 

`ZombieRandomiser/ZombieRandomiser/bin/Debug`

if the folder doesn't exist, you can compile the program once and it should appear.

The debugger will spat out an error because, well, the database doesn't exist.



Once that's done, you can run the program and it should run just fine 🤞





# Credit and crew

* Louis Richard - Main dev
* Liam Trancoso - Tests
* Ewan Grobet - Tests
* [IconFreePik](https://www.iconfreepik.com/icons8-halloween-zombie-icon-free-pik-download/) - Icon
