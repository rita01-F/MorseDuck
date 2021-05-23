using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Finish : MonoBehaviour
{
    public GameObject FinishText;
    public GameObject TextHeader;
    public GameObject TextScore;
    // Start is called before the first frame update
    void Start()
    {
         
    }
    void Update() {
        
    }
    void OnEnable()
    {
        int playerScore = PlayerPrefs.GetInt("score");
        int AllScore = PlayerPrefs.GetInt("AllScore");
        if (playerScore < AllScore-5)
        {
            TextHeader.GetComponent<Text>().text = "Кажется вы проиграли";
            FinishText.GetComponent<Text>().text = "По вашей милости Утка-Пират навсегда останется на этом острове";
            TextScore.GetComponent<Text>().text = " счет игрока " + playerScore;
        }
        else {
            TextHeader.GetComponent<Text>().text = "Кажется вы выиграли!";
            FinishText.GetComponent<Text>().text = "Вы подарили Утке-Пирату шанс на спасение";
            TextScore.GetComponent<Text>().text = " счет игрока " + playerScore;
        }
        
        print("счет игрока " + playerScore+ " из "+ AllScore);
    }

}
