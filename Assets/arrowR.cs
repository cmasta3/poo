using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowR : MonoBehaviour
{
    public int moveSpd = 10;

    public GameObject trump;

    private void OnMouseOver()
    {
            trump.transform.Translate(Vector2.right * moveSpd * Time.deltaTime);
    }
}
