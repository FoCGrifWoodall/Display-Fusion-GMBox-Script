using System;
using System.Drawing;

public static class DisplayFusionFunction
{
	public static void Run(IntPtr windowHandle)
	{
		// All code goes below, skips a lot of the intial setup thanks to DisplayFusion, also this is all C# cause I like it more than Visual Basic.
		
		//First step is creating, initializing, and setting a string to one of various different options selected via the BFS.Dialog.GetUserInputList (which displays a dialogue box and choices).
		string selectedGMBox = BFS.Dialog.GetUserInputList("Choose Which Campaign's GM Box to Open", new string[] { "Blade Failing", "Mobile Armor Advanced", "Project Breaker Fight" });
		
		//After that, it's a basic if, else if, and else conditional, with taking it one step deeper to bring up all the files needed using more BFS Functions.
		
		//This is if Blade Failing is Selected, as it checked to see if the string, "selectedGMBox" is set to "Blade Failing", which is the first choice in the list.
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
		//This is if the 2nd option, Mobile Armor Advanced is selected.
		else if (selectedGMBox == "Mobile Armor Advanced")
            {
            uint MobileArmorAdvancedGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Mobile Armor Advanced");
            uint MobileArmorAdvancedPDF = BFS.Application.Start("X:\\Gurps\\Mekton\\Mekton_Zeta.pdf");
            uint MobileArmorAdvancedRoll20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Mobile Armor Advanced\\Mobile_Armor_Advanced_Roll20_Shortcut.lnk");
            uint MobileArmorAdvancedUnUsedPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            }
		//This is if the 3rd option, Project Breaker Fight is selected.
		else if (selectedGMBox == "Project Breaker Fight")
            {
            uint ProjectBreakerFightGMBox = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Project Breaker Fight");
            uint ProjectBreakerFight20 = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Campaigns\\Blade Failing\\Project_Breaker_Fight_Roll20_Shortcut.lnk");
            uint ProjectBreakerFightPictures = BFS.Application.Start("C:\\Users\\Grif\\Desktop\\GM Box\\Un-used pictures");
            }
        //Finally, this is if no option is selected, which promptly closes the dialogue box after showing the message.
        else
            {
            BFS.Dialog.ShowMessageInfo("You have selected no GM Box");
            }
    }
}
