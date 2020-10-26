using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var controllerNames = Input.GetJoystickNames();

        print(controllerNames);
        //// 一台もコントローラが接続されていなければエラー
        if (controllerNames[0] == "") Debug.Log("Error");
    }

        // Update is called once per frame
        void Update()
    {
        if(Input.anyKey)
        {
            print("A");
        }
    }
}
