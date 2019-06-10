using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    private float timer;
    private bool shouldChangeColor;
    
    // Start is called before the first frame update
    private void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (shouldChangeColor)
        {
            CheckTimer();    
        }
    }

    private void CheckTimer()
    {
        if (Time.time - timer > 2f)
        {
            ChangeColor();
            shouldChangeColor = false;
        }
    }

    public void ChangeColor()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    public void Entered()
    {
        StartTimer();
        shouldChangeColor = true;
    }

    public void Exit()
    {
        timer = 0;
        shouldChangeColor = false;
    }

    private void StartTimer()
    {
        timer = Time.time;
    }
}
