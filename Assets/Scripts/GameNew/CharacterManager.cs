using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterManager : MonoBehaviour
{

    public CharacterDatabase characterDB;

    public GameObject selectedCharacter;
    public Text nameText;
    
    private int selectedOption = 0;
    private Transform position;
    private GameObject newCharacter;

    void Start()
    {

      UpdateCharacter(selectedOption);
    }

  public void UpdateCharacter(int index)
  {
      selectedOption = index;

      Character character = characterDB.GetCharacter(selectedOption);
      

      // nameText.text = character.characterName;

      newCharacter = Instantiate(character.characterAndEnvironment);

      Destroy(selectedCharacter);
      selectedCharacter = newCharacter;
      // selectedCharacter.transform.SetParent(null);


    //  selectedCharacter = character.character;


  }

}


