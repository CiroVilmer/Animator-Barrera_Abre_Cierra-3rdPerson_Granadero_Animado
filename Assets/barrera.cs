﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrera : MonoBehaviour
{
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        anim.SetBool("ObjetoEnRango", true);
    }

    void OnTriggerExit()
    {
        anim.SetBool("ObjetoEnRango", false);
    }

}
