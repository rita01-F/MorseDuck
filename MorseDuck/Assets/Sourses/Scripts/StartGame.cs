using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    private float megaTimer;
    // Start is called before the first frame update
    void Start()
    {
        megaTimer = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (megaTimer < 0) megaTimer = 0;
        if (megaTimer > 0) megaTimer -= Time.deltaTime;

        if (megaTimer == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
