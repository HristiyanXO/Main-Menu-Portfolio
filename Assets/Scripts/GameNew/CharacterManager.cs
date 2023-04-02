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
    private float healthBar = 100;
    public bool isRange;
    public bool isPlayScene = false;
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

    var typeChar = character.characterAndEnvironment;
    if(isPlayScene) typeChar = character.character;
    
    newCharacter = Instantiate(typeChar);


      Destroy(selectedCharacter);
      selectedCharacter = newCharacter;
      // selectedCharacter.transform.SetParent(null);


    //  selectedCharacter = character.character;


  }

}


