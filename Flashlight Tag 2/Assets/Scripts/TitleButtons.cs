using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
    public GameObject titleMenu;
    public GameObject extrasMenu;
    public GameObject sceneAssets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Load Game Scene When Play is Pressed on the Main Menu
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    //Turn off Title Screen and Title Assets, Turn on Extras menu
    public void ExtrasButton()
    {
        titleMenu.SetActive(false);
        sceneAssets.SetActive(false);
        extrasMenu.SetActive(true);
    }
    //Turn off Jumpscare Menu, Custom Night Setup and Help Menu
    public void CharacterButton()
    {
        //SetActiveT Tag
        //Set ActiveT Character Select
        //JumpscaresF
        //Help MenuF
        //Custom nightF
    }
    //Turn On Tag
    public void CharacterMenuTag()
    {
        //SetActiveF Music Man
        //SetActiveF Puppet
        //SetActive Tag
        //SetActiveF RTag
    }
    //Turn on Puppet Character
    public void CharacterMenuPuppet()
    {
        //SetActiveF Music Man
        //SetActive Puppet
        //SetActiveF Tag
        //SetActiveF RTag
    }
    //Turn on Music Character
    public void CharacterMenuMusicMan()
    {
        //SetActiveT Music Man
        //SetActiveF Puppet
        //SetActiveF Tag
        //SetActiveF RTag
    }
    //Turn on Reverse Tag Character
    public void CharacterMenuRTag()
    {
        //SetActiveT Music Man
        //SetActiveF Puppet
        //SetActiveF Tag
        //SetActive RTag
    }
    //Turn on Title Screen Assets, Turn off Extras Menu Assets
    public void BackButton()
    {
        titleMenu.SetActive(true);
        sceneAssets.SetActive(true);
        extrasMenu.SetActive(false);
    }
    //When Quit is pressed, this will close the application
    public void ExitButton()
    {
        Application.Quit();
    }
}
