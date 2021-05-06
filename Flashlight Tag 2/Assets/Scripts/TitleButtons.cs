using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleButtons : MonoBehaviour
{
    public GameObject titleMenu;
    public GameObject extrasMenu;
    public GameObject sceneAssets;

    public GameObject HelpMenu;
    public GameObject Characters;
    public GameObject CharacterSelection;
    public GameObject Jumpscares;
    public GameObject JumpscareSelection;
    public GameObject CustomNightAI;

    public GameObject TagModel;
    public GameObject PuppetModel;
    public GameObject MusicManModel;
    public GameObject RTagModel;

    public GameObject TagJumpscare;
    public GameObject PuppetJumpscare;
    public GameObject MusicManJumpscare;
    public GameObject RTagJumpscare;

    public Text TagNumber;
    public Text PuppetNumber;
    public Text MusicManNumber;
    public Text RTagNumber;

    //These will be replaced with AI Levels
    private int TagAINumber;
    private int PuppetAINumber;
    private int MusicManAINumber;
    private int RTagAINumber;

    // Start is called before the first frame update
    void Start()
    {
        TagAINumber = 0;
        PuppetAINumber = 0;
        MusicManAINumber = 0;
        RTagAINumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TagNumber.text = "" + TagAINumber;
        PuppetNumber.text = "" + PuppetAINumber;
        MusicManNumber.text = "" + MusicManAINumber;
        RTagNumber.text = "" + RTagAINumber;
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
        CharacterMenuTag();
        CharacterSelection.SetActive(true);
        JumpscareSelection.SetActive(false);
        Jumpscares.SetActive(false);
        Characters.SetActive(true);
        HelpMenu.SetActive(false);
        CustomNightAI.SetActive(false);
    }
    //Turn On Tag
    public void CharacterMenuTag()
    {
        MusicManModel.SetActive(false);
        PuppetModel.SetActive(false);
        TagModel.SetActive(true);
        RTagModel.SetActive(false);
    }
    //Turn on Puppet Character
    public void CharacterMenuPuppet()
    {
        MusicManModel.SetActive(false);
        PuppetModel.SetActive(true);
        TagModel.SetActive(false);
        RTagModel.SetActive(false);
    }
    //Turn on Music Character
    public void CharacterMenuMusicMan()
    {
        MusicManModel.SetActive(true);
        PuppetModel.SetActive(false);
        TagModel.SetActive(false);
        RTagModel.SetActive(false);
    }
    //Turn on Reverse Tag Character
    public void CharacterMenuRTag()
    {
        MusicManModel.SetActive(false);
        PuppetModel.SetActive(false);
        TagModel.SetActive(false);
        RTagModel.SetActive(true);
    }
    //Turn on Help Menu, Turn off other Menus and Models
    public void HelpMenuButton()
    {
        CharacterSelection.SetActive(false);
        JumpscareSelection.SetActive(false);
        HelpMenu.SetActive(true);
        Characters.SetActive(false);
        Jumpscares.SetActive(false);
        CustomNightAI.SetActive(false);
    }
    //Turn on Jumpscare Menu and Jumpscare Models, Turn off other Menus and Models
    public void JumpscaresMenu()
    {
        JumpscaresMenuTag();
        CharacterSelection.SetActive(false);
        JumpscareSelection.SetActive(true);
        Jumpscares.SetActive(true);
        Characters.SetActive(false);
        HelpMenu.SetActive(false);
        CustomNightAI.SetActive(false);
    }
    public void JumpscaresMenuTag()
    {
        TagJumpscare.SetActive(true);
        MusicManJumpscare.SetActive(false);
        PuppetJumpscare.SetActive(false);
        RTagJumpscare.SetActive(false);
    }
    public void JumpscaresMenuPuppet()
    {
        TagJumpscare.SetActive(false);
        MusicManJumpscare.SetActive(false);
        PuppetJumpscare.SetActive(true);
        RTagJumpscare.SetActive(false);
    }
    public void JumpscaresMenuMusicMan()
    {
        TagJumpscare.SetActive(false);
        MusicManJumpscare.SetActive(true);
        PuppetJumpscare.SetActive(false);
        RTagJumpscare.SetActive(false);
    }
    public void JumpscaresMenuRTag()
    {
        TagJumpscare.SetActive(false);
        MusicManJumpscare.SetActive(false);
        PuppetJumpscare.SetActive(false);
        RTagJumpscare.SetActive(true);
    }
    //Custom Menu Button, Turn off Jumpscare, Help and Character stuff
    public void CustomMenu()
    {
        CharacterSelection.SetActive(false);
        JumpscareSelection.SetActive(false);
        HelpMenu.SetActive(false);
        Characters.SetActive(false);
        Jumpscares.SetActive(false);
        CustomNightAI.SetActive(true);
    }
    //Set Tag AI Up
    public void TagUp()
    {
        if (TagAINumber < 20)
        {
            TagAINumber++;
        }
    }
    //Set Tag AI Up
    public void TagDown()
    {
        if (TagAINumber > 0)
        {
            TagAINumber--;
        }
    }
    //Set Puppet AI Up
    public void MarionneUp()
    {
        if (PuppetAINumber < 20)
        {
            PuppetAINumber++;
        }
    }
    //Set Puppet AI Down
    public void MarionneDown()
    {
        if (PuppetAINumber > 0)
        {
            PuppetAINumber--;
        }
    }
    //Set MusicMan AI Up
    public void MusicManUp()
    {
        if (MusicManAINumber < 20)
        {
            MusicManAINumber++;
        }
    }
    //Set MusicMan AI Down
    public void MusicManDown()
    {
        if (MusicManAINumber > 0)
        {
            MusicManAINumber--;
        }
    }
    //Set Reverse Tag AI Down
    public void RTagUp()
    {
        if (RTagAINumber < 20)
        {
            RTagAINumber++;
        }
    }
    //Set Reverse Tag AI Down
    public void RTagDown()
    {
        if (RTagAINumber > 0)
        {
            RTagAINumber--;
        }
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
