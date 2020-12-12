using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float time;
    public Text timerText;
    public ValuesObject gameValues;
    public GameObject loseText;

    public string aliveString = "You've survived: ";
    public string deadString = "You survived: ";

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        string tense;

        if (loseText.activeInHierarchy)
        {
            timerText.text = deadString + time.ToString();
            tense = " was ";
        }
        else
        {
            timerText.text = aliveString + time.ToString();
            tense = " is ";
        }
        timerText.text += " seconds";

        timerText.text += "\n Difficulity increase" + tense + "set to " + gameValues.timerMax + ", SpawnFrequency" + tense + "set to " + gameValues.spawnMax;
        timerText.text += "\n starting difficulity: " + gameValues.startDifficulity + ", difficulity multiplier: " + gameValues.diffMult + ", and max difficulity: " + gameValues.maxDifficulity;
    }
}
