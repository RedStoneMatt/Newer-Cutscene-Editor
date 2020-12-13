# Newer Cutscene Editor
A tool to make your own NewerSMBW Cutscenes using the built-in unused beta cutscenes from the game.

# How does it work ?
For those who don't know, it was planned for [NewerSMBW](https://newerteam.com/) to have cutscenes, but the idea was scrapped even though the entire [opening cutscene](https://www.youtube.com/watch?v=7GFCzH-_Bwg) was done, which is a shame in my opinion.

Though, the system it used still is in the code, but is disabled ! The opening cutscene can actually be re-enabled by commenting the [DoOpeningLevel](https://github.com/Treeki/NewerSMBW/blob/no-translations/Kamek/cutScene.yaml#L4) hook in [cutscene.yaml](https://github.com/Treeki/NewerSMBW/blob/no-translations/Kamek/cutScene.yaml), though you will need to add a CS folder to your game and put the Opening cutscene files in it, which are sadly private.

But it doesn't mean you can't profit of this system, right ?

Cutscenes work with two kind of files: Layout files and a CS file

The CS file defines which scene plays when and uses which SFX after how many frames while playing which music. This tool was made to create/edit these files.

The Layout files contains the animation that is played, which can be made using nintendo's LayoutEditor, which can be found in the Wii SDK (and therefore is illegal to distribute, so you will need to find it by your own !), just note that when you compile your layout, the outputed .brlyt file must be named cutscene.brlyt, and the outputed .brlan must be named cutscene.brlan.

Each cutscene consists of multiple scenes, each one using a separate Layout, as the Wii can't support too big layouts (so you can't make one giant layout that will contain your entire cutscene). You will also need (if you want optimal quality) to make two versions of your cutscene: a widescreen one, and a non-widescreen one. If you don't want to annoy yourself, feel free to make just the widescreen one, but then RIP the few 4:3 players :p

# I got no code knowledges or whatsoever, but I know how to make layouts and stuff, what is the process I should follow to make my own opening cutscene ?
Heh, simple enough !
Download [this build](https://drive.google.com/file/d/11QvCjqL1fzc4lIgS5Mz3ZBgb0hzYgp6C/view?usp=sharing) of NewerSMBW's code with re-enabled cutscenes and put it in the NewerRes folder of your game ! Then name your non-widescreen opening cutscene's CS file "Opening.cs", and the widescreen version "WideOpening.cs", and then make a CS folder in your game, put both CS files, add your layouts (named accordingly to what you set in the CS file) and boot the game !

# Usage
Build the code by yourself using [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/) or download the latest [Compiled Binary](https://github.com/RedStoneMatt/Newer-Cutscene-Editor/releases) and open the software.

Now, click File -> New (as there isn't any public .cs file as of now) to create a new cutscene file.

Then feel free to add as much scenes as you want, adding Sound commands to them, etc..

If you need, I included an example ("Example.cs") along with a text file ("Example.txt") explaining what does it do !

# Nice ! How do I know which SFX number is which Sound Effect ?
Just check [this file](https://github.com/Treeki/NewerSMBW/blob/no-translations/Kamek/include/sfx.h), it contains the internal SFX name of each SFX ID there is in the game ! That should make it easier for you to find the SFXs you want !

# Warning
As said before, you need to reenable the cutscenes in [NewerSMBW's code](https://github.com/Treeki/NewerSMBW/tree/no-translations) to get them to work. Plus, you will probably need code knowledges if you want your cutscenes to play at certain moments other than the Opening Cutscene. So if you need help with that, feel free to ask me on discord: RedStoneMatt#2826