using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StepNavigation : MonoBehaviour
{
    public GameObject[] steps; // Array of step GameObjects
    public TextMeshProUGUI stepDescription; // TextMeshPro for descriptions
    public Button nextButton; // Next button
    public Button prevButton; // Previous button

    private int currentStep = 0;

    void Start()
    {
        UpdateStep();
        prevButton.gameObject.SetActive(false); // Hide previous button initially
    }

    public void NextStep()
    {
        currentStep++;
        UpdateStep();
    }

    public void PrevStep()
    {
        currentStep--;
        UpdateStep();
    }

    private void UpdateStep()
    {
        // Hide all steps
        foreach (GameObject step in steps)
        {
            step.SetActive(false);
        }

        // Show the current step
        steps[currentStep].SetActive(true);

        // Update the text description
        stepDescription.text = steps[currentStep].GetComponentInChildren<TextMeshProUGUI>().text;

        // Manage button visibility
        prevButton.gameObject.SetActive(currentStep > 0);
        nextButton.gameObject.SetActive(currentStep < steps.Length - 1);
    }
}
