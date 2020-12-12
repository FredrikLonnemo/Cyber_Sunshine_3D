using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public ValuesObject gameValues;
    public Slider sliderInput;
    public InputField textInput;

    public int selectedValue;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        switch (selectedValue)
        {
            case 0:
                SetTimer(gameValues.timerMax);
                break;
            case 1:
                SetSpawn(gameValues.spawnMax);
                break;
            case 2:
                SetStartDiff(gameValues.startDifficulity);
                break;
            case 3:
                SetDiffMult(gameValues.diffMult);
                break;
            case 4:
                SetMaxDiff(gameValues.maxDifficulity);
                break;
            case 5:
                SetSensitivity(gameValues.lookSensitivity);
                break;
            default:
                break;
        }
    }

    public void SetTimer(float value)
    {
        gameValues.timerMax = (int)value;
        sliderInput.value = value;
        textInput.text = value.ToString();
    }
    public void SetTimer(string value)
    {
        gameValues.timerMax = int.Parse(value);
        textInput.text = value;
        sliderInput.value = float.Parse(value);
    }
    public int GetTimer()
    {
        return gameValues.timerMax;
    }

    public void SetSpawn(float value)
    {
        gameValues.spawnMax = (int)value;
        sliderInput.value = value;
        textInput.text = value.ToString();
    }
    public void SetSpawn(string value)
    {
        gameValues.spawnMax = int.Parse(value);
        textInput.text = value;
        sliderInput.value = float.Parse(value);
    }
    public int GetSpawn()
    {
        return gameValues.spawnMax;
    }

    public void SetStartDiff(float value)
    {
        gameValues.startDifficulity = (int)value;
        sliderInput.value = value;
        textInput.text = value.ToString();
    }
    public void SetStartDiff(string value)
    {
        gameValues.startDifficulity = int.Parse(value);
        textInput.text = value;
        sliderInput.value = float.Parse(value);
    }
    public int GetStartDiff()
    {
        return gameValues.startDifficulity;
    }

    public void SetDiffMult(float value)
    {
        gameValues.diffMult = value;
        sliderInput.value = value;
        textInput.text = value.ToString();
    }
    public void SetDiffMult(string value)
    {
        gameValues.diffMult = float.Parse(value);
        textInput.text = value;
        sliderInput.value = float.Parse(value);
    }
    public float GetDiffMult()
    {
        return gameValues.timerMax;
    }

    public void SetMaxDiff(float value)
    {
        gameValues.maxDifficulity = (int)value;
        sliderInput.value = value;
        textInput.text = value.ToString();
    }
    public void SetMaxDiff(string value)
    {
        gameValues.maxDifficulity = int.Parse(value);
        textInput.text = value;
        sliderInput.value = float.Parse(value);
    }
    public int GetMaxDiff()
    {
        return gameValues.maxDifficulity;
    }

    public void SetSensitivity(float value)
    {
        gameValues.lookSensitivity = value;
        sliderInput.value = value;
        textInput.text = value.ToString();
    }
    public void SetSensitivity(string value)
    {
        gameValues.lookSensitivity = float.Parse(value);
        textInput.text = value;
        sliderInput.value = float.Parse(value);
    }
}
