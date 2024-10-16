using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image fadeImage; // The UI Image to cover the screen for fade effect
    public float fadeDuration = 1f; // Duration of the fade
    public Vector3 scalePressed = new Vector3(0.2f, 0.2f, 0.2f); // Scale size when pressed
    public float scaleDuration = 0.1f; // Duration of the scaling effect
    private Vector3 originalScale; // To store the original scale of the button

    private void Start()
    {
        originalScale = transform.localScale; // Store the original scale of the button
        fadeImage.gameObject.SetActive(true); // Make sure the fade image is active
        StartCoroutine(FadeIn()); // Start with a fade-in effect when the scene loads
    }

    // Called when the button is clicked
    public void OnButtonClick()
    {
        StartCoroutine(ButtonPressEffect()); // Start the scaling and scene transition effect
    }

    // Coroutine to handle the button press scaling effect
    private IEnumerator ButtonPressEffect()
    {
        // Scale up the button
        transform.localScale = scalePressed;
        yield return new WaitForSeconds(scaleDuration); // Wait for the scaling effect
        transform.localScale = originalScale; // Return to original scale

        // Start the fade-out and load the scene1
        StartCoroutine(FadeOutAndLoadScene());
    }

    // Fade in when the scene is loaded
    private IEnumerator FadeIn()
    {
        fadeImage.canvasRenderer.SetAlpha(1.0f); // Set the image to fully opaque
        fadeImage.CrossFadeAlpha(0, fadeDuration, false); // Fade out the image over time
        yield return new WaitForSeconds(fadeDuration); // Wait for the fade to complete
        fadeImage.gameObject.SetActive(false); // Hide the image after the fade is done
    }

    // Fade out and load the scene1
    private IEnumerator FadeOutAndLoadScene()
    {
        fadeImage.gameObject.SetActive(true); // Show the image for the fade-out
        fadeImage.canvasRenderer.SetAlpha(0.0f); // Make the image transparent
        fadeImage.CrossFadeAlpha(1, fadeDuration, false); // Fade in the image to black
        yield return new WaitForSeconds(fadeDuration); // Wait for the fade to complete

        SceneManager.LoadScene("Scene1"); // Load the next scene (replace with your scene name)
    }
}
