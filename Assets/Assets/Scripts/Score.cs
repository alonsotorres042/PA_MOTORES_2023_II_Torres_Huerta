using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI ActualScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SumarPuntos(float ConteinedScore)
    {
         float r = float.Parse(ActualScore.text) + ConteinedScore;
        ActualScore.text = r.ToString();
    }
}
