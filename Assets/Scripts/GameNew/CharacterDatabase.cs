using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
   public Character[] character;

    public int charIndex = 0;

    public int CharacterCount
    {
        get{
            return character.Length;
        }
    }

    public Character GetCharacter(int index){
        charIndex = index;
        return character[index];
    }
    public Character GetCurrent()
    {
        return character[charIndex];
    }    
 
}
