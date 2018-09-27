using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// todo: write better
public class ChangeInput : MonoBehaviour {

    public Text first;
    public Text second;
    public Text third;
    public Text fourth;

    public Text result;
    public Text randomNumber;

    int focusedIndex = 0;
    string actualNumber;

    System.Random ran = new System.Random();

    ChangeInput() {
        actualNumber = random();
    }

    public void ChangeInputValue(int value) {
        Debug.Log("new value " + value.ToString());
        Debug.Log("new index " + focusedIndex.ToString());
        switch (focusedIndex) {
            case 0:
                first.text = value.ToString();
                break;
            case 1:
                second.text = value.ToString();
                break;
            case 2:
                third.text = value.ToString();
                break;
            case 3:
                fourth.text = value.ToString();
                break;
        }
        focusedIndex++;
    }

    public void ChangeInputIndex(int index)
    {
        focusedIndex = index;
    }

    public void CheckScore()
    {
        string guess = first.text + second.text + third.text + fourth.text;
        result.text = findPoint(actualNumber, guess);
        randomNumber.text = actualNumber;
    }

    private string random()
    {
        int[] numbers = new int[] {1,2,3,4,5,6,7,8,9};
        int _min = 0;
        int _max = numbers.Length;

        for (int i = 0; i < 20; i++)
        {
            int i1 = ran.Next(_min, _max);
            int i2 = ran.Next(_min, _max);

            int temp = numbers[i1];
            numbers[i1] = numbers[i2];
            numbers[i2] = temp;
        }
        return numbers[0] + "" + numbers[1] + "" + numbers[2] + "" + numbers[3]; // i know its ugly
    }


    private string findPoint(string number, string guessNumber)
    {
        int plusPoint = 0;
        int minusPoint = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == guessNumber[i])
            {
                plusPoint++;
            }
            else
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[i] == guessNumber[j])
                    {
                        minusPoint++;
                        break;
                    }
                }
            }
        }
        return ("+" + plusPoint + "  " + " - " + minusPoint);
    }
}
