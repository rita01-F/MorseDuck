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
            TextHeader.GetComponent<Text>().text = "������� �� ���������";
            FinishText.GetComponent<Text>().text = "�� ����� ������� ����-����� �������� ��������� �� ���� �������";
            TextScore.GetComponent<Text>().text = " ���� ������ " + playerScore;
        }
        else {
            TextHeader.GetComponent<Text>().text = "������� �� ��������!";
            FinishText.GetComponent<Text>().text = "�� �������� ����-������ ���� �� ��������";
            TextScore.GetComponent<Text>().text = " ���� ������ " + playerScore;
        }
        
        print("���� ������ " + playerScore+ " �� "+ AllScore);
    }

}
