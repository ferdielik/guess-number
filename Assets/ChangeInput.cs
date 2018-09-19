using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// todo: write better
public class ChangeInput : MonoBehaviour {

    public Text first;
    public Text second;
    public Text third;
    public Text fourth;

    int focusedIndex = 0;

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


    }

    public void ChangeInputIndex(int index)
    {
        focusedIndex = index;
    }
}
