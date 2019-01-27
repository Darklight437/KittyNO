using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private Vector2 creditsXValues;

    [SerializeField]
    private float creditsTransitionTime;

    [SerializeField]
    private GameObject creditsPanel;



    private float currentCreditsPosition = 0;

    private bool showCredits = false;

    public void toggleCredits()
    {
        showCredits = !showCredits;
    }

    private void Update()
    {
        if(showCredits)
        {
            currentCreditsPosition = Mathf.Min(1.0f, currentCreditsPosition + 1.0f / creditsTransitionTime * Time.deltaTime);
        }
        else
        {
            currentCreditsPosition = Mathf.Max(0.0f, currentCreditsPosition - 1.0f / creditsTransitionTime * Time.deltaTime);
        }

        float xValue = Mathf.Lerp(creditsXValues.x, creditsXValues.y, currentCreditsPosition);

        creditsPanel.transform.position = new Vector3(xValue, 0, 0);
    }

    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
