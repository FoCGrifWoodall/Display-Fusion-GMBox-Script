This is the README doc for setting up the code to work for you.

For starters, you will need a non-free version of DisplayFusion.
I personally recommend the steam version, especially if you are a gamer.
Also this is for Windows, can't remember if they have a non-windows version.

Once you download Display Fusion and set it up for the first time, go to settings.
Once at settings, go to the Functions tab.
Once at the Functions tab, click on the Add Scripted Button.
The window that pop up will be where you past the code into, I suggest deleting anything there and pasting in everything.
Make sure the language is set to C#.
Choose a key combination (mine is set to Shift + Ctrl + Z).
Save it with whatever name you choose (mine is saved as GMBoxSelector).

The following bits are more for if you are not a reasonably experienced programmer, as at this point, you can probably see the code and now what to do if you just read the comments I put in.

Now, this is the part where it gets tricky, 
The first line of code you need to look at is this:
string selectedGMBox = BFS.Dialog.GetUserInputList("Choose Which Campaign's GM Box to Open", new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" });
"Choose Which Campaign's GM Box to Open" is the the text that will be displayed.
"Blade Failing", "Mobile Armor Advanced", and "Project Breaker: Fight" are the current options.
Let's do a quick example.
I want the text, "Choose a GM Box to Open" to be displayed instead of "Choose Which Campaign's GM Box to Open".
As such, I will remove the old text, and then type in the new text needed to make this change, which will be shown on the next lines.
1. string selectedGMBox = BFS.Dialog.GetUserInputList("Choose Which Campaign's GM Box to Open", new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" });
2. string selectedGMBox = BFS.Dialog.GetUserInputList("", new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" });
3. string selectedGMBox = BFS.Dialog.GetUserInputList("Choose a GM Box to Open", new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" });
This 3 step process will allow you to change the text displayed when you are given the various options.

Next Portion, the actual options themselves.
I want you to look at 4 lines in specific, the lines are these
string selectedGMBox = BFS.Dialog.GetUserInputList("Choose Which Campaign's GM Box to Open", new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" });
if (selectedGMBox == "Blade Failing")
else if (selectedGMBox == "Mobile Armor Advanced")
else if (selectedGMBox == "Project Breaker Fight")

Now for the first line, I want you to look at the following part specifically:
new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" }
Those are your options, by selecting one of these options, it will go and trigger the remaining parts of the script based upon what option you selected.
In Example, if you selected "Mobile Armor Advanced", it will trigger the code under the following line:
else if (selectedGMBox == "Mobile Armor Advanced")

Same for "Blade Failing" which will trigger if (selectedGMBox == "Blade Failing"), and same for "Project Breaker Fight" which will trigger else if (selectedGMBox == "Project Breaker Fight")
However, if the cancel button is hit, it will trigger the following lines of code
        else
            {
            BFS.Dialog.ShowMessageInfo("You have selected no GM Box");
            }

Now then, with that in mind, I'm going to add on a 4th option along with a 4th else if code section
The first thing I'm going to do is expand the earlier part, new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" }
Now, the fourth option is going to be for an idea I had earlier about a Fighting/Action/Adventure show called Dragon Ball Z and making a campaign out of that.
As such, I'm going to go ahead and add it on using another 3 step process by modifying the specific code in the following line:
1. new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" }
2. new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight", "" }
3. new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight", "DBZ" }
In the 3 Step Process, I added a comma, quotation marks, and the text for the 4th option, so now, the line of code looks like this:
string selectedGMBox = BFS.Dialog.GetUserInputList("Choose Which Campaign's GM Box to Open", new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight", "DBZ" });

Congrats, you added on another option. But it's still missing the part of the script that will launch everything for that 4th option.
If you remember from before:
if (selectedGMBox == "Blade Failing")
else if (selectedGMBox == "Mobile Armor Advanced")
else if (selectedGMBox == "Project Breaker Fight")
These 3 lines are the conditionals, or for example purposes, containers, for the script that launches the files needed for each option respectively.
This means we need another.

To save some time for you if you just want to use the script but don't want to learn programming, we're just gonna copy and paste.
		if (selectedGMBox == "Blade Failing")
            {
            //This is the bit that took me the most, as it was a combination of organization on my desktop + figuring out how to get the files launched that I wanted.
            uint BladeFailingGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing");
            uint BladeFailingPDF = BFS.Application.Start("X:\\Gurps\\Legend of the Five Rings\\Legend_of_the_Five_Rings_4th_Edition.pdf");
            //The Roll20 Shortcuts were actually the most difficult to figure out, but I promptly sneaked a workaround by just making a shortcut to the proper webpage in the folder.
            uint BladeFailingRoll20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing\\Blade_Failing_Roll20_Shortcut.lnk");
            uint BladeFailingUnUsedPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            uint BladeFailingMusic = BFS.Application.Start("C:\\Users\\Grif\\Music\\Rise Against\\The Black Market\\05 The Eco-Terrorist In Me.m4a");
            bool BladeFailingWallpaper = BFS.DisplayFusion.LoadWallpaperProfile("Blade Failing");
            }

Specifically, we are copy and pasting that, right before the else line, or more specifically, it should look like this:

		//This is if the 3rd option, Project Breaker Fight is selected.
		else if (selectedGMBox == "Project Breaker Fight")
            {
            uint ProjectBreakerFightGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Project Breaker Fight");
            uint ProjectBreakerFight20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing\\Project_Breaker_Fight_Roll20_Shortcut.lnk");
            uint ProjectBreakerFightPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            }
		if (selectedGMBox == "Blade Failing")
            {
            //This is the bit that took me the most, as it was a combination of organization on my desktop + figuring out how to get the files launched that I wanted.
            uint BladeFailingGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing");
            uint BladeFailingPDF = BFS.Application.Start("X:\\Gurps\\Legend of the Five Rings\\Legend_of_the_Five_Rings_4th_Edition.pdf");
            //The Roll20 Shortcuts were actually the most difficult to figure out, but I promptly sneaked a workaround by just making a shortcut to the proper webpage in the folder.
            uint BladeFailingRoll20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing\\Blade_Failing_Roll20_Shortcut.lnk");
            uint BladeFailingUnUsedPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            uint BladeFailingMusic = BFS.Application.Start("C:\\Users\\Grif\\Music\\Rise Against\\The Black Market\\05 The Eco-Terrorist In Me.m4a");
            bool BladeFailingWallpaper = BFS.DisplayFusion.LoadWallpaperProfile("Blade Failing");
            }
        //Finally, this is if no option is selected, which promptly closes the dialogue box after showing the message.
        else
            {
            BFS.Dialog.ShowMessageInfo("You have selected no GM Box");
            }

Now, we need to make some changes, first, let's swap any place outside parenthesis that says BladeFailing with DBZ
Ontop of that, let's also remove those duplicated comments in the middle of it. It should now look like this.
            
		//This is if the 3rd option, Project Breaker Fight is selected.
		else if (selectedGMBox == "Project Breaker Fight")
            {
            uint ProjectBreakerFightGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Project Breaker Fight");
            uint ProjectBreakerFight20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing\\Project_Breaker_Fight_Roll20_Shortcut.lnk");
            uint ProjectBreakerFightPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            }
		else if (selectedGMBox == "DBZ")
            {
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing");
            uint DBZgPDF = BFS.Application.Start("X:\\Gurps\\Legend of the Five Rings\\Legend_of_the_Five_Rings_4th_Edition.pdf");
            uint DBZRoll20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing\\Blade_Failing_Roll20_Shortcut.lnk");
            uint DBZUnUsedPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            uint DBZMusic = BFS.Application.Start("C:\\Users\\Grif\\Music\\Rise Against\\The Black Market\\05 The Eco-Terrorist In Me.m4a");
            bool DBZWallpaper = BFS.DisplayFusion.LoadWallpaperProfile("Blade Failing");
            }
        //Finally, this is if no option is selected, which promptly closes the dialogue box after showing the message.
        else
            {
            BFS.Dialog.ShowMessageInfo("You have selected no GM Box");
            }

Sweet, we now have the 4th option successfully added in. There are some problems. Namely it's still going to open anything related to Blade Failing rather than DBZ.
To fix that, we have to look at the following lines:
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing");
            uint DBZgPDF = BFS.Application.Start("X:\\Gurps\\Legend of the Five Rings\\Legend_of_the_Five_Rings_4th_Edition.pdf");
            uint DBZRoll20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing\\Blade_Failing_Roll20_Shortcut.lnk");
            uint DBZUnUsedPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            uint DBZMusic = BFS.Application.Start("C:\\Users\\Grif\\Music\\Rise Against\\The Black Market\\05 The Eco-Terrorist In Me.m4a");
            bool DBZWallpaper = BFS.DisplayFusion.LoadWallpaperProfile("Blade Failing");
            
Now, 5 of these 6 lines open a folder or a file, depending on the specified filepath inside the parenthesis.
The 6th line loads a wallpaper profile saved in DisplayFusion for the desktop background.

Now, we are going to do three things
1. Remove the lines we aren't using, so basically all except one, as I only have the base folder at the moment for the DBZ based campaign.
2. Edit the filepath to the correct one
3. Make a test for you so you can understand how to launch and view a random image saved you computer.

I'm gonna go ahead and knock the first thing out of the way.
All that's left is
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing");
Now, I'm going to change the folder that is launched by the file path, so first I'll get rid of the curret one.
            uint DBZGMBox = BFS.Application.Start("");
Now that the old filepath is gone, time for me to grab the new one. I'm using Windows Explorer to grab it.
The filepath I have displayed via the Windows Explorer is
C:\Users\Grif\Desktop\GM Box\Campaigns\Dragon Ball Z
Let's put that in there
            uint DBZGMBox = BFS.Application.Start("C:\Users\Grif\Desktop\GM Box\Campaigns\Dragon Ball Z");
It's still missing something, what it is missing is the 2nd slash.
Just trust me on adding the second slash, it's to save explaining why you need it.
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");
            
Alright, now let's add on finding a file for you so you understand the process.
First, find a picture anywhere on your computer, literally anywhere.
For me, I decided on a picture with the filename imagesCAMVWWY1 and the filetype JPEG
This file is going to be imagesCAMVWWY1.jpg
PDFs are filenamehere.pdf
Etc, etc. Just make sure you have the right filename and the right filetype extension
Okay, once you know what the file is, figure out the address, mine is
C:\Users\Grif\Desktop\Random Pictures Folder

So, let's first put in the file location, or rather, the url/address displayed in Windows Explorer.
We are however going to copy and paste once again from the earlier example:
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");
            
Let's paste it right beneath, so it should be
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");
            
Now, let's go in and fix that duplicate variable (The "DBZGMBox" part of it)
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");
            uint DBZGMexamplepicture = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");

That's how I fixed it, just make sure that one part is a duplicate and it should run fine.
Anyways, let's go ahead and put in the url/address now that we got as well as fix it so we have 2 slashes at every slash
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\Random Pictures Folder");
            
Let's add on the final bit, the picture example or whatever file you used.
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Dragon Ball Z");
            uint DBZGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\Random Pictures Folder\\imagesCAMVWWY1.jpg");
And done, all you need to do is add on a pair of slashes at the end, then the file, and there you go, should work.

Congrats on making it this far, hopefully you won't have any troubles doing this or making changes from now on.
I might end up making a video tutorial at some point, not sure.
If you happen to have any issues, reread the steps and see if you can't figure it out.
Unfortunately, if there's a programming error somewhere, and you aren't a programmer, you might be out of luck as I can't possibly cover the huge amount of programming errors that would happen.

However, if you want me to check what you have, let me know, and I should at least be able to look over it.
-Grif

            
