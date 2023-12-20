using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCollect : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coins")
        {
            score=score+1;
            Destroy(other.gameObject);
            Debug.Log("My score is " + score);
        }
    }
}
