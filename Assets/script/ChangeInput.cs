﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// todo: write better
// i know its ugly

enum Hardness {Easy=3, Normal=4, Medium=5, Hard=6, Brutal=8}

public class ChangeInput : MonoBehaviour {

    public Text guess;

    Hardness hardness = Hardness.Hard;
    public Text[] numbers = new Text[(int) Hardness.Hard];

    public Text result;
    public Text cursor;
    public Text randomNumber;


    int focusedIndex = 0;
    string actualNumber;

    System.Random ran = new System.Random();

    ChangeInput() {
        actualNumber = random((int)hardness);
        numbers = new Text[(int)Hardness.Medium];
    }

    public void ChangeInputValue(int value) {
        guess.text = changeValue(guess.text, focusedIndex, value);
        IncreaseIndex();
    }

    public void IncreaseIndex()
    {
        focusedIndex = (focusedIndex + 1) % ((int)hardness);
        updateCursor();
    }

    public void DecreaseIndex()
    {
        focusedIndex = (focusedIndex - 1 + ((int)hardness)) % ((int)hardness);
        updateCursor();
    }

    private string changeValue(string str, int index, int newValue)
    {
        return str.Substring(0, index) + newValue + str.Substring(index + 1, (str.Length - 1 - index));
    }

    private void updateCursor()
    {
        cursor.text = "";
        for (int i = 0; i < guess.text.Length; i++)
        {
            cursor.text += i == focusedIndex ? "_" : "  ";
        }
    }

    public void ChangeInputIndex(int index)
    {
        focusedIndex = index;
    }

    public void CheckScore()
    {
        result.text = findPoint(actualNumber, guess.text);
        randomNumber.text = actualNumber;
    }

    private string random(int size)
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

        string res = "";
        for (int i = 0; i < size; i++)
        {
            res += numbers[i];
        }

        return res; 
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

    private bool checkUniqueNumber(string num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = i + 1; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
