# ZombieRandomiser

Project made to randomise Black Ops 3 zombie games.
We played it so much with my friends, we decided to spice it up a little :)

# Table of Contents
1. [Installation](#installation)
2. [How to use the program](#how-to-use-the-program)
   1. [Interface](#interface)
   2. [Rules](#rules)
3. [Edit the software](#edit-the-program)
   1. [Add the database to the solution](#add-db)
   2. [NuGet packages](#nuget)
4. [Credit and crew](#credit-and-crew)




# Installation <a name="installation"></a>
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



# How to use the software <a name="how-to-use-the-program"></a>

## Interface <a name="interface"></a> 

![alt text](https://raw.githubusercontent.com/LouisRichard/ZombieRandomiser/main/_assets/mainWindow.jpg "Main Window")


1. Button to randomise the map. Click this button to get a random map
2. Map selection. Use this menu to select a specific map. If you randomise, the map name will appear here
3. Player color. This is the color the players score will appear as
4. Perks. 4 perks per player. 
5. Weapons. Include all weapons in the box and on the walls. A third option will appear if the player has Mule Kick in their perks.
6. Randomize button. Click here to randomise the perks and weapons according to the selected map.


## Rules <a name="rules"></a>

Here's how me and my friends play it :

* The final setup must be the same as the one in this window
* If it takes the player too long to get to their build, they may buy a wallgun temporarily
* The perks are to be bought In no perticular orther
* If the player just can't play with their randomised build and it kills the fun for him, he may reroll
* It none of the players have juggernog in their build, good luck :) 
* The players may use the Pack A Punch machine at will
* Gobblegums aren't restricted. You may pick whichever one you want
* Have fun :D  

You can, of course, make your own rules if you want



# Edit the program <a name="edit-the-program"></a>

## Add the database in the solution <a name="add-db"></a>

Before editing the program, there's a little thing you need to do

take the ZombieDB.db3 file and put it in the following folder : 

`ZombieRandomiser/ZombieRandomiser/bin/Debug`

if the folder doesn't exist, you can compile the program once and it should appear.

The debugger will spat out an error because, well, the database doesn't exist.



Once that's done, you can run the program and it should run just fine 🤞



## NuGet packages <a name="nuget"></a>

This softwares uses the following NuGet Package :

* System.Data.SQLite

If it's not there, the program will not run



# Credit and crew <a name="credit-and-crew"></a>

* Louis Richard - Main dev
* Liam Trancoso - Tests
* Ewan Grobet - Tests
* [IconFreePik](https://www.iconfreepik.com/icons8-halloween-zombie-icon-free-pik-download/) - Icon
