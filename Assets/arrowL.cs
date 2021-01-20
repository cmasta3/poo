using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowL : MonoBehaviour
{
    public int moveSpd = 10;

    public GameObject trump;

    private void OnMouseOver()
    {
            trump.transform.Translate(Vector2.left * moveSpd * Time.deltaTime);
    }
}
