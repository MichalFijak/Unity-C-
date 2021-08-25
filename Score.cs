
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform pl;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = pl.position.x.ToString("0");
    }
}
