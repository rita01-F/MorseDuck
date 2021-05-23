using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchCatcher : MonoBehaviour
{
    public GameObject QuestSign;
    public GameObject dotPrefab;
    private float temps;
    List<string> quest = new List<string>();
    List<int> inputs = new List<int>();
    List<int> answer = new List<int>();
    int countQuest = 0;
    int countAnswers = 0;

    void Start()
    {
        quest = GenerateQuest();
        answer = GenerateAnswer(quest);
        print(quest.Count);

        StartCoroutine("DoMessage");

    }

    IEnumerator DoMessage()
    {
        for (; ; )
        {
            Message();
            if ((countQuest) <= quest.Count)
            {
                yield return new WaitForSeconds(6f);
            }
                yield return null;
        }
    }

    void Message()
    {   if ((countQuest) < quest.Count)
        {
            print("less " + countQuest + " " + quest.Count + " " + quest[countQuest]);
            QuestSign.GetComponent<Text>().text = (countQuest+1) + ") " + quest[countQuest];
            countQuest += 1;
        }
        else {
            if ((countQuest) == quest.Count) {
                print("here");
                CheckList();
                countQuest += 1;
            }
                
            
        }
        
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            temps = Time.time;

        }

        if (Input.GetMouseButtonUp(0) )
        {
            if ((Time.time - temps) < 0.2)
            {
                print("clicked!");
                inputs.Add(0);
                DrawDot();
            }
            else {
                inputs.Add(1);
                
            }
            print(inputs.Count+ " !!!!!!!!!!!!!!!!");
            
        }

        if (Input.GetMouseButton(0) && (Time.time - temps) > 0.2)
        {
            print("loooooooooooong");
            DrawDot();
        }
    }
    private void DrawDot() 
    {
        Instantiate(dotPrefab, new Vector3(-0.116f, -2.293f, 0), transform.rotation);
    }

    private void CheckList()
    {
        
        for (int i = 0; i<answer.Count; i++)
            {
            
            
                if (inputs[i] == answer[i])
                {
                    print(inputs[i]);
                    countAnswers += 1;
                    print("OK");
                }
            
        }
        print("œ–¿¬»À‹Õ€’ Œ“¬≈“Œ¬ " + countAnswers + " ËÁ " + answer.Count);
        OnDisable();
        SceneManager.LoadScene("Finish");
        
    }
    void OnDisable()
    {
        PlayerPrefs.SetInt("score", countAnswers);
        PlayerPrefs.SetInt("AllScore", answer.Count);
    }
    private List<string> GenerateQuest() {
        List<string> result = new List<string>();
        string symbols = "‡·‚„‰ÂÊÁËÍ";

        for (int i = 0; i < 10; i++)
        {
            int value = Random.Range(0, 9);
            result.Add(symbols[value].ToString());
            print(result[i] +" "+ i);
        }
        return result;
    }
    private List<int> GenerateAnswer(List<string> quest)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            
                switch (quest[i])
            {
                case "‡":
                    result.Add(0);
                    result.Add(1);
                    break;
                case "·":
                    result.Add(1);
                    result.Add(0);
                    result.Add(0);
                    result.Add(0);
                    break;
                case "‚":
                    result.Add(0);
                    result.Add(1);
                    result.Add(1);
                    break;
                case "„":
                    result.Add(1);
                    result.Add(1);
                    result.Add(0);
                    break;
                case "‰":
                    result.Add(1);
                    result.Add(0);
                    result.Add(0);
                    break;
                case "Â":
                    result.Add(0);
                    break;
                case "Ê":
                    result.Add(0);
                    result.Add(0);
                    result.Add(0);
                    result.Add(1);
                    break;
                case "Á":
                    result.Add(1);
                    result.Add(1);
                    result.Add(0);
                    result.Add(0);
                    break;
                case "Ë":
                    result.Add(0);
                    result.Add(0);
                    break;
                default:
                    print("Default case");
                    print(quest[i]);
                    break;

            }
            print(result[i] + " " + i);
        }
        return result;
    }
}
