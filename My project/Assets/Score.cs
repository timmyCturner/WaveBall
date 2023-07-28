using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public GameObject plane;
    public GameObject ball;
    private TextMeshProUGUI textDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
       textDisplay = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (plane.transform.position, ball.transform.position);
        int simpDistance = (int)distance;
        textDisplay.text = simpDistance.ToString();
    }
}
