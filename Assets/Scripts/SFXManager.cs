﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : Singleton<SFXManager>
{

    [SerializeField]
    private GameObject confettiShower = null;
    [SerializeField]
    private GameObject touchEffect = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            
            Vector3 pos = Input.mousePosition;            
            Vector3 realWorldPos = Camera.main.ScreenToWorldPoint(pos);

            GameObject tEffect = Instantiate(touchEffect, realWorldPos, this.transform.rotation, this.transform);
            AudioShouter.Instance.ShoutClip(9);
        }
        
    }

    public void ActiveConfettiShower(){
        confettiShower.SetActive(true);
    }
}
