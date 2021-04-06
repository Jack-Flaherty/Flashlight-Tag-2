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
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ExtrasButton()
    {
        titleMenu.SetActive(false);
        sceneAssets.SetActive(false);
        extrasMenu.SetActive(true);
    }
    public void BackButton()
    {
        titleMenu.SetActive(true);
        sceneAssets.SetActive(true);
        extrasMenu.SetActive(false);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
