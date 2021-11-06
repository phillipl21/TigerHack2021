using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : Monobehavior 
(
    private static string[] funLibraryList = { "Space", "Earth", "Solar System", "Jupiter",
     "Neptune", "Mercury", "Saturn", "Uranus", "Planet", "Pluto", "Mars", "Moon", "Asteroid", 
     "Asteriod Belt", "Black Hole", "Comet", "Inertia", "Orbit", "Gravity", "Milky Way", "Solar", 
     "Mass", "Rocket", "Solstice", "Meteor", "Galaxy", "Shooting Star", "Universe", "Telescope",
     "Zodiac", "Star", "Constellation", "Astronomy", "Space Exploration", "Take me to your leader"
    };
    
     public static string GetRandomWord()
    (
        int randomIndex = GetRandomWord.Range(0, funLibraryList.Length);
        string randomWord = funLibraryList[randomIndex];

        return randomWord;
    )

) 