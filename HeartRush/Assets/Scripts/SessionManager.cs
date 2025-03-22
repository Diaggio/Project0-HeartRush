using UnityEngine;
using UnityEngine.UI;
using TMPro; // Only needed if using TextMeshPro

public class SessionManager : MonoBehaviour
{
    // References to UI elements
    [SerializeField] private TMP_InputField inputField; // Use InputField if not using TextMeshPro
    [SerializeField] private Button submitButton;
    public GameObject MenuManager;
    private MainMenu mainMenu;

    private void Start()
    {
        // Add listener for button click
        submitButton.onClick.AddListener(SaveSessionID);
        
        // Optional: Load existing session ID if it exists
        if (PlayerPrefs.HasKey("sessionID"))
        {
            inputField.text = PlayerPrefs.GetString("sessionID");
        }

        
    }

    public void SaveSessionID()
    {
        // Get text from input field
        string sessionID = inputField.text;
        
        // Save to PlayerPrefs
        PlayerPrefs.SetString("sessionID", sessionID);
        PlayerPrefs.Save();
        
        Debug.Log("Saved session ID: " + sessionID);
        
        if (MenuManager != null)
        {
            mainMenu = MenuManager.GetComponent<MainMenu>();

            if (mainMenu == null)
            {
                Debug.LogError("MainMenu component not found on MenuManager object.");
            } else {
                mainMenu.EnterID();
            }
        }
    }
}
