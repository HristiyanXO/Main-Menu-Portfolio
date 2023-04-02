using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterManager : MonoBehaviour
{

    public CharacterDatabase characterDB;

    public GameObject selectedCharacter;
    public GameObject currentChar;
    public Text nameText;
    private int selectedOption = 0;
    private float healthBar = 100;
    public bool isRange;
    public bool isPlayScene = false;
    private Transform position;
    private GameObject newCharacter;  
      private GameObject playerCamera;

    void Start()
    {
      UpdateCharacter(selectedOption);
    }
  public void Update(){
    Character character = characterDB.GetCharacter(selectedOption);
      
      playerCamera =  GameObject.FindGameObjectWithTag("Camera");

     if (Input.GetMouseButtonDown(0))
         {
          Vector3 position = playerCamera.transform.position;
          position.x += 5;
          position.y -= 2;
          Debug.Log(position);
          Instantiate(character.skill, position, selectedCharacter.transform.rotation);

         }
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
  
  public void Attack(){

  }
  
}


