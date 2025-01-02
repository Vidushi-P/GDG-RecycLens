using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject welcomeScreenCanvas;
    public GameObject secondScreenCanvas;
    public GameObject arCamera;

    void Start()
    {
        // Ensure the initial states of canvases and AR Camera
        welcomeScreenCanvas.SetActive(true);
        secondScreenCanvas.SetActive(false);
        arCamera.SetActive(false);
    }

    public void OnProceedButtonClicked()
    {
        welcomeScreenCanvas.SetActive(false);
        secondScreenCanvas.SetActive(true);
    }

    public void OnOkayButtonClicked()
    {
        secondScreenCanvas.SetActive(false);
        arCamera.SetActive(true);
    }
}
