using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class pipemiddlescript : MonoBehaviour
{
    public logicscript Logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Logic.addscore();
    }
}
