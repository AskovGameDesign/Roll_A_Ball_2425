using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public TextMeshProUGUI pickupText;
    string scoreText = "Pickup count";
    int pickupCount;

    // Start is called before the first frame update
    void Start()
    {
        pickupText.text = scoreText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPickedUp()
    {
        pickupCount += 1;

        pickupText.text = scoreText + " " + pickupCount.ToString();
    }
}
