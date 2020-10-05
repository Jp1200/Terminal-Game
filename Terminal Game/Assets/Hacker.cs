using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string[] level1Passwords = {"books","library","reading", "quiet", "knowledge", "aisle" };
    string[] level2Passwords = { "assualt", "law", "justicar", "vindictive", "operative", "badge" };
    string[] level3Passwords = { "starfields", "intergalatic", "blackholes", "relativity", "rockets", "magnetichyperpropulsion" };

    int level;
    enum Screen {MainMenu, Password, Win }
    Screen currentScreen;
    string password; 
    public void ShowMainMenu(string greeting)
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("./hack_init_script.sh");
        Terminal.WriteLine("intializing....");
        Terminal.WriteLine("IP's loaded: Hashes found");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type 'lTed4xD' for local library");
        Terminal.WriteLine("Type 'dWx9LZp' for police station");
        Terminal.WriteLine("Type '3Nsp09LvCyre' for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type 'cd' to come back");
        Terminal.WriteLine("Enter Selection: ");
    }
    // Start is called before the first frame update
    void Start()
    {
        string g = "Hello __Profile__";
        ShowMainMenu(g);
      
    }
    
    void OnUserInput(string input) {
        if (input == "cd")
        {
            ShowMainMenu("Welcome back");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "lTed4xD")
        {
            level = 1;
            StartGame();
        }
        else if (input == "dWx9LZp")
        {
            level = 2;
            
            StartGame();
        }
        else if (input == "3Nsp09LvCyre")
        {
            level = 3;
            StartGame();
        }

        else { Terminal.WriteLine("Incorrect Hash "); }
    }

    void StartGame()
    {
        setPassword();

        Terminal.WriteLine("Hash indentified...");
        Terminal.WriteLine("INIT LEVEL: " + level);
        Terminal.WriteLine("");
        Terminal.WriteLine("HINT: " + password.Anagram());
        Terminal.WriteLine("enter password: ");
    }

    void setPassword()
    {
        currentScreen = Screen.Password;
        var rand = new System.Random();
        switch (level)
        {
            case 1:
                {
                    password = level1Passwords[rand.Next(level1Passwords.Length)];
                    break;
                }
            case 2:
                {
                    password = level2Passwords[rand.Next(level2Passwords.Length)];
                    break;
                }
            case 3:
                {
                    password = level3Passwords[rand.Next(level3Passwords.Length)];
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.ClearScreen();
            setPassword();
            Terminal.WriteLine("Incorrect");
            Terminal.WriteLine("HINT: " + password.Anagram());
            Terminal.WriteLine("enter password: ");
        }
    }
    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowWin();
    }
    void ShowWin()
    {
        switch (level)
        {
            case 1:
                { Terminal.WriteLine("Library files accessed: ");
                    Terminal.WriteLine(@"
    _______
   /      /,
  /      //
 /______//
(______(/
 

");
                    break;
                }
            case 2:
                {
                    Terminal.WriteLine("Police infiltraited: ");
                    Terminal.WriteLine(@"
      __,_____
     / __.==--''
    /#(-'
    `-'
    ");
                    break;
                }
            case 3:
                {
                    Terminal.WriteLine("NASA files REDACTED: ");
                    Terminal.WriteLine(@"
         ,MMM8&&&.
    _...MMMMM88&&&&..._
 .::'''MMMMM88&&&&&&'''::.
::     MMMMM88&&&&&&     ::
'::....MMMMM88&&&&&&....::'
   `''''MMMMM88&&&&''''`
         'MMM8&&&'
");
                    break;
                }
                
                
        }
    }
}
