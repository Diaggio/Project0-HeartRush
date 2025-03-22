using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject SessionIDScreen;
    public GameObject MainMenuScreen;
    public GameObject BPMScreen;
    public GameObject hyperatePrefab;

    void Start()
    {
        // Show main menu screen
        MainMenuScreen.SetActive(true);
        SessionIDScreen.SetActive(false);    
        BPMScreen.SetActive(false);
    }

    public void PlayGame()
    {
        // Load session id screen
        MainMenuScreen.SetActive(false);
        SessionIDScreen.SetActive(true);
    }

    public void EnterID() {
        
        // Instantiate the BPM object
        Vector3 position = new Vector3(127, 33, 0); // x, y, z coordinates
        Quaternion rotation = Quaternion.identity; // No rotation
        GameObject hyperateObj = Instantiate(hyperatePrefab, position, rotation);
        Text text = hyperateObj.GetComponent<Text>();
        text.text = "Loading...";
        hyperateObj.GetComponent<hyperateSocket>().Initialize();

        // Load DisplayBPM scene
        SessionIDScreen.SetActive(false);
        BPMScreen.SetActive(true);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}

