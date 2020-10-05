using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    public void ShowMainMenu(string greeting)
    {
        
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("./hack_init_script.sh");
        Terminal.WriteLine("intializing....");
        Terminal.WriteLine("IP's loaded: Hashes found");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type 'lTed4xD' for local library");
        Terminal.WriteLine("Type 'dWx9LZp' for police station");
        Terminal.WriteLine("Type '3Nsp09LvCyre' for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type 'menu' to come back");
        Terminal.WriteLine("Enter Selection: ");
    }
    // Start is called before the first frame update
    void Start()
    {
        string g = "Hello __Profile__";
        ShowMainMenu(g);
      
    }

    void OnUserInput(string input) {
        if (input == "lTed4xD")
        {

            print("success for level 1");
        }
        else if (input == "dWx9LZp")
        {
            print("Level 2");
        }
        else if (input == "3Nsp09LvCyre")
        {
            print("Level 3");
        }
        else if (input=="menu"){
            ShowMainMenu("Welcome back");
        }
        else { Terminal.WriteLine("Incorrect Hash "); }   
        
    }

}
