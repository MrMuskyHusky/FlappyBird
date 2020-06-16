using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private float seconds = 4;
    [SerializeField]
    Text startCount;
    [SerializeField]
    GameObject startScreen;

    void Start()
    {
        Time.timeScale = 0;
        
            StartCoroutine(Countdown());
        
    }


    IEnumerator Countdown()
    {       
        if (--seconds == 0)
        {
            CancelInvoke("Countdown");
            startScreen.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            startCount.text = "Starting : " + seconds;
        }
        yield return new WaitForSecondsRealtime(1);
        StartCoroutine(Countdown());
    }
}
